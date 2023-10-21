Console.WriteLine("+-----Múltiplos----+\n");
Console.WriteLine("+-Digite um numero-+");

int nu1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Analisar se é múltiplo de:");

int nu2 = Convert.ToInt32(Console.ReadLine());

if (nu1 % nu2 == 0)
{
    Console.WriteLine($"{nu1} é multiplo de {nu2}");
}
else
{
     Console.WriteLine($"{nu1} não é multiplo de {nu2}");
}
