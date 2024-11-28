using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.ExercicioProposto
{
    public class OtherFuncionario
    {
        public string  Nome { get; set; }

        public string Email { get; set; }

        public double Salario { get; set; }

        public OtherFuncionario() { }

        public OtherFuncionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }

        public override string ToString() => $"Email : {Email} {Environment.NewLine} " +
          $"Nome : {Nome}  {Environment.NewLine}" +
          $"Salario : {Salario} {Environment.NewLine}";
    }
}
