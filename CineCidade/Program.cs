Console.Write("Nome do cliente: ");
string nome = Console.ReadLine();

Console.Write("Quantidade de ingressos: ");
int quantidade = int.Parse(Console.ReadLine());

Console.Write("Cupom de desconto: ");
string cupom = Console.ReadLine();

Console.Write("Idade do cliente: ");
int idade = int.Parse(Console.ReadLine());

decimal custoBruto = 5.00m + (25.00m * quantidade);
decimal desconto = 0.00m;

if (cupom.ToUpper() == "CINEMA10")
{
    desconto = custoBruto * 0.10m;
}

decimal valorFinal = custoBruto - desconto;

Console.WriteLine("Valor bruto: " + custoBruto); 
Console.WriteLine("Valor final: " + valorFinal);
Console.ReadLine();
