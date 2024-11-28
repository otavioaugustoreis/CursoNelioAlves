using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica()
        {
        }

        public PessoaFisica(int id, string nome) : base(id, nome)
        {
            _Idade = id;
        }
    
        
    }
}
