using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda {
    public class Contato {

        public string Nome;
        public string DataDeNascimento;
        public string Cpf;
        public string Endereco;
        public string Telefone;
        public string EMail;

        public Contato(string nome, string dataDeNascimento, string cpf, string endereco, string telefone, string eMail) {

            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Cpf = cpf;
            Endereco = endereco;
            Telefone = telefone;
            EMail = eMail;

        }
    }
        /*class Agenda {

            public void InserirContato() {

                var contato = new Contato("", "", "", "", "", "");

                var agenda = new LinkedList<Contato>();
                agenda.AddLast(contato);

                Console.WriteLine(agenda.Count);
                
                foreach (var contatos in agenda) {

                Console.WriteLine($"{contatos.Nome}{contatos.DataDeNascimento}{contatos.Cpf}{contatos.Endereco}{contatos.Telefone}{contatos.EMail}");

                }
                

                }
            }

        }*/

    }

