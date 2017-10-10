using System;

namespace semana2_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //intt placa;
            
            Console.WriteLine("Verifica placa rodizio");

            Console.WriteLine("Digite sua placa: ");

            string placa = Console.ReadLine();
            
            switch(placa){
                case "1": case "2":
                    Console.WriteLine("Segunda-Feira");
                    break;                
                case "3": case "4":
                    Console.WriteLine("Terça-Feira");
                    break;
                case "5": case "6":
                    Console.WriteLine("Quarta-Feira");
                    break;
                case "7": case "8":
                    Console.WriteLine("Quinta-Feira");
                    break;
                case "9": case "0":                    
                    break; 
                   default:
                     Console.WriteLine("Deu ruim");
                   break;
            }
        }
    }
}
