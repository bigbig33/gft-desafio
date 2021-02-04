using System;

namespace StringLibrary
{
    public class Produto
    {
        private string nome;
        private double preco;
        private int qtd;

        public string Nome { get => nome; set => nome = value; } //Propriedade da classe
        public double Preco { get => preco; set => preco = value; } //Propriedade da classe

        public int Qtd { get => qtd; set => qtd = value; }
    }

    public class Livro
    {
        private string autor;
        private string tema;
        private int qtdPag;

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; } 
        public int Qtd { get => qtd; set => qtd = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Tema { get => tema; set => tema = value; }
        public int QtdPag { get => qtdPag; set => qtdPag = value; }

    }

    public class Livro
    {
        private string marca;
        private string modelo;

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; } 
        public int Qtd { get => qtd; set => qtd = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }

    }

    public interface IcalculadoraImposto{
        
    }
    {
        
    }
}
