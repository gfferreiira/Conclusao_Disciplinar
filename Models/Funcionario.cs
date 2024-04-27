using ProjetoInterDisciplinar.Models.Enuns;


namespace ProjetoInterDisciplinar.Models    
{
    public class Funcionario
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public FuncaoEnum Funcao { get; set; }

        public int HorasDeServico { get; set; }


    }
}