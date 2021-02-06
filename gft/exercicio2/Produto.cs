using System;
using System.Collections.Generic;

namespace exercicio2
{
    abstract class Produto
    {
        private string nome;
        private double preco;
        private int qtd;

        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Qtd { get => qtd; set => qtd = value; }

        
         

    }
}