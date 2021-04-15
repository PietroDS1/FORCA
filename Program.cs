using System;

namespace JogodaForca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = new string[10];
            valores[0] = "brasil";
            valores[1] = "alemanha";
            valores[2] = "uk";
            valores[3] = "eua";
            valores[4] = "holanda";
            valores[5] = "espanha";
            valores[6] = "portugal";
            valores[7] = "australia";
            valores[8] = "dinamarca";
            valores[9] = "russia";

            Random rand = new Random();
            int indice = rand.Next(0, 10);
            string valorGeradoIA = valores[indice];
            char[] palavraAux = new char[valorGeradoIA.Length];
            char letra;
            int tentativas = 0;

            for (int i = 0; i < valorGeradoIA.Length; i++)
            {
                palavraAux[i] = '*';
            }
            while (tentativas < 6)
            {
                Console.WriteLine("Estou pensando em um pais adivinhe...");
                Console.WriteLine(palavraAux);
                letra = Console.ReadLine()[0];
                for (int i = 0; i < valorGeradoIA.Length; i++)
                {
                    if (letra == valorGeradoIA[i] && letra != palavraAux[i])
                    {
                        palavraAux[i] = letra;
                        tentativas--;
                    }
                }

                tentativas++;
                if (checkWin())
                {
                    tentativas = 6;
                    Console.WriteLine(palavraAux);
                }
            }
            
            for (int i = 0; i < palavraAux.Length; i++)
            {
                if (palavraAux[i] == '*')
                {
                    Console.WriteLine("Vc perdeu! A resposta era: " + valorGeradoIA);
                    return;
                }                            
            }
            Console.WriteLine("Boa vc ganhou!");
            bool checkWin()
                
            { 
                
                for (int i = 0; i < palavraAux.Length; i++)
                {
                    if (palavraAux[i] == '*')
                    {
                        return false;
                    }

                }
                return true;
            }
        }

     
       
       
       
    }
}
