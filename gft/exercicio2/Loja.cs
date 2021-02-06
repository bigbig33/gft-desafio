using System;
using System.Collections.Generic;

namespace exercicio2
{
    class Loja
    {
        private string nome;
        private string cnpj;
        private List<Livro> livros = new List<Livro>();
        private List<VideoGame> videoGame = new List<VideoGame>();

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGame)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGame = videoGame;
        }

        public string Nome{ get => nome; set => nome = value; }
        public string Cnpj{ get => cnpj; set => cnpj = value; }

        public listaLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros no seu estoque")
            } else
            {
                foreach (var livros in Livros)
                {
                    Console.Write("Título: " + Nome);
                    Console.Write(" Preço: " + Preço);
                    Console.WriteLine("Quantidade: " + Qtd);

                }
            }
        }

        public listaVideoGames()
        {
            if (videoGame.Count == 0)
            {
                Console.WriteLine("A loja não tem vídeo games no seu estoque")
            } else
            {
                foreach (var videoGame in VideoGame)
                {
                    Console.Write("Título: " + Nome);
                    Console.Write(" Preço: " + Preço);
                    Console.WriteLine("Quantidade: " + Qtd);

                }
            }
        }

        public void calculaPatrimonio()
        {
            double patrimonio = 0;

            videoGames.ForEach(game => patrimonio = game.getPreco() * game.getQtd());
            livros.ForEach(livro => patrimonio = livro.getPreco() * livro.getQtd());
            Console.WriteLine($"O patrimonio total da Loja {this.nome} é igual a R${patrimonio.ToString("N2")}");
        }

    }
}