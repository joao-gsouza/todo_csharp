using System;
using System.Collections.Generic;
using System.Linq;

namespace todo_csharp
{
    public class Tarefas
    {
        private int idTarefa;
        
        private string nomeTarefa;

        private bool statusTarefa;

        private int idLista;

        public List<Tarefas> addTarefa(List<Tarefas> ListaTarefa){
            
            int id = 1;
            string nome;
            
            Console.Clear();
            Console.WriteLine("Digite o nome da tarefa");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o ID que a tarefa pertence");
            int idLista = Convert.ToInt32(Console.ReadLine());


            if(ListaTarefa.Any(x => x.idTarefa >= 0)){

                var idBusca = ListaTarefa.Last();
                id += idBusca.idTarefa;

            }

            ListaTarefa.Add(new Tarefas{
                idTarefa = id,
                nomeTarefa = nome,
                statusTarefa = false,
                idLista = idLista
            });

            return ListaTarefa;
        }

        public List<Tarefas> addTarefa(List<Tarefas> ListaTarefa, int idLista){
            
            int id = 1;
            string nome;
            
            Console.Clear();
            Console.WriteLine("Digite o nome da tarefa");
            nome = Console.ReadLine();


            if(ListaTarefa.Any(x => x.idTarefa >= 0)){

                var idBusca = ListaTarefa.Last();
                id += idBusca.idTarefa;

            }

            ListaTarefa.Add(new Tarefas{
                idTarefa = id,
                nomeTarefa = nome,
                statusTarefa = false,
                idLista = idLista
            });

            return ListaTarefa;
        }

        public void getTarefas(List<Tarefas> ListaTarefa, List<Listas> grupoLista){

            foreach (var item in ListaTarefa)
            {   
                Console.Write($"ID da tarefa: {item.idTarefa}\t|\t");
                Console.Write($"Nome da tarefa: {item.nomeTarefa}\t|\t");
                if(item.statusTarefa){
                    Console.WriteLine($"Status da tarefa: Concluida\t|\t");
                }else{
                    Console.WriteLine($"Status da tarefa: Não concluida\t\t");
                }

                var busca = grupoLista.Where(x => x.idLista == item.idLista).First();

                Console.WriteLine($"Nome da Lista: {busca.nomeLista}");
                Console.WriteLine($"------------------------------------------------------------------------------");
            }

        }

        public string setTarefaStatus(List<Tarefas> ListaTarefa){

            Console.WriteLine("Digite o ID da tarefa que deseja marcar como concluida");
            int id = Convert.ToInt32(Console.ReadLine());

            var resultado = ListaTarefa.Where(x => x.idTarefa == id).First();

            resultado.statusTarefa = true;

            return "Alterado com Sucesso";

        }
    }
}