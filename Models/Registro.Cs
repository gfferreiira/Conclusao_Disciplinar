namespace ProjetoInterDisciplinar.Models 
{
    public class Registro
    {
        public DateTime Data { get; set; }
        public TimeOnly Hora_Entrada { get; set; }
        public TimeOnly Hora_Saida { get; set; }

        public float Horas_Positivas { get; set; }
        public float Horas_Negativas { get; set; }
    }
} 
