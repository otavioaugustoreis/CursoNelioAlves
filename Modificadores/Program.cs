using Modificadores;

#region INSTANCIAS
ClassTreinamento c1 = new ClassTreinamento()
{
    Nome = "Otavio"
};

ClassTreinamento c2 = new ClassTreinamento("felipe@gmail.com", "Felipe");

//Console.WriteLine(c1);
//Console.WriteLine(c2);
#endregion

#region OUT
//Out não te obriga a inicializar a variável
//int x;
//ClassTreinamento.CalcularSomaOut(out x);
//Console.WriteLine(x);

#endregion

#region REF
//o ref te obriga a inicializar uma variável
//int y = 10;
//ClassTreinamento.CalcularSomaRef(ref y);
//Console.WriteLine(y);
#endregion

#region PARAMS
//Params 
//ClassTreinamento.CalcularSomaParams(1, 2, 3, 4);
#endregion


