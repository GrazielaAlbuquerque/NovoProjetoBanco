using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoProjetoBanco
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Transacao (DateTime data, double valor){
            Data = data;
            
            Valor = valor;
        }
    }
}