using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace primeiroProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teste = true;
            int op;
            string msg;
            Celular c = new Celular();
            c.modelo = "Samsung Galaxy S10";
            c.cor = "Preto";
            c.tamanho = 10.5f;

            Console.WriteLine("--------- Celular");
            Console.WriteLine("Modelo: "+c.modelo);
            Console.WriteLine("Cor: "+c.cor);
            Console.WriteLine("Tamanho: "+c.tamanho);
            Console.WriteLine("----------------");
            Thread.Sleep(1000);
            Console.Clear();
            while(teste == true){
                Console.WriteLine("--------- MENU");
                Console.WriteLine("0 - Ligar o Celular");
                Console.WriteLine("1 - Desligar o Celular");
                Console.WriteLine("2 - Enviar mensagem");
                Console.WriteLine("3 - Realizar ligação");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("---------------");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 0: 
                        msg = c.ligar();
                        Console.WriteLine(msg);
                        break;
                    case 1: 
                        msg = c.desligar();
                        Console.WriteLine(msg);
                        break;
                    case 2: 
                        msg = c.enviarMensagem();
                        Console.WriteLine(msg);
                        break;
                    case 3: 
                        msg = c.fazerLigacao();
                        Console.WriteLine(msg); 
                        break;
                    case 4: teste = false; break;
                    default: Console.WriteLine("Opção inválida"); break;
            }
        }
        Console.WriteLine("Saindo...");
        Thread.Sleep(2000);
        Console.Clear();
        System.Environment.Exit(0);
    }
}
}
