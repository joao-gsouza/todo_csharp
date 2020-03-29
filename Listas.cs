using System;
using System.Collections.Generic;
using System.Linq;

namespace todo_csharp
{
    public class Listas
    {
        public int idLista;

        public string nomeLista;


        public int getIdLista(List<Listas> Lista){


            var idBusca = Lista.Last();

            return idBusca.idLista;
        }
        public List<Listas> addLista(List<Listas> Lista){
            
            Console.Clear();
            Console.WriteLine("Digite o nome da lista");
            var nome = Console.ReadLine();
            int id = 1;

            if(Lista.Any(x => x.idLista >= 0)){

                var idBusca = Lista.Last();
                id += idBusca.idLista;

            }

            Lista.Add(new Listas{
                idLista = id,
                nomeLista = nome
            });

            return Lista;
        }

        public void getListas(List<Listas> Lista){

            foreach(var item in Lista){
                Console.Write($"ID da lista: {item.idLista}\t|\t");
                Console.Write($"Nome da lista: {item.nomeLista}\t|\t");
                Console.WriteLine($"------------------------------------------------------------------------------");

            }

        }

    }
}