using System;
using System.Collections.Generic;

namespace exercicio2
{  
   class VideoGame
   {
       private string marca;
       private string modelo;
       private bool isUsado;

       public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
       {
           this.marca = marca;
           this.modelo = modelo;
           this.isUsado = isUsado;
       }

       public string Marca { get => marca; set => marca = value; }
       public string Modelo { get => modelo; set => modelo = value; }
       public bool IsUsado { get => isUsado; set => isUsado = value; }

       public double calculaImposto()
       {
           double imposto;

           if (this.isUsado == true)
           {
               this.preco += 0,25;
               imposto = this.preco;
           } else
           {
               this.preco += 0,45;
               imposto = this.preco;
           }
       }
   } 
}