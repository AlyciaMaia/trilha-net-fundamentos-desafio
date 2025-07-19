namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        //Propriedades da classe
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        //Construtor da classe Estacionamento
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        //Método para adicionar o veículo através da placa ao estacionamento
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }
        
        //Remove um veículo por meio da placa do estacionamento
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = (Console.ReadLine());

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                veiculos.Remove(placa);

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        //Adiciona uma carro à lista de carros que estão no estacionamento por meio da placa
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos) 
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
