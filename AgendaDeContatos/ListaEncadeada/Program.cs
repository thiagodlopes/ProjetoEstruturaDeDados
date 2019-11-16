using System;
using System.Globalization;
using System.Collections.Generic;
using static Agenda.Metodos;

namespace Agenda {
    public class Program {
        public static void Main(string[] args) {

            Metodos metodo = new Metodos();


            Menu();

            void Menu() {

                bool mostrarMenu = true;

                while (mostrarMenu) {
                    mostrarMenu = MenuPrincipal();
                }

                bool MenuPrincipal() {

                    Console.Clear();
                    Console.WriteLine("1 - Criar contato");
                    Console.WriteLine("2 - Alterar dados de contato");
                    Console.WriteLine("3 - Excluir contato");
                    Console.WriteLine("4 - Limpar lista");
                    Console.WriteLine("5 - Gerar relatório de contatos");
                    Console.WriteLine("6 - Sair do programa");
                    Console.Write("\r\nSelecione uma opção: ");

                    switch (Console.ReadLine()) {

                        case "1": //Já tá OK
                            metodo.InserirContato();
                            Console.Clear();
                            return true;
                        case "2": //Já tá OK
                            metodo.AlterarContato();
                            Console.ReadLine();
                            return true;
                        case "3": //Já tá OK
                            metodo.ExcluirContato();
                            return true;
                        case "4": //Já tá OK
                            metodo.LimparAgenda();
                            return true;
                        case "5": //Já tá OK
                            Console.Clear();
                            Console.WriteLine(metodo.ContarContatos());
                            metodo.ListarContatos();
                            return true;
                        case "6": //Já tá OK
                            return false;
                        default:
                            return true;

                    }

                }

            }

        }
    }
}
