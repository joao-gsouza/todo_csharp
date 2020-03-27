using System;
using System.Collections.Generic;

namespace todo_csharp
{
    class Program
    {   
        private static List<Tarefas> listaTarefas = new List<Tarefas>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao To Do Deal!");
            menuPrincipal();
        }

        public static void menuPrincipal(){
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1 - Tarefas");
            Console.WriteLine("0 - Sair");
            var valorMenu = Convert.ToInt32(Console.ReadLine());
        
            switch (valorMenu)
            {
                case 1:
                    Console.Clear();
                    menuTarefas();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Valor invalido");
                    menuPrincipal();
                    break;
            }

        }  
        
        public static void menuTarefas(){
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Vizualizar tarefas");
            Console.WriteLine("3 - Marcar tarefa como concluida");
            Console.WriteLine("0 - Voltar ao menu principal");
            var valorMenu = Convert.ToInt32(Console.ReadLine());
            
            var tarefas = new Tarefas();

            switch (valorMenu)
            {
                case 1:
                    // var resultado = tarefas.addTarefa(listaTarefas);
                    listaTarefas = tarefas.addTarefa(listaTarefas);
                    Console.Clear();
                    // Console.WriteLine(resultado);
                    Console.WriteLine("Aperte ENTER para continuar:");
                    Console.ReadLine();
                    Console.Clear();
                    menuPrincipal();
                    break;
                case 2:
                    Console.Clear();
                    tarefas.getTarefas(listaTarefas);
                    Console.WriteLine("Precione Qualquer tecla para continuar");
                    Console.ReadLine();
                    menuPrincipal();
                    break;
                case 3:
                    Console.Clear();
                    string resultado = tarefas.setListaStatus(listaTarefas);
                    Console.Clear();
                    Console.WriteLine(resultado);
                    Console.WriteLine("");
                    Console.WriteLine("Precione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    menuPrincipal();
                    break;
                case 0:
                    Console.Clear();
                    menuPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Valor invalido");
                    menuTarefas();
                    break;  
            }
        }
    }
}
