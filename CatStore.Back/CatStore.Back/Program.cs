Console.WriteLine("Bem-Vindo!");

Console.WriteLine("Digite o nome do seu gato: ");
string nomeGato = Console.ReadLine();

Console.WriteLine("Digite a idade do seu gato: ");
string idadeTexto = Console.ReadLine();
int idade = Convert.ToInt32(idadeTexto);

Console.WriteLine($"Seu gato {nomeGato} com idade {idade} foi cadastrado com sucesso!");

if (idade <= 10) 
{
    Console.WriteLine("Seu gato não precisa de um plano de saúde!");    
} 
else if (idade > 10 && idade <= 15)
{
    Console.WriteLine("Faça um plano de saúde preventivo para o seu gato!");
} 
else
{
    Console.WriteLine("Seu gato precisa de um plano de saúde!");
}
