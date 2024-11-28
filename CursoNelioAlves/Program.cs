// See https://aka.ms/new-console-template for more information
using CursoNelioAlves.Enums;

Console.WriteLine("Curso do Nélião - PWI");

Pedido p1 = new Pedido(1, StatusPedido.PENDENTE);


string enums = p1._StatusPedido.ToString();

Console.WriteLine(enums);