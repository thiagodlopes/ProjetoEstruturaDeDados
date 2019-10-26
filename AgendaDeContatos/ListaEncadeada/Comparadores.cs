using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda {
    public class CompararNome: IComparer<Contato> {
            public int Compare(Contato x, Contato y) {

                if (x.Nome == null || y.Nome == null) {
                    return 0;
                }

                // "CompareTo()" method 
                return x.Nome.CompareTo(y.Nome);

            }
        }
    }
