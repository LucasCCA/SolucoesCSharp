using ExemploFundamentos.Common.models;

Pessoa pessoa1 = new Pessoa
{
    Nome = "Lucas",
    Idade = 21
};
pessoa1.Apresentar();

int[] arrayInteiros = [1, 2];
int[] arrayCopiado = new int[2];
Array.Resize(ref arrayCopiado, arrayCopiado.Length * 2);
Array.Copy(arrayInteiros, arrayCopiado, arrayInteiros.Length);
Console.WriteLine("Length: " + arrayCopiado.Length);

foreach (int item in arrayCopiado)
{
    Console.WriteLine(item);
}