namespace AppProjetoAluno.Models
{
    public class CalcularNotas
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Media { get; set; }

        public double CalcularMedia()
        {
           return(Nota1 + Nota2) /2;
        }
        public string? Situacao()
        {
           string? result = null;
            if(CalcularMedia() <6) result = "Reprovado";
            if (CalcularMedia() > 6) result = "Aprovado";
            return result; 
        }

    }
}
