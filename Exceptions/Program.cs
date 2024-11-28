// See https://aka.ms/new-console-template for more information
using Exceptions;

Console.WriteLine("Hello, World!");


try
{
    Pessoa pessoa = new Pessoa()
    {
        Idade = 0
    };
}
catch (PessoaException e)
{
    //Exibindo a mensagem da exceção
    Console.WriteLine(e.Message);
}

