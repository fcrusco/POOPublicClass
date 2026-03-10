namespace AppPOO.model
{
    public class ContaBancaria
    {

        private string titular;
        private decimal saldo;
        private const decimal TARIFA_SAQUE = 2.50m;

        //propriedade
        public string Titular
        {
            get { return titular; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome não pode ser vazio");

                titular = value;
            }
        }
        public decimal Saldo
        {
            get { return saldo; }
            private set { saldo = value; }
        }

        //construtor
        public ContaBancaria(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        //método
        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"\nTitular: {Titular} - Saldo: R${Saldo}");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Saque inválido. Valor deve ser maior que zero.");
                return;
            }

            decimal valorTotal = valor + TARIFA_SAQUE;

            if (valorTotal <= Saldo)
            {
                Saldo -= valorTotal;
                Console.WriteLine($"Saque de R${valorTotal} realizado com tarifa de {TARIFA_SAQUE}.");
                Console.WriteLine($"Saldo atual R${saldo}.");
            }
            else
                Console.WriteLine("Saldo insuficiente para saque.");
        }
    }
}
