using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoInterDisciplinar.Models.Enuns;

namespace ProjetoInterDisciplinar.Models 
{
    public class Registro
    {
        public Funcionario IdFuncionario { get; set; } = null;

        public DateTime Data { get; set; }
        public TimeOnly Hora_Entrada { get; set; }
        public TimeOnly Hora_Saida { get; set; }

        public float Horas_Positivas { get; set; }
        public float Horas_Negativas { get; set; }
    }
} 
