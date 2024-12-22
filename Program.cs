using System;
using System.Collections.Generic;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Profissao { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        Console.WriteLine("Cadastro de até 5 pessoas");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("$\nDigite o Nome da Pessoa {i}:");
            string nome = Console.ReadLine();
            int idade;
            while (true)
            {
                Console.WriteLine($"Digite a idade de {nome}");
                if
                    (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                {
                    break;
                }
                Console.WriteLine("Idade inválida. Por favor, digite um número maior que 0");
            }
            Console.WriteLine($"Digite a Profissão de {nome}:");
            string profissao = Console.ReadLine();

            pessoas.Add(new Pessoa
            {
                Nome = nome,
                Idade = idade,
                Profissao = profissao
            });
            Console.WriteLine("Deseja Cadastrar outra Pessoa?(s/n)");
            string continuar = Console.ReadLine()?.ToLower();
            if (continuar == "n")
            {
                break;
            }
        }
        Console.WriteLine("\nCadastro concluido! Pessoas cadastradas:");

        for (int i = 0; i < pessoas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Nome: {pessoas[i].Nome}, Idade:{pessoas[i].Idade}, Profissao:{pessoas[i].Profissao}");
        }

    }
}
