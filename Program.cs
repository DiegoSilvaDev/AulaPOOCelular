using System;
using System.Threading;


namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular galaxy = new Celular(); 
            galaxy.nome = "Galaxy S800";
            galaxy.modelo = "Galaxy";
            galaxy.marca = "Samsumg";
            galaxy.cor = "Preta";
            galaxy.status = false;
            galaxy.tam = 7;

            Console.WriteLine("O seu celular tem as seguintes características : modelo "+galaxy.modelo+", da marca "+galaxy.marca+", cor "+galaxy.cor+" e tamanho de "+galaxy.tam+"cm");
            Console.WriteLine();
            Console.WriteLine("Para o celular ligar digite: 'On'");
            galaxy.status = galaxy.Iniciar(Console.ReadLine());
            Thread.Sleep(2000);
            Console.WriteLine("O celular está iniciando");
            Console.WriteLine("Loading...");
            Thread.Sleep(700);
            Console.WriteLine("Loading..");
            Thread.Sleep(700);
            Console.WriteLine("Loading...");
            Thread.Sleep(700);
            Console.WriteLine("Loading.");
            Console.Clear();
            Console.WriteLine("O celular está ligado");
            Console.WriteLine("O que deseja?");
            Console.WriteLine();
            inicio:
            Console.WriteLine("Se deseja fazer uma ligação digite [ligar], caso queira efetuar outra tarefa espere alguns segundos...");
            Console.WriteLine();
            Thread.Sleep(4000);
            Console.WriteLine("Ok, você prefere mensagem né?Então digite [msg] e a envie");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Agora eu acertei você deseja desligar o sistema correto?Então digite [off]");

            
            switch (Console.ReadLine())
           {
               case "msg":
                    Console.WriteLine("Digite uma mensagem");
                    galaxy.mensagem(Console.ReadLine());
                    Console.WriteLine("Mensagem enviada");
                    Thread.Sleep(200);
                    Console.Clear();
                    goto inicio;
                    break;
                case "ligar":
                    Console.WriteLine("Digite o numero para ligaçao");
                    galaxy.ligar(Console.ReadLine());
                    Console.WriteLine("Ligação efetuada");
                    Thread.Sleep(200);
                    Console.Clear();
                    goto inicio;
                    break;
                case "off":
                Console.WriteLine();
                Console.WriteLine("O celular será desligado");
                Console.WriteLine();
                Thread.Sleep(400);
                Console.WriteLine("Desligando...");
                Thread.Sleep(400);
                Console.WriteLine("Desligando..");
                Thread.Sleep(400);
                Console.WriteLine("Desligando...");
                Thread.Sleep(400);
                Console.WriteLine("Desligando.");
                Thread.Sleep(400);
                Console.WriteLine("Desligando...");

                    galaxy.desligar();
                    
                    break;
               default:
                    Console.WriteLine("Comando invalido");
                    Console.Clear();
                    goto inicio;
                    break;    
           }
            
        }
    }
}