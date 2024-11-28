using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Pessoa
    {
        public int Idade
        {
            set
            {
                if (value <= 0) 
                {
                    throw new PessoaException();
                }
            }
        }
    }
}
