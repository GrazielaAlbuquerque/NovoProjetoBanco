using NovoProjetoBanco;

namespace NovoProjetoBanco
{
    public class ClienteService : IClienteService
    {
        public static List<Cliente> clientes = new List<Cliente>();

        public Cliente BuscarClientePorNumeroDeConta(int numeroConta)
        {
            return clientes.Find(x => x.NumeroConta == numeroConta);
        }

        public void ExibirClientes()
        {
            Console.WriteLine("Número da conta        | Nome         | CPF    ");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(clientes[i].ResumoCliente());
            }
        }

        public void CriarConta(string tipoConta)
        {
            if (tipoConta == "1")
            {
                PessoaFisica pessoaFisica = new PessoaFisica();
                Console.WriteLine("Data de Nascimento do cliente:");
                pessoaFisica.DataNascimento = DateTime.Parse(Console.ReadLine());

                if (!pessoaFisica.EhMaior())
                {
                    Console.WriteLine("Não é possivel abrir a conta pois o Cliente é menor de idade.");
                    return;
                }

                Console.WriteLine("A idade do cliente é " + pessoaFisica.Idade);
                Console.WriteLine("Nome do cliente:");
                pessoaFisica.Nome = Console.ReadLine();
                Console.WriteLine("CPF do cliente:");
                pessoaFisica.CPF = Console.ReadLine();
                Console.WriteLine("Endereco do cliente:");
                pessoaFisica.Endereco = Console.ReadLine();
                Console.WriteLine("Telefone do cliente:");
                pessoaFisica.Telefone = Console.ReadLine();
                Console.WriteLine("Email do cliente:");
                pessoaFisica.Email = Console.ReadLine();
                Console.WriteLine("Numero Da Conta");
                pessoaFisica.NumeroConta = int.Parse(Console.ReadLine());
                clientes.Add(pessoaFisica);
            }
            else if (tipoConta == "2")
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica();
                Console.WriteLine("Razão Social do cliente:");
                pessoaJuridica.RazaoSocial = Console.ReadLine();
                Console.WriteLine("CNPJ do cliente:");
                pessoaJuridica.CNPJ = Console.ReadLine();
                Console.WriteLine("Endereco do cliente:");
                pessoaJuridica.Endereco = Console.ReadLine();
                Console.WriteLine("Telefone do cliente:");
                pessoaJuridica.Telefone = Console.ReadLine();
                Console.WriteLine("Email do cliente:");
                pessoaJuridica.Email = Console.ReadLine();
                Console.WriteLine("Numero Da Conta");
                pessoaJuridica.NumeroConta = int.Parse(Console.ReadLine());
                clientes.Add(pessoaJuridica);
            }
        }
    }
}