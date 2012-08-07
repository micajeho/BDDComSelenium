using System;

namespace IRPF.Models
{
    public class CalcularIdade
    {
        public String Mensagem;
        public DateTime DataBase { get; set; }
        public DateTime DataNascimento { get; set; }

        public void calcularIdade()
        {
            int diff = DateTime.Compare(DataBase, DataNascimento);
            Mensagem = diff < 18 ? "Usuario menor idade" : "Usuario maior idade";
        }
    }
}