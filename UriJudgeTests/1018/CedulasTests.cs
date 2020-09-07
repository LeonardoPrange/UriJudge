using System.Collections.Generic;
using FluentAssertions;
using UriJudge._1018;
using Xunit;

namespace UriJudgeTests._1018
{
    public class CedulasTests
    {
        Cedula cedula = new Cedula();
        
        [Fact]
        public void DeveRetornarQuantidadeDeNotaEValorFormatados()
        {
            cedula.FormataQuantidadeDeNotaEValor(2, 100.00).Should().Be("2 nota(s) de R$ 100,00");
        }

        [Fact]
        public void DeveRetornarListaComQuantidadeDeNotasPorValorDaNota_1()
        {
            var valoresEsperados = new List<QuantidadePorNotaDTO>();
            valoresEsperados.Add(new QuantidadePorNotaDTO(100, 5));
            valoresEsperados.Add(new QuantidadePorNotaDTO(50, 1));
            valoresEsperados.Add(new QuantidadePorNotaDTO(20, 1));
            valoresEsperados.Add(new QuantidadePorNotaDTO(10, 0));
            valoresEsperados.Add(new QuantidadePorNotaDTO(5, 1));
            valoresEsperados.Add(new QuantidadePorNotaDTO(2, 0));
            valoresEsperados.Add(new QuantidadePorNotaDTO(1, 1));
            cedula.NotasPorValorTotal(576).Should().BeEquivalentTo(valoresEsperados);
        }
        
        [Fact]
        public void DeveRetornarListaComQuantidadeDeNotasPorValorDaNota_2()
        {
            var valoresEsperados = new List<QuantidadePorNotaDTO>();
            valoresEsperados.Add(new QuantidadePorNotaDTO(100, 112));
            valoresEsperados.Add(new QuantidadePorNotaDTO(50, 1));
            valoresEsperados.Add(new QuantidadePorNotaDTO(20, 0));
            valoresEsperados.Add(new QuantidadePorNotaDTO(10, 0));
            valoresEsperados.Add(new QuantidadePorNotaDTO(5, 1));
            valoresEsperados.Add(new QuantidadePorNotaDTO(2, 1));
            valoresEsperados.Add(new QuantidadePorNotaDTO(1, 0));
            cedula.NotasPorValorTotal(11257).Should().BeEquivalentTo(valoresEsperados);
        }
        
        [Fact]
        public void DeveRetornarListaComQuantidadeDeNotasPorValorDaNota_3()
        {
            var valoresEsperados = new List<QuantidadePorNotaDTO>();
            valoresEsperados.Add(new QuantidadePorNotaDTO(100, 5));
            valoresEsperados.Add(new QuantidadePorNotaDTO(50, 0));
            valoresEsperados.Add(new QuantidadePorNotaDTO(20, 0));
            valoresEsperados.Add(new QuantidadePorNotaDTO(10, 0));
            valoresEsperados.Add(new QuantidadePorNotaDTO(5, 0));
            valoresEsperados.Add(new QuantidadePorNotaDTO(2, 1));
            valoresEsperados.Add(new QuantidadePorNotaDTO(1, 1));
            cedula.NotasPorValorTotal(503).Should().BeEquivalentTo(valoresEsperados);
        }
    }
}