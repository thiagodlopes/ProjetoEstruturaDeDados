using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
namespace Agenda {
    public class Program {
        public static void Main(string[] args) {

            TextInfo informaçãoDeTexto = new CultureInfo("pt-BR", false).TextInfo;
            var agenda = new List<Contato>();
            var gg = new CompararNome();
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
                            InserirContato();
                            Console.Clear();
                            return true;
                        case "2": //Já tá OK
                            AlterarContato();
                            Console.ReadLine();
                            return true;
                        case "3": //Já tá OK
                            ExcluirContato();
                            return true;
                        case "4": //Já tá OK
                            LimparAgenda();
                            return true;
                        case "5": //Já tá OK
                            Console.Clear();
                            Console.WriteLine(ContarContatos());
                            ListarContatos();
                            return true;
                        case "6": //Já tá OK
                            return false;
                        default:
                            return true;

                    }

                }

            }
                void InserirContato() {

                    Console.Write("\r\nNome: ");
                    string nome = Console.ReadLine();
                    Console.Write("\r\nData de nascimento (AAAA/MM/DD): ");
                    string nascimento = Console.ReadLine();
                    Console.Write("\r\nCPF: ");
                    string cpf = Console.ReadLine();
                    Console.Write("\r\nEndereço: ");
                    string endereco = Console.ReadLine();
                    Console.Write("\r\nTelefone: ");
                    string telefone = Console.ReadLine();
                    Console.Write("\r\nE-mail: ");
                    string eMail = Console.ReadLine();

                    var contato = new Contato(informaçãoDeTexto.ToTitleCase(nome), informaçãoDeTexto.ToTitleCase(nascimento), informaçãoDeTexto.ToTitleCase(cpf), informaçãoDeTexto.ToTitleCase(endereco), informaçãoDeTexto.ToTitleCase(telefone), informaçãoDeTexto.ToLower(eMail));
                    agenda.Add(contato);

                }

                string ContarContatos() {

                    if (agenda.Count == 1) {
                        return ($"Há {agenda.Count} contato na sua agenda.");
                    }
                    else if (agenda.Count > 1) {
                        return ($"Há {agenda.Count} contatos na sua agenda.");
                    }
                    else {
                        return ("Não há contatos na agenda.");
                    }

                }

                void ListarContatos() {
                    agenda.Sort(gg);
                    foreach (Contato contato in agenda) {

                        Console.WriteLine();
                        Console.WriteLine($"Nome: {contato.Nome}");
                        Console.WriteLine($"Data de nascimento: {contato.DataDeNascimento}");
                        Console.WriteLine($"CPF: {contato.Cpf}");
                        Console.WriteLine($"Endereço: {contato.Endereco}");
                        Console.WriteLine($"Telefone: {contato.Telefone}");
                        Console.WriteLine($"E-mail: {contato.EMail}");

                    }

                    Console.ReadLine();
                }

                void AlterarContato() {

                    Console.WriteLine("Qual contato será alterado? ");
                    string alterar = informaçãoDeTexto.ToTitleCase(Console.ReadLine());

                    foreach (Contato contato in agenda) {

                        if (contato.Nome == alterar) {

                            bool mostrarMenuAlterar = true;

                            while (mostrarMenuAlterar) {
                                mostrarMenuAlterar = MenuAlterar();
                            }

                            bool MenuAlterar() {

                                Console.WriteLine($"Quais dados do contato '{contato.Nome}' devem ser alterados?");
                                Console.WriteLine("1 - Nome");
                                Console.WriteLine("2 - Data de nascimento");
                                Console.WriteLine("3 - CPF");
                                Console.WriteLine("4 - Endereço");
                                Console.WriteLine("5 - Telefone");
                                Console.WriteLine("6 - E-mail");
                                Console.WriteLine("7 - Cancelar");

                                switch (Console.ReadLine()) {
                                    case "1":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo nome para o contato '{contato.Nome}'");
                                        alterar = informaçãoDeTexto.ToTitleCase(Console.ReadLine());
                                        contato.Nome = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        string resp = informaçãoDeTexto.ToTitleCase(Console.ReadLine());

                                        if (resp == "N") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "2":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo e-mail para o contato '{contato.Nome}'. O atual é: '{contato.DataDeNascimento}'");
                                        alterar = informaçãoDeTexto.ToTitleCase(Console.ReadLine());
                                        contato.DataDeNascimento = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = informaçãoDeTexto.ToTitleCase(Console.ReadLine());

                                        if (resp == "N") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "3":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo CPF para o contato '{contato.Nome}'. O atual é: '{contato.Cpf}'");
                                        alterar = informaçãoDeTexto.ToTitleCase(Console.ReadLine());
                                        contato.Cpf = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = informaçãoDeTexto.ToTitleCase(Console.ReadLine());

                                        if (resp == "N") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "4":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo endereço para o contato '{contato.Nome}'. O atual é: '{contato.Endereco}'");
                                        alterar = informaçãoDeTexto.ToTitleCase(Console.ReadLine());
                                        contato.Endereco = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = informaçãoDeTexto.ToTitleCase(Console.ReadLine());

                                        if (resp == "N") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "5":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo telefone para o contato '{contato.Nome}'. O atual é: '{contato.Telefone}'");
                                        alterar = informaçãoDeTexto.ToTitleCase(Console.ReadLine());
                                        contato.Telefone = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = informaçãoDeTexto.ToTitleCase(Console.ReadLine());

                                        if (resp == "n") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "6":
                                        Console.Clear();
                                        Console.WriteLine($"Infome o novo e-mail para o contato '{contato.Nome}'. O atual é: '{contato.EMail}'");
                                        alterar = informaçãoDeTexto.ToLower(Console.ReadLine());
                                        contato.EMail = alterar;
                                        Console.WriteLine("Deseja alterar outro dado? [S/N]");
                                        resp = informaçãoDeTexto.ToTitleCase(Console.ReadLine());

                                        if (resp == "N") {
                                            return false;
                                        }
                                        else {
                                            return true;
                                        }

                                    case "7":
                                        return false;

                                    default:
                                        return true;
                                }
                            }

                        }

                    }

                }

                void ExcluirContato() {

                    Console.WriteLine("Qual contato será excluído? ");
                    string remover = informaçãoDeTexto.ToTitleCase(Console.ReadLine());
                    int contador = 0;

                    foreach (Contato contatos in agenda) {

                        if (contatos.Nome == remover) {
                            Console.WriteLine($"O contato '{remover}' foi removido.");
                            if (contatos.Nome.Contains(remover)) {
                                agenda.Remove(contatos);
                                return;
                            }
                        }
                        else {
                            contador++;
                        }
                    }

                    if (contador == agenda.Count) {
                        Console.WriteLine($"O contato '{remover}' não consta na sua lista de contatos.");
                        Console.ReadLine();
                    }
                }

                void LimparAgenda() {

                    Console.WriteLine("Tem certeza que deseja excluir todos os contatos? Este processo é irreversível. [S/N]");
                    string resp = informaçãoDeTexto.ToTitleCase(Console.ReadLine());

                    if (agenda.Count == 0) {
                        Console.WriteLine("A sua agenda já está vazia.");
                        Console.ReadLine();
                        return;
                    }
                    else {

                        if (resp == "S") {//Verificar se há contatos na lista primeiro
                            agenda.Clear();
                            Console.WriteLine("Todos os contatos foram excluídos.");
                            Console.ReadLine();
                            return;
                        }
                        else {
                            return;
                        }
                    }



                }
        }
    }
}
