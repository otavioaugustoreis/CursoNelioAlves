using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoNelioAlves.Enums
{
    public  class Pedido
    {

        public int Id { get; set; }

        public StatusPedido _StatusPedido { get; set; }


        public Pedido() { }

        public Pedido(int id, StatusPedido statusPedido)
        {
            Id = id;
            _StatusPedido = statusPedido;
        }
    }
}
