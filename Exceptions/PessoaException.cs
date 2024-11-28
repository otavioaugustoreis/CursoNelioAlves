using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    //Criando exceção personalizada 
    public class PessoaException : Exception
    {
        //Criei isso a parte para testar um default message
        private const string DEFAULT_MENSAGEM_PESSOA = "Cadastro de pessoa inválido";
        public PessoaException(string message = DEFAULT_MENSAGEM_PESSOA) : base(message)
        {
        }
    }
}
