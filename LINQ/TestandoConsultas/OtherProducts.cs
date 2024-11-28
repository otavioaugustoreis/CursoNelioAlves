using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.TestandoConsultas
{
    public class OtherProducts
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category _Category { get; set; }

        public OtherProducts(int id, string name, Category category)
        {
            Id = id;
            Name = name;
            _Category = category;
        }

        public OtherProducts()
        {
        }

        public override string ToString() => $"Id: {Id} {Environment.NewLine}" +
          $"Nome: {Name} {Environment.NewLine}" +
          $"Categoria: {_Category}";

    }
}
