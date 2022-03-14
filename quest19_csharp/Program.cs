using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest19_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma quantidade de números");
            int N = Convert.ToInt32(Console.ReadLine());
            double maior_idade = 0;
            double menor_idade = 0;
            double soma_idade = 0;
            double numero_devezes = 0;
            int quantidade = N;

            while (N==0)
            {
                Console.WriteLine("Digite uma quantidade de números não nula");
                N = Convert.ToInt32(Console.ReadLine());

            }
            
            while (N > 0)
            {
                
                Console.WriteLine("Digite uma idade");
                int idade = Convert.ToInt32(Console.ReadLine());
                if (N == quantidade)
                {
                    menor_idade = idade;
                }
               

                soma_idade += idade;
               
                if (idade > maior_idade)
                {
                    maior_idade = idade;
                }
                else if (idade < menor_idade)
                {
                    menor_idade = idade;
                   
                }
               
                N--;
                numero_devezes++;
            }
            double media = soma_idade / numero_devezes;
            Console.WriteLine("A maior idade foi :" + maior_idade);
            Console.WriteLine("A menor idade foir :" + menor_idade);
            Console.WriteLine("A soma das idades foi:"+ soma_idade);
            Console.WriteLine("A média de todas as idades foi:"+media);
            Console.ReadLine();
            }
        }
     
        
    }



