using System;
using System.Collections.Generic;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro(nome: "Harry Potter", preco: 40.0, qtd: 50, autor: "J. K. Rowling", tema: "fantasia", qtdPag: 300);
            Livro l2 = new Livro(nome: "Senhor dos Anéis", preco: 60.0, qtd: 30, autor: "J. R. R. Tolkien", tema: "fantasia", qtdPag: 500);
            Livro l3 = new Livro(nome: "Java POO", preco: 20.0, qtd: 50, autor: "GFT", tema: "educativo", qtdPag: 500);

            VideoGame ps4 = new VideoGame(nome: "PS4", preco: 1800.0, qtd: 100, marca: "Sony", modelo: "Slim", isUsado: false);
            VideoGame ps4Usado = new VideoGame(nome: "PS4", preco: 1000.0, qtd: 7, marca: "Sony", modelo: "Slim", isUsado: true);
            VideoGame xbox = new VideoGame(nome: "XBOX", preco: 1500.0, qtd: 500, marca: "Microsoft", modelo: "One", isUsado: false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja(nome: "Americanas", cnpj: "123456", livros, games);


            Console.WriteLine("---------- Testando calculo de impostos ----------");
            Console.WriteLine(l2.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(l3.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ps4Usado.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ps4.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("---------- Fim do teste do calculo de impostos ----------");

            Console.WriteLine();

            Console.WriteLine("---------- Testando métodos listaLivros e listaVideoGames ----------");
            Console.WriteLine("As lojas americanas possuem estes livros para venda");
            americanas.ListaLivros();
            Console.WriteLine("As lojas americanas possuem estes video games para venda");
            americanas.ListaVideoGames();
            Console.WriteLine("---------- Fim dos testes dos métodos listaLivros e listaVideoGames ----------");

            Console.WriteLine();

            Console.WriteLine("---------- Testando método calculaPatrimonio ----------");
            Console.WriteLine("O patrimônio da loja " + americanas.Nome + " é igual a R$ " + americanas.CalculaPatrimonio().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("---------- Fim do teste ----------");
        }
    }
}
