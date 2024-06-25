using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conclusao_Disciplinar.Models;
using Conclusao_Disciplinar.Utils;
using Microsoft.EntityFrameworkCore; 
/// HERANÇA DO BANCO DE DADOS
using ProjetoInterDisciplinar.Models; // Herança da API
using ProjetoInterDisciplinar.Models.Enuns; // Herança da função dos funcionários


namespace ProjetoInterDisciplinar.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> TB_FUNCIONARIOS { get; set; }// Nome para utilizar no codigo
        public DbSet<Usuario> TB_USUARIOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>().ToTable("TB_FUNCIONARIOS"); //nome para chamar no banco de dados
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");
            modelBuilder.Entity<Funcionario>().HasData
            (
                new Funcionario() { Id = 1, Nome = "Guilherme", Funcao = FuncaoEnum.TI, HorasDeServico = 8 },
                new Funcionario() { Id = 2, Nome = "Jessica", Funcao = FuncaoEnum.Vendas, HorasDeServico = 8 },
                new Funcionario() { Id = 3, Nome = "Leonardo", Funcao = FuncaoEnum.AssistenteAdministrativo, HorasDeServico = 8 },
                new Funcionario() { Id = 4, Nome = "Lucas", Funcao = FuncaoEnum.Limpeza, HorasDeServico = 8 },
                new Funcionario() { Id = 5, Nome = "Rogerio", Funcao = FuncaoEnum.Gestao, HorasDeServico = 8 },
                new Funcionario() { Id = 6, Nome = "Cleber Machado", Funcao = FuncaoEnum.Recepcao, HorasDeServico = 8 });            
                ;

                //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.UserName = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);
            //Fim da criação do usuário padrão.   

        }
                protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
                {
                    configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
                }

        }

    }
