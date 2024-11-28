using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class Product
    {
        public string Nome { get; set; }
        public double Preco  { get; set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }


        public override string ToString() => $"Nome : {Nome} \n" +
            $"Preço: {Preco}";

        //Jeito antigo
        //public int CompareTo(Product? other)
        //{
        //    return this.Nome.ToUpper().CompareTo(other.Nome.ToUpper());
        //}
    }
}
