// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Linq;
using LINQ.ExercicioList;
using LINQ.ExercicioProposto;
using LINQ.TestandoConsultas;
public class Program
{
    delegate int Somar(int a, int b);


    static void Main(string[] args)
    {
        #region EXERCICIO_LIST
        ////Console.WriteLine("Deseja cadastrar quantos funcionários ?");

        ////int escolha = int.Parse(Console.ReadLine());
        ////int id = 0;

        ////List<Funcionario> list = new List<Funcionario>(); 

        //// for(int i = 0; i < escolha; i++)
        ////{
        ////    Console.WriteLine("Digite o nome do funcionario");
        ////    string nome = Console.ReadLine();
        ////    Console.WriteLine("Digite o salario do funcionario");
        ////    double salario = double.Parse(Console.ReadLine());

        ////    list.Add(new Funcionario(id, nome, salario));
        ////    id++;
        ////}

        ////Console.WriteLine("Digite o id do funcionário que irá receber o aumento");
        ////int idAumento = int.Parse(Console.ReadLine());

        ////Funcionario funcionario = list.FirstOrDefault(x => x.Id == idAumento);

        ////Console.WriteLine(funcionario.ToString());

        ////FuncionarioService.FazerAumento(funcionario);

        ////Console.WriteLine(funcionario.ToString()); 

        #endregion

        #region COMPARISON

        //List<Product> products = new List<Product>()
        //{
        //    new Product("Computer", 890.50),
        //    new Product("Iphone X", 910.00),
        //    new Product("Tablet ", 550.00)
        //};

        ////Delegate ->  É uma referência para uma função com TypeSafety
        ////products.Sort(Compare);
        ////ou via lambda
        ////products.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));

        //static int Compare(Product p1, Product p2)
        //{
        //    return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        //}
        //// ou via lambda
        //Comparison<Product> c1 = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());

        #endregion

        #region DELEGATE

        ////Delegate recebe a referencia de uma função

        //int a = 10;
        //int b = 10;

        //Somar somar = CalculatorService.Sum;

        //int resultado = somar(a, b);
        ////Console.WriteLine("Resultado da soma: " + resultado);

        //#endregion

        //#region PREDICATE

        //List<Product> products1 = new List<Product>()
        //{
        //    new Product("Tv", 890.50),
        //    new Product("Mouse", 910.00),
        //    new Product( "HD Case", 550.00)
        //};

        ////Predicate
        //products1.RemoveAll(p => p.Preco < 900);

        //products1.ForEach(p =>
        //{
        //    // Console.WriteLine($"Product {p.Preco} maior que 900");
        //});

        #endregion

        #region ACTION

        //List<Product> products2 = new List<Product>()
        //{
        //    new Product("Tv", 890.50),
        //    new Product("Mouse", 910.00),
        //    new Product( "HD Case", 550.00)
        //};

        ////Executando uma Action
        //products2.ForEach(AumentarPreco);
        ////Ou
        //Action<Product> p1 = AumentarPreco;
        ////products2.ForEach(AumentarPreco);

        //products2.ForEach(p =>
        //{
        //    // Console.WriteLine(p.ToString());
        //});

        //static void AumentarPreco(Product p)
        //{
        //    p.Preco += 10;
        //}
        #endregion

        #region LINQ
        #region FUNC
        ////FUNC 

        //List<Product> products3 = new List<Product>()
        //{
        //    new Product("Tv", 890.50),
        //    new Product("Mouse", 910.00),
        //    new Product( "HD Case", 550.00)
        //};

        ////Select retorna um IEnumerable
        ////Func<Product, string> func = NameUpper;
        ////A função Select pega uma coleção e transforma essa coleção em outra
        //List<string> result = products3.Select(NameUpper).ToList();

        //result.ForEach(p =>
        //{
        //    // Console.WriteLine(p.ToString());
        //});

        //static string NameUpper(Product p)
        //{
        //    return p.Nome.ToUpper();
        //}
        #endregion

        //List<int> ints = new List<int>() {
        //    1,2, 3, 4, 5, 6, 7, 8, 9, 10,
        //};

        ////Consulta Where
        ////OBS: A forma como vc coloca o Select e o Where, impacta na consulta!!!!!!
        //var results = ints.Select(P => P * 2)
        //                    .Where(x => x > 5)
        //                  .ToList();

        //results.ForEach(p =>
        //{
        //    //  Console.WriteLine(p);
        //});
        //#endregion

        //#region TESTANDO_CONSULTAS
        //Category ca1 = new Category(1, "Eletrônicos", 1);
        //Category ca2 = new Category(2, "Cozinha", 2);
        //Category ca3 = new Category(3, "Coisas de casa", 3);

        //List<OtherProducts> list = new List<OtherProducts>()
        //    {
        //        new OtherProducts(1, "Smartphone", ca1),
        //        new OtherProducts(2, "Laptop", ca1),
        //        new OtherProducts(3, "Fone de Ouvido", ca1),
        //        new OtherProducts(4, "Liquidificador", ca2),
        //        new OtherProducts(5, "Jogo de Panelas", ca2),
        //        new OtherProducts(6, "Cafeteira", ca2),
        //        new OtherProducts(7, "Sofá", ca3),
        //        new OtherProducts(8, "Tapete", ca3),
        //        new OtherProducts(9, "Luminária", ca3),
        //    };

        ////Um jeito de fazer
        //var consulta = list.Where(p =>
        //{
        //    return
        //                                p._Category.Tier == 1;
        //}).ToList();
        ////Outro jeito 
        ////var consulta = list.Where(p => p._Category.Tier == 1).ToList();

        ////  print(consulta);

        //var consulta2 = list.Where(p => p.Id == 3).SingleOrDefault();
        //// Console.WriteLine(consulta2);

        ////Retornando uma nova lista apenas com os itens que eu quero
        //var consulta3 = list.Where(p => p.Name[0] == 'S' && p._Category.Tier == 1)
        //                     //Alias
        //                     .Select(p => new { p.Name, p.Id, CategoryName = p._Category.Name }).ToList();

        ////print(consulta3);

        //var consulta4 = list.OrderBy(p => p.Name).ThenBy(p => p.Id).ToList();

        ////print(consulta4);

        //var consulta5 = list.FirstOrDefault(p => p.Id == 3);

        ////Console.WriteLine(consulta5);

        //var consulta6 = list.Where(p => p._Category.Tier == 3);

        ////Console.WriteLine(consulta6);
        ////Sum soma com base na minha consulta
        //var consulta7 = list.Where(p => p._Category.Tier == 3).Sum(P => P.Id);
        ////Console.WriteLine(consulta7);

        ////Average é a média
        //var consulta8 = list.Where(p => p._Category.Tier == 3)
        //                    .Select(p => p.Id)
        //                    //Caso esteja vazio ou valor padrão
        //                    .DefaultIfEmpty(0)
        //                    .Average();

        ////Console.WriteLine(consulta7);

        ////Usando agratate -> O agregete é usado para fazer a nossa própria operação, ou seja, passamos um predicado para ele e ele faz.
        //var consulta9 = list.Where(p => p._Category.Tier == 3)
        //                    .Select(p => p.Id)
        //                    .Aggregate(0, Sum);
        //                    //Ou
        //                    //.Aggregate(0, (x, y) => x + y);

        //static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //static void print<T>(List<T> products)
        //{
        //    foreach (T p in products)
        //    {
        //        Console.WriteLine(p);
        //    };
        //}
        #endregion

        #region EXERCICIO_PROPOSTO_LINQ

        List<OtherFuncionario> listFuncionarios = new List<OtherFuncionario>()
        {
            new OtherFuncionario("Otavio", "oaugusto265@gmail.com", 1980.81),
            new OtherFuncionario("Eduardo", "eduardo@gmail.com", 2929.00),
            new OtherFuncionario("Marcos", "marcos@gmail.com", 2000.00),
            new OtherFuncionario("Maria", "marcos@gmail.com", 2000.00)
        };

        Console.WriteLine("Digite o valor do salário que deseja fazr a busca");
        double salario = double.Parse(Console.ReadLine());

       // Console.WriteLine($"Email das pessoas que tem o salário maior que {salario}");

        var primeiraConsulta = listFuncionarios.Where(f => f.Salario >  salario)
                                                .OrderBy(f => f.Email)
                                                .Select(f => f.Email)
                                                .ToList();
        print(primeiraConsulta);

        var segundaConsulta = listFuncionarios.Where(p => p.Nome[0] == 'M').Select(s => s.Salario)
                                              .DefaultIfEmpty(0)
                                              .Sum();

        //Console.WriteLine(segundaConsulta);


        static void print<T>(List<T> list) => list.ForEach(x => Console.WriteLine(x));
        #endregion
    }
}