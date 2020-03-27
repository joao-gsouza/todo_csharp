using System;
using System.Collections.Generic;
using System.Linq;

namespace todo_csharp
{
    public class Tarefas
    {
        public int idTarefa;
        
        public string nomeTarefa;

        public bool statusTarefa;

        public List<Tarefas> addTarefa(List<Tarefas> Lista){
            
            Console.Clear();
            Console.WriteLine("Digite o ID da tarefa:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome da tarefa");
            string nome = Console.ReadLine();

            Lista.Add(new Tarefas{
                idTarefa = id,
                nomeTarefa = nome,
                statusTarefa = false
            });

            return Lista;
        }

        public void getTarefas(List<Tarefas> Lista){
            
            // var resultado = Lista.Where(x => x.idTarefa != 0).ToList();

            foreach (var item in Lista)
            {   
                Console.Write($"ID da tarefa: {item.idTarefa}\t|\t");
                Console.Write($"Nome da tarefa: {item.nomeTarefa}\t|\t");
                if(item.statusTarefa){
                    Console.WriteLine($"Status da tarefa: Concluida\t|\t");
                }else{
                    Console.WriteLine($"Status da tarefa: Não concluida\t\t");
                }
                Console.WriteLine($"------------------------------------------------------------------------------");
            }

        }

        public string setListaStatus(List<Tarefas> Lista){
            Console.WriteLine("Digite o ID da tarefa que deseja marcar como concluida");
            int id = Convert.ToInt32(Console.ReadLine());

            var resultado = Lista.Where(x => x.idTarefa == id).First();

            resultado.statusTarefa = true;

            return "Alterado com Sucesso";

        }
    }
}