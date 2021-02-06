using System;
using System.Collections.Generic;

namespace exercicio2
{
    class Livro : Produto
    {
        private string autor;
        private string tema;
        private int qtdPag;

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

        public string Autor { get => autor; set => autor = value; }
        public string Tema { get => tema; set => tema = value; }
        public int QtdPag { get => qtdPag; set => qtdPag = value }

        public double Calculo()
        {
            double imposto;

            if (this.Tema == "educativo")
            {
                return 0;
            } else
            {
                this.preco += 0,10;
                imposto = this.preco;
            }
        }
    }
}