//Encapsulamento - Alterar propriedade para private set { saldo = value; }
using AppPOO.model;

Console.WriteLine("Entre com o nome:");
string nome = Console.ReadLine();

Console.WriteLine("Entre com o saldo em conta:");
string input = Console.ReadLine();

if (!decimal.TryParse(input, out decimal saldo))
    Console.WriteLine("Valor inválido. Digite um número decimal válido.");

//adicionar bloco try/catch no momento de instanciar a classe
try
{
    ContaBancaria conta = new ContaBancaria(nome, saldo);
    conta.ExibirSaldo();
    //conta.Saldo = -500; //forçar alteração
    //Console.WriteLine(conta.Saldo)  //ler o saldo 
    string resposta;
    do
    {
        Console.WriteLine("\nQual operação deseja realizar?");
        Console.WriteLine("1 - Depósito");
        Console.WriteLine("2 - Exibir Saldo");
        Console.WriteLine("3 - Saque");

        if (byte.TryParse(Console.ReadLine(), out byte opcao))
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor para depósito:");
                    input = Console.ReadLine();
                    if (decimal.TryParse(input, out decimal valorDep) && valorDep > 0)
                    {
                        conta.Depositar(valorDep);
                        conta.ExibirSaldo();
                    }
                    else
                        Console.WriteLine("Valor inválido");

                    break;
                case 2:
                    conta.ExibirSaldo();
                    break;
                case 3:
                    Console.WriteLine("Digite o valor para saque:");
                    input = Console.ReadLine();
                    if (decimal.TryParse(input, out decimal valorSaque) && valorSaque > 0)
                    {
                        conta.Sacar(valorSaque);
                        conta.ExibirSaldo();
                    }
                    else
                        Console.WriteLine("Valor inválido");

                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
        else
            Console.WriteLine("Valor inválido");

        Console.WriteLine("\nDeseja realizaar outra operação (S/N)?");
        resposta = Console.ReadLine().Trim().ToUpper();

    } while (resposta == "S");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

