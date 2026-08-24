using System.Globalization;
CultureInfo br = new CultureInfo("pt-BR");

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

bool sessaoNoturna = quantidade > 1 && idade >= 18;

Console.WriteLine("Cliente: " + nome.ToUpper());
Console.WriteLine("Valor bruto: " + custoBruto.ToString("C", br));
Console.WriteLine("Valor final: " + valorFinal.ToString("C", br));
Console.WriteLine("Elegivel para Sessao Noturna: " + sessaoNoturna);

Console.ReadLine();

