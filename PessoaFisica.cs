using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoProjetoBanco
{
    public class PessoaFisica : Cliente
{
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }        
        public int Idade 
        { 
            get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } 
            private set {} 
        }

        public PessoaFisica(){
        }
        public PessoaFisica(string nome, string cpf, DateTime dataNascimento, int idade, string email, string telefone, string end, int numeroConta) : base(email, telefone, end, numeroConta )
        {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Idade = idade;
        }

        public bool EhMaior() => Idade >= 18;
        public override string ResumoCliente()
        {
           return  $"{NumeroConta} |  {Nome}  | {CPF}   |  {DataNascimento}  | {Endereco}  |  {Telefone}";
        }
    }
}