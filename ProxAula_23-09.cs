int idade;
idade =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("idade = {0} anos. \n", idade);

//Decisao simples, composta, encadeada, multipla escolha

//Decisao simples

if (idade >= 12)
{
    Console.WriteLine("Acesso liberado.\n");


//Decisao composta

    if (idade >= 12)
    {
        //V
        Console.WriteLine("Acesso liberado.\n");
    }
    else
        //F
        Console.WriteLine("Acesso bloqueado. \n");
}

