using ApiDomain.Dtos;
using ApiDomain.Entities;
using ApiDomain.Interfaces.Services.User;
using ApiDomain.Repository;
using ApiDomain.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace ApiServices.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;

        private SingningConfigurations _singningConfigurations;
        private TokenConfigurations _tokenConfigurations;
        private IConfiguration _configuration;
        public LoginService(IUserRepository repository,
                            SingningConfigurations singningConfigurations,
                            TokenConfigurations tokenConfigurations,
                             IConfiguration configuration)
        {
            _repository = repository;
            _singningConfigurations = singningConfigurations;
            _tokenConfigurations = tokenConfigurations;
            _configuration = configuration;
        }

        public async Task<object> FindByLogin(LoginDto user)
        {
            var baseUser = new UserEntity();

            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                baseUser = await _repository.FindByLogin(user.Email);

                if (baseUser == null)
                {
                    return new
                    {
                        authenticated = false,
                        message = "Falha ao autenticar"
                    };
                }
                else
                {
                    var identity = new ClaimsIdentity
                   (
                       new GenericIdentity(user.Email),
                       new[]
                       {
                           new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                           new Claim(JwtRegisteredClaimNames.UniqueName,user.Email),
                       }
                   );

                    DateTime createDate = DateTime.Now;
                    DateTime expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfigurations.Seconds);

                    var handler = new JwtSecurityTokenHandler();

                    string token = CreateToken(identity, createDate, expirationDate, handler);
                    return SuccesObject(createDate, expirationDate, token, baseUser);


                }
            }

            return new
            {
                authenticated = false,
                message = "Falha ao autenticar"
            };
        }


        private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler handler)
        {
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfigurations.Issuer,
                Audience = _tokenConfigurations.Audience,
                SigningCredentials = _singningConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirationDate,
            });

            var token = handler.WriteToken(securityToken);
            return token;
        }

        private object SuccesObject(DateTime createDate, DateTime expirationDate, string token, UserEntity user)
        {
            return new
            {
                authenticated = true,
                created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                acessToken = token,
                userName = user.Email,
                name = user.Name,
                message = "Usuário Logado com Sucesso"
            };
        }
    }
}
