using DesafioPOO.Models;

/*
int num = 0;
while (num != 1 ||  num != 2) 
{
    Console.WriteLine("Olá usuário, insira o número corresponde a marca que o você gostaria de editar:");
    Console.WriteLine("1 - Nokia");
    Console.WriteLine("2 - Iphone");
    num = Convert.ToInt16(Console.ReadLine());
}
if (num == 1 )
{
    Console.WriteLine("Insira o ");

    Nokia nokia = new Nokia();
}

*/

Nokia nokia = new Nokia("991810891", "G11 Plus", "7218312", 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Ifood");



Iphone iphone = new Iphone("991810890", "13 pro", "8436578", 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Netflix");





