using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoProjetoBanco
{
    public interface IClienteService
    {
        void CriarConta(string tipoConta) ;
        Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        void  ExibirClientes();
    }
}