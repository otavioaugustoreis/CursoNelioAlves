// See https://aka.ms/new-console-template for more information

#region Instancias_date
using TrabalhandoComDatas;

DateTime dt2 = new DateTime(2024, 06, 24);//Passando ano mês e dia
DateTime dt3 = new DateTime(2024, 06, 24, 13, 40, 00);//Passando ano, mês, dia, hora, minuto e segundo

DateTime dt4 = DateTime.Now; //Pega a data atual
DateTime dt5 = DateTime.Today; //Pega a data atual mas com o horário zerado!!!

//Console.WriteLine(dt2);


//Convertendo String para DateTime
  DateTime dt6 = DateTime.Parse("2008-06-18");
// ou
  DateTime dt7 = DateTime.Parse("2008/06/18");

#endregion

#region INSTANCIAS_TIMESPAM


TimeSpan s1 = new TimeSpan(0,1,2); //TimeSpan armazena a Hora, minuto e segundos

//Console.WriteLine(s1);

#endregion

#region CONSULTAS_DATAS 

DateTime data = new DateTime(2024, 11, 26, 22, 11, 00);

//Consultando a diferença entre datas
//obs: A função Subtract é uma função apenas da classe TimeSpan 
//TimeSpan duracao =  DateTime.Now.Subtract(data);
//Console.WriteLine(duracao.Hours);

DateTime data2 = DateTime.Now;

Console.WriteLine(data2.CompararDatasHoras(data));
Console.WriteLine(data2.CompararDatasDias(data));


#endregion