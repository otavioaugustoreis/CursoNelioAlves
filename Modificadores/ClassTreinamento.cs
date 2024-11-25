using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    public class ClassTreinamento
    {
        //Atributos private e Nulable
        private string? _nome;

        //Properties
        public string Email {  get;  set ; }

        public string Nome { 
            get {
                return _nome;
                } 
            set { 
                _nome = value ?? "Sem nome";
                }
        }

        public ClassTreinamento()
        {
        }

        public ClassTreinamento( string  email, string nome)
        {
            Email = email;
            Nome = nome;
        }

        //Modificador ref
        public static void CalcularSomaRef(ref int n)
        {
            n += 10;
        }

        //Modificador out
        public static void CalcularSomaOut(out int n)
        {
            n = 10;
        }

        //Modificador params
        public static void CalcularSomaParams(params int[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public override string ToString() => $"E-mail: {Email} Nome = {Nome}";
    }
}
