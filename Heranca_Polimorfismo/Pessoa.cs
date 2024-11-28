using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    public class Pessoa
    {

        private int Id;

        //Posso ver apenas na herança, ou seja, apenas dentro da classe pessoaFisica e não na Program.cs
        protected int  _Idade { get; set; }
        public string _Nome { get; set; }
        
        public Pessoa(int id, string nome )
        {
            Id = id;            _Nome = nome;
        }
        public Pessoa()
        {
        }
    }
}
