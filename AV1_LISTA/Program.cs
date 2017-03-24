using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_LISTA
{
    /// <summary>
    /// Método para adicionar os objetos na lista
    /// </summary>
    public class Items
    {
        public int qtdeItems;
        public int posicao;
        public string item;
        public Items next = null;

        /// <summary>
        /// Construtor para inserir os valores
        /// </summary>
        /// <param name="posicao">Posição do objeto</param>
        /// <param name="qtdeItems">Quantidade do objeto</param>
        /// <param name="item">Nome do objeto</param>
        public Items(int posicao, int qtdeItems, string item)
        {
            this.item = item;
            this.posicao = posicao;
            this.qtdeItems = qtdeItems;
        }

        /// <summary>
        /// Metodo para remover item da lista encadeada
        /// </summary>
        public void RemoverItems()
        {
            next = next.next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        /// <summary>
        /// Desenha um menu 
        /// </summary>
        public static void menu()
        {
            Console.BufferWidth = Console.WindowWidth = 81;
            Console.BufferHeight = Console.WindowHeight = 25;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("╒══════════════════════════════════════════════════════════════════════════════╕");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                     __   __  _______  __    _  __   __                       ║");
            Console.WriteLine("║                    |  |_|  ||       ||  |  | ||  | |  |                      ║");
            Console.WriteLine("║                    |       ||    ___||   |_| ||  | |  |                      ║");
            Console.WriteLine("║                    |       ||   |___ |       ||  |_|  |                      ║");
            Console.WriteLine("║                    |       ||    ___||  _    ||       |                      ║");
            Console.WriteLine("║                    | ||_|| ||   |___ | | |   ||       |                      ║");
            Console.WriteLine("║                    |_|   |_||_______||_|  |__||_______|                      ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                   INVENTARIO                                 ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  B -> Buscar                                                                 ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  X -> About program                                                          ║");
            Console.WriteLine("║  Q -> Quit                                                                   ║");
            Console.WriteLine("║                                                                              ║");
            Console.Write("╘══════════════════════════════════════════════════════════════════════════════╛");
            Console.SetCursorPosition(77, 23);
            ConsoleKey currentOption = Console.ReadKey().Key;
            Console.Clear();

            switch (currentOption)
            {
                case ConsoleKey.B:
                    construirLista();
                    Console.ReadKey();
                break;
                case ConsoleKey.X:
                    sobre();
                break;
                case ConsoleKey.Q:
                case ConsoleKey.Escape:
                    Environment.Exit(1);
                break;
                default:
                    menu();
                break;
            }
        }

        /// <summary>
        /// Desenha a tela de sobre
        /// </summary>
        public static void sobre()
        {
            Console.Clear();
            Console.WriteLine("╒══════════════════════════════════════════════════════════════════════════════╕");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  M -> Main Menu                                                              ║");
            Console.WriteLine("║  Q -> Quit                                                                   ║");
            Console.WriteLine("║                           CRIADO POR LUCAS SOARES E LUIS FELIPE              ║");
            Console.Write("╘══════════════════════════════════════════════════════════════════════════════╛");
            ConsoleKey currentOption = Console.ReadKey().Key;
            Console.Clear();
            switch (currentOption)
            {
                case ConsoleKey.Q:
                case ConsoleKey.Escape:
                    Environment.Exit(1);
                    break;
                case ConsoleKey.M:
                    menu();
                    break;
            }
        }

        /// <summary>
        /// Método para construir a lista e fazer a pesquisas
        /// </summary>
        public static void construirLista()
        {
            Items item1 = new Items(1, 1, "Faquinha");
            Items item2 = new Items(2, 2, "Bomba");
            Items item3 = new Items(3, 3, "Caneta");
            Items item4 = new Items(4, 4, "Computador");
            Items item5 = new Items(5, 5, "Android");
            Items item6 = new Items(6, 6, "Robô");
            Items item7 = new Items(7, 7, "Arduino");
            Items item8 = new Items(8, 8, "Raspberry");
            Items item9 = new Items(9, 9, "Hello");
            Items item10 = new Items(10, 10, "CS");

            item1.next = item2;
            item2.next = item3;
            item3.next = item4;
            item4.next = item5;
            item5.next = item6;
            item6.next = item7;
            item7.next = item8;
            item8.next = item9;
            item9.next = item10;

            Console.Clear();
            Console.WriteLine("Digite o nome do item para fazer sua busca \n");
            
            string resposta = Console.ReadLine();
            Items itemIndice = item1;
            Items itemAnterior = itemIndice;
            while (itemIndice != null && itemIndice.qtdeItems > 0)
            {
                if (itemIndice.item == resposta)
                {
                    itemIndice.qtdeItems--;
                    Console.WriteLine("Achou {0} na posicao {1}, com {2} disponivel", itemIndice.item, itemIndice.posicao, itemIndice.qtdeItems);
                    break;
                    if(itemIndice.qtdeItems <= 0)
                    {
                        Console.WriteLine("Não há nenhum {0} em seu inventario", itemIndice.item);
                        itemAnterior.RemoverItems();
                    }
                    return;
                }
                itemAnterior = itemIndice;
                itemIndice = itemIndice.next;
                Console.WriteLine("O item não está disponivel");
                return;
            }
        }
    }
}
