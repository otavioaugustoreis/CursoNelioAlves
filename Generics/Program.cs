// See https://aka.ms/new-console-template for more information


using Generics;

List<Product> products = new List<Product>()
{
    new Product("Computer", 890.50),
    new Product("Iphone X", 910.00),
    new Product("Tablet ", 550.00)
};

CalculatorService<Product> calculator = new CalculatorService<Product>();

//Outro jeito caso o método seja estático
Console.WriteLine(CalculatorService<Product>.max(products));


