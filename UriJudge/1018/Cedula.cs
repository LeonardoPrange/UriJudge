//Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto.
//As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1.
//A seguir mostre o valor lido e a relação de notas necessárias.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace UriJudge._1018
{
    public class Cedula
    {
        private static int[] NotasValidas
        {
            get => new int [7] {100, 50, 20, 10, 5, 2, 1};
        }
        public void Run(int valor)
        {
            Console.WriteLine($"{valor}");
            var notas = NotasPorValorTotal(valor);
            foreach (var nota in notas)
            {
                Console.WriteLine(FormataQuantidadeDeNotaEValor(nota.Quantidade, nota.ValorCedula));
            }
        }

        public IEnumerable<QuantidadePorNotaDTO> NotasPorValorTotal(int valorTotal)
        {
            int resto = valorTotal;
            foreach (var notaValida in NotasValidas)
            {
                var quantidadeDeNotas = resto / notaValida;
                resto = resto % notaValida;
                yield return new QuantidadePorNotaDTO(notaValida, quantidadeDeNotas);
            }
        }

        public string FormataQuantidadeDeNotaEValor(int quantidade, double valor)
        {
            var formatoDeNumeroBr = new CultureInfo("pt-BR", false).NumberFormat;
            var valorFormatado = valor.ToString("C", formatoDeNumeroBr);
            return $"{quantidade} nota(s) de {valorFormatado}";
        }
    }

    public class QuantidadePorNotaDTO
    {
        public int ValorCedula { get; }
        public int Quantidade { get; }

        public QuantidadePorNotaDTO(int valorCedula, int quantidade)
        {
            ValorCedula = valorCedula;
            Quantidade = quantidade;
        }
    }
}