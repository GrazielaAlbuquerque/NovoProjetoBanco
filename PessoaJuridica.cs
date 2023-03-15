using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoProjetoBanco
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public PessoaJuridica()
        {
            
        }

        public PessoaJuridica(string razaoSocial, string cnpj, string email, string telefone, string end, int numeroConta) : base (email, telefone, end, numeroConta )
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
        }
        public override string ResumoCliente()
        {
           return  $"{NumeroConta} |  {RazaoSocial}  | {CNPJ}";
        }
    }
}