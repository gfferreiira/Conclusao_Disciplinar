using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoInterDisciplinar.Models;

namespace Conclusao_Disciplinar.Models
{
    public class Usuario
    {
        public int Id { get; set; } //Atalho para propridade (PROP + TAB)
        public string UserName { get; set; } = string.Empty;
        public byte[]? PasswordHash { get; set; } 
        public byte[]? PasswordSalt { get; set; } 
        public byte[]? Foto { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? DataAcesso { get; set; } //using System;

        [NotMapped] // using System.ComponentModel.DataAnnotations.Schema
        public string PasswordString { get; set; } = string.Empty;
        public List<Funcionario> Personagens { get; set; } = new List<Funcionario>();//using System.Collections.Generic;
        public string Perfil { get; set; }  = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}