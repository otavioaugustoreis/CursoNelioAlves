using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.ExercicioList
{
    public class FuncionarioService
    {
        public Funcionario Funcionario { get; set; }

        public FuncionarioService(Funcionario funcionario)
        {
            Funcionario = funcionario;
        }

        public static void FazerAumento(Funcionario funcionario){
                var porcem = (funcionario.Salario * 10) / 100;
                funcionario.Salario += porcem;
        }
    }
}
