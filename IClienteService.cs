
using NovoProjetoBanco;

    public interface IClienteService
    {
    Cliente BuscarClientePorNumeroDeConta(int numeroConta);
    void CriarConta(string tipoConta);
    void ExibirClientes();
    }