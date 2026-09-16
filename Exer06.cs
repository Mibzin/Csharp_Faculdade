//-----------6


double a;
double b;
double c;
double resul;

Console.WriteLine("Calculo de Média Decimal");

Console.WriteLine("Digite a primeira Nota: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda Nota: ");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira Nota: ");
c = double.Parse(Console.ReadLine());

resul = ((a * 2) + (b * 3) + (c * 5) / 10);

Console.WriteLine("Média = " + resul.ToString("0.0"));
