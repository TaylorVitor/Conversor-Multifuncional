using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Universal
{
    class Program
    {
        enum Menu {temperatura = 1, velocidade, altura, sair}
        static void Main(string[] args)
        {
            bool escolherSair = false;
            while(escolherSair == false)
            {
                Console.WriteLine("Bem vindo ao conversor universal");
                Console.WriteLine("1-Temperatura \n2-Velocidade \n3-Altura \n4-Sair");
                int intOpc = int.Parse(Console.ReadLine());
                Menu selectMenu = (Menu)intOpc;

                Console.WriteLine(" ");

                switch (selectMenu)
                {

                    case Menu.temperatura:
                        temp();
                        break;

                    case Menu.velocidade:
                        velo();
                        break;

                    case Menu.altura:
                        altura();
                        break;

                    case Menu.sair:
                        escolherSair = true;
                        break;

                }
                Console.Clear();
            }

            void temp()
            {

                Console.WriteLine("Converçor de Celsius para Fahrenheit");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a temperatura em Celsius");
                int intCel = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                float convert = intCel * 1.8f + 32;

                Console.WriteLine(convert + " Fahrenheit");

                Console.WriteLine("Aperte ENTER para sair");
                Console.ReadLine();
            }

            void velo()
            {

                Console.WriteLine("Converçor de Km/h para m/s");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a Velocidade em km/h");
                int intVel = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                float convert = intVel / 3.6f;

                Console.WriteLine(convert + " m/s");

                Console.WriteLine("Aperte ENTER para sair");
                Console.ReadLine();
            }

            void altura()
            {

                Console.WriteLine("Converçor de metros para pés");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a altura");
                float intAlt = float.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                float convert = intAlt * 3.281f;

                Console.WriteLine(convert + " Pés");

                Console.WriteLine("Aperte ENTER para sair");
                Console.ReadLine();
            }
        }
    }
}
