﻿// <auto-generated />
using System;
using ApiData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiData.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20221119003017_Estado_Cidade_Endereco")]
    partial class Estado_Cidade_Endereco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiDomain.Entities.CidadeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EstadoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("ApiDomain.Entities.EnderecoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<Guid>("CidadeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Logadouro")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Cep");

                    b.HasIndex("CidadeId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ApiDomain.Entities.EstadoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Estado");

                    b.HasData(
                        new
                        {
                            Id = new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7473),
                            Nome = "Acre"
                        },
                        new
                        {
                            Id = new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7508),
                            Nome = "Alagoas"
                        },
                        new
                        {
                            Id = new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7512),
                            Nome = "Amazonas"
                        },
                        new
                        {
                            Id = new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7515),
                            Nome = "Amapá"
                        },
                        new
                        {
                            Id = new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7517),
                            Nome = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7518),
                            Nome = "Ceará"
                        },
                        new
                        {
                            Id = new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7520),
                            Nome = "Distrito Federal"
                        },
                        new
                        {
                            Id = new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7522),
                            Nome = "Espírito Santo"
                        },
                        new
                        {
                            Id = new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7524),
                            Nome = "Goiás"
                        },
                        new
                        {
                            Id = new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7526),
                            Nome = "Maranhão"
                        },
                        new
                        {
                            Id = new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7528),
                            Nome = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7530),
                            Nome = "Mato Grosso do Sul"
                        },
                        new
                        {
                            Id = new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7532),
                            Nome = "Mato Grosso"
                        },
                        new
                        {
                            Id = new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7534),
                            Nome = "Pará"
                        },
                        new
                        {
                            Id = new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7535),
                            Nome = "Paraíba"
                        },
                        new
                        {
                            Id = new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7567),
                            Nome = "Pernambuco"
                        },
                        new
                        {
                            Id = new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7569),
                            Nome = "Piauí"
                        },
                        new
                        {
                            Id = new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7571),
                            Nome = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7573),
                            Nome = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7575),
                            Nome = "Rio Grande do Norte"
                        },
                        new
                        {
                            Id = new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7576),
                            Nome = "Rondônia"
                        },
                        new
                        {
                            Id = new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7578),
                            Nome = "Roraima"
                        },
                        new
                        {
                            Id = new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7580),
                            Nome = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7582),
                            Nome = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7584),
                            Nome = "Sergipe"
                        },
                        new
                        {
                            Id = new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7586),
                            Nome = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                            CreateAt = new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7588),
                            Nome = "Tocantins"
                        });
                });

            modelBuilder.Entity("ApiDomain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9b148b1d-46f4-4610-8a39-b8049afa8d34"),
                            CreateAt = new DateTime(2022, 11, 18, 21, 30, 16, 888, DateTimeKind.Local).AddTicks(4236),
                            Email = "Dexter@gmail.com",
                            Name = "DexterAdmin",
                            UpdateAt = new DateTime(2022, 11, 18, 21, 30, 16, 889, DateTimeKind.Local).AddTicks(468)
                        });
                });

            modelBuilder.Entity("ApiDomain.Entities.CidadeEntity", b =>
                {
                    b.HasOne("ApiDomain.Entities.EstadoEntity", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiDomain.Entities.EnderecoEntity", b =>
                {
                    b.HasOne("ApiDomain.Entities.CidadeEntity", "Cidade")
                        .WithMany("Enderecos")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}