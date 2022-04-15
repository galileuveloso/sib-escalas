using NUnit.Framework;
using SibEscalas.Dominio.Extensions;
using SibEscalas.Dominio.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace SibEscalas.Testes
{
    public class ArquivoTeste
    {
        private const string ARQUIVO = @"C:\\Users\\galil\\Desktop\\escala\\SibEscalas\\SibEscalas.Testes\\arquivos\\arquivo.txt";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SalvarJson()
        {
            IList<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa { Id = Guid.NewGuid(), Nome = "Galileu", Funcao = new Funcao { Id = Guid.NewGuid(), Descricao = "Dev" } },
                new Pessoa { Id = Guid.NewGuid(), Nome = "Leonardo", Funcao = new Funcao { Id = Guid.NewGuid(), Descricao = "Guitarrista" } }
            };

            using StreamWriter escritor = new StreamWriter(ARQUIVO);
            escritor.WriteLine(JsonExtension.ConverteObjectParaJSon<IList<Pessoa>>(pessoas));
        }

        [Test]
        public void ObterJson()
        {
            string[] lines = File.ReadAllLines(ARQUIVO);
            IList<Pessoa> pessoas = JsonExtension.ConverteJSonParaObject<IList<Pessoa>>(lines[0]);
        }
    }
}