using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos;
        private static readonly CultureInfo culturaPtBr = new CultureInfo("pt-BR");

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placaDigitada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(placaDigitada))
            {
                Console.WriteLine("Placa inválida. Operação cancelada.");
                return;
            }

            string placa = placaDigitada.Trim().ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"O veículo {placa} já está estacionado aqui.");
                return;
            }

            veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} adicionado ao estacionamento.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placaDigitada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(placaDigitada))
            {
                Console.WriteLine("Placa inválida. Operação cancelada.");
                return;
            }

            string placa = placaDigitada.Trim().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas;
                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                    Console.WriteLine("Por favor, insira um número válido de horas.");
                }

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Removendo a placa da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("C", culturaPtBr)}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

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
