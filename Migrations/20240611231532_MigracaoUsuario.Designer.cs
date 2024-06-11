﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoInterDisciplinar.Data;

#nullable disable

namespace ProjetoInterDisciplinar.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240611231532_MigracaoUsuario")]
    partial class MigracaoUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Conclusao_Disciplinar.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIOS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "seuEmail@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 157, 253, 44, 73, 140, 141, 161, 146, 183, 6, 103, 34, 218, 24, 219, 166, 92, 142, 50, 136, 5, 11, 205, 207, 112, 88, 227, 172, 105, 41, 191, 47, 43, 194, 30, 71, 235, 113, 21, 209, 170, 223, 114, 62, 191, 117, 219, 52, 142, 51, 238, 93, 34, 148, 97, 121, 130, 187, 178, 245, 44, 130, 210, 146 },
                            PasswordSalt = new byte[] { 93, 88, 242, 196, 137, 145, 236, 51, 96, 164, 253, 117, 116, 22, 241, 136, 151, 38, 79, 215, 227, 125, 164, 167, 56, 182, 157, 18, 21, 215, 223, 147, 51, 25, 136, 219, 169, 180, 88, 44, 132, 101, 38, 176, 99, 255, 164, 251, 35, 86, 92, 111, 133, 85, 186, 84, 251, 107, 235, 253, 206, 70, 240, 152, 21, 137, 98, 35, 185, 209, 135, 205, 189, 179, 1, 111, 144, 31, 250, 237, 65, 21, 183, 103, 243, 146, 133, 93, 90, 21, 232, 44, 4, 91, 118, 124, 170, 234, 49, 182, 6, 42, 172, 214, 182, 146, 182, 41, 143, 118, 113, 251, 137, 92, 19, 9, 94, 218, 14, 161, 247, 232, 65, 210, 108, 220, 79, 19 },
                            Perfil = "Admin",
                            Username = "UsuarioAdmin"
                        });
                });

            modelBuilder.Entity("ProjetoInterDisciplinar.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Funcao")
                        .HasColumnType("int");

                    b.Property<int>("HorasDeServico")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_FUNCIONARIOS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Funcao = 2,
                            HorasDeServico = 8,
                            Nome = "Guilherme"
                        },
                        new
                        {
                            Id = 2,
                            Funcao = 6,
                            HorasDeServico = 8,
                            Nome = "Jessica"
                        },
                        new
                        {
                            Id = 3,
                            Funcao = 1,
                            HorasDeServico = 8,
                            Nome = "Leonardo"
                        },
                        new
                        {
                            Id = 4,
                            Funcao = 3,
                            HorasDeServico = 8,
                            Nome = "Lucas"
                        },
                        new
                        {
                            Id = 5,
                            Funcao = 4,
                            HorasDeServico = 8,
                            Nome = "Rogerio"
                        },
                        new
                        {
                            Id = 6,
                            Funcao = 5,
                            HorasDeServico = 8,
                            Nome = "Cleber Machado"
                        });
                });

            modelBuilder.Entity("ProjetoInterDisciplinar.Models.Funcionario", b =>
                {
                    b.HasOne("Conclusao_Disciplinar.Models.Usuario", null)
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Conclusao_Disciplinar.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}