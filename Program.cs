using System;
using System.Collections.Generic;
using System.Linq;

namespace todo_csharp
{
    class Program
    {   
        private static List<Tarefas> listaTarefas = new List<Tarefas>();
        public static List<Listas> grupoListas = new List<Listas>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao To Do Deal!");
            menuPrincipal();
        }

        public static void menuPrincipal(){
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1 - Tarefas");
            Console.WriteLine("2 - Listas");
            Console.WriteLine("0 - Sair");
            var valorMenu = Convert.ToInt32(Console.ReadLine());
        
            switch (valorMenu)
            {
                case 1:
                    Console.Clear();
                    menuTarefas();
                    break;
                case 2:
                    Console.Clear();
                    menuListas();
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
        public static void menuListas(){
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Adicionar Lista");
            // Console.WriteLine("2 - Remover Lista");
            Console.WriteLine("3 - Visualizar Listas");
            var menu = Convert.ToInt32(Console.ReadLine());

            var listas = new Listas();
            var tarefa = new Tarefas();

            switch (menu)
            {
                case 1:
                    Console.Clear();
                    listas.addLista(grupoListas);
                    int valor = 0;
                    while(valor != 1 || valor != 2){
                        Console.WriteLine("1 - Adicionar Tarefas a Lista criada");
                        Console.WriteLine("2 - Menu pricipal");
                        valor = Convert.ToInt32(Console.ReadLine());   
                        if(valor == 1){
                            int idLista = listas.getIdLista(grupoListas);
                            tarefa.addTarefa(listaTarefas, idLista);
                            continue;
                        }else if(valor == 2){
                            menuPrincipal();
                            continue;
                        } 
                        Console.WriteLine("Valor invalido");
                    }
                    
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    listas.getListas(grupoListas);
                    Console.WriteLine("Precione Qualquer tecla para continuar");
                    Console.ReadLine();
                    menuPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Valor invalido");
                    menuListas();
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
                    listaTarefas = tarefas.addTarefa(listaTarefas);
                    Console.Clear();
                    Console.WriteLine("Aperte ENTER para continuar:");
                    Console.ReadLine();
                    Console.Clear();
                    menuPrincipal();
                    break;
                case 2:
                    Console.Clear();
                    tarefas.getTarefas(listaTarefas, grupoListas);
                    Console.WriteLine("Precione Qualquer tecla para continuar");
                    Console.ReadLine();
                    menuPrincipal();
                    break;
                case 3:
                    Console.Clear();
                    string resultado = tarefas.setTarefaStatus(listaTarefas);
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
