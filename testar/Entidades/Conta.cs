using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testar.Entidades
{
    internal class Conta
    {
        public Conta(int numero, string nomeBanco)
        {
            _numeroConta = numero;
            _nomeBancoConta = nomeBanco;
        }

        public int _numeroConta { get; set; }
        public string _nomeBancoConta { get; set; }
    }
}
