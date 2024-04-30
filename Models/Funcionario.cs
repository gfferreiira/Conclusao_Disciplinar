
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoInterDisciplinar.Models.Enuns;


namespace ProjetoInterDisciplinar.Models    
{
    public class Funcionario
    {
        public int Id { get; set; }
        
        public string Nome { get; set; } = string.Empty;

        public FuncaoEnum Funcao { get; set; }

        public int HorasDeServico { get; set; }


    }
}