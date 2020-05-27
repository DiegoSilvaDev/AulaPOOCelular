using System;
using System.Threading;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular Galaxy = new Celular(); 
            Galaxy.nome = "Galaxy S800";
            Galaxy.modelo = "Galaxy";
            Galaxy.marca = "Samsumg";
            Galaxy.cor = "Preta";
            Galaxy.status = false;
            Galaxy.tam = 7;

            Console.WriteLine("O seu celular tem as seguintes características : modelo "+Galaxy.modelo+", da marca "+Galaxy.marca+", cor "+Galaxy.cor+" e tamanho de "+Galaxy.tam+"cm");
            Console.WriteLine();
            Console.WriteLine("Para o celular ligar digite: 'On'");
            Galaxy.status = Galaxy.Iniciar(Console.ReadLine());
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
            inicio:
            Console.WriteLine("O que deseja?");
            Console.WriteLine();
            Console.WriteLine("Se deseja fazer uma ligação digite [ligar], caso queira efetuar outra tarefa espere alguns segundos...");
            Console.WriteLine();
            Thread.Sleep(6000);
            Console.WriteLine("Ok, você prefere mensagem né?Então digite [msg] e a envie,beleza desisto de você espere mais alguns segundos... ");
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.WriteLine("Agora eu acertei você deseja desligar o sistema correto?Então digite [off]");

            
            switch (Console.ReadLine())
           {
               case "msg":
                    Console.WriteLine("Digite uma mensagem");
                    Galaxy.mensagem(Console.ReadLine());
                    goto inicio;
                    
                    break;
                case "ligar":
                    Console.WriteLine("Digite o numero para ligaçao");
                    Galaxy.ligar(Console.ReadLine());
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
                
                    Galaxy.desligar();
                    
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