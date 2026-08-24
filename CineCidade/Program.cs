Console.Write("Nome do cliente: ");
string nome = Console.ReadLine();

Console.Write("Quantidade de ingressos: ");
int quantidade = int.Parse(Console.ReadLine());

Console.Write("Cupom de desconto: ");
string cupom = Console.ReadLine();

Console.Write("Idade do cliente: ");
int idade = int.Parse(Console.ReadLine());

decimal custoBruto = 5.00m + (25.00m * quantidade);

Console.WriteLine("Valor bruto: " + custoBruto);
Console.ReadLine();