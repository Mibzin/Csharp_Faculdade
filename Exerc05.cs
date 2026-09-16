//-----------5


double a;
double b;
double result;

Console.WriteLine("Calculo de Média");

Console.WriteLine("Digite a primeira Nota: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda Nota: ");
b = double.Parse(Console.ReadLine());

result = a + b / 2;

Console.WriteLine("Média = " + result.ToString("0.00000"));
