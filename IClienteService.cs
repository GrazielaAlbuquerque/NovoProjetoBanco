
using NovoProjetoBanco;

    public interface IClienteService
    {
    Cliente BuscarCliente(int numeroConta);
    void CriarConta(string tipoConta);
    void ExibirClientes();
    }