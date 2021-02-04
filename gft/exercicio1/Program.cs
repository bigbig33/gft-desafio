using System;

namespace gft
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0, c = 0;

            Console.Write("Digite o valor de A: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = float.Parse(Console.ReadLine());

            try{
                // conta + (X1)

                double x1MultAC = 4*(a*c);
                double x1Potencia = Math.Pow(b,2);
                double x1SubtraiPotencia = x1Potencia - x1MultAC;
                double x1ContaRaiz = Math.Sqrt(x1SubtraiPotencia);
                double x1Soma = -b + x1ContaRaiz;
                double x1MultA = a * 2;
                double x1 = x1Soma  / x1MultA;

                //conta - (X2)

                double x2MultAC = 4*(a*c);
                double x2Potencia = Math.Pow(b,2);
                double x2SubtraiPotencia = x2Potencia - x2MultAC;
                double x2ContaRaiz = Math.Sqrt(x2SubtraiPotencia);
                double x2Soma = -b - x2ContaRaiz;
                double x2MultA = a * 2;
                double x2 = x2Soma  / x2MultA;

                if ((x2MultA  == 0) || (x1MultA == 0) || (x1ContaRaiz < 0) || (x2ContaRaiz < 0)){
                    Console.Write("Impossível calcular");
                } else {
                    Console.WriteLine(x1.ToString("0.00000"));
                    Console.WriteLine(x2.ToString("0.00000"));
                }
                
            } catch {
                Console.Write("Impossível calcular");
            }
        }
    }
}
