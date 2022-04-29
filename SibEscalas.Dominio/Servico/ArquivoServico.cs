using SibEscalas.Dominio.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SibEscalas.Dominio.Servico
{
    public class ArquivoServico
    {
        public void SalvarArquivo(string stringPath, string titulo)
        {
            //recebo caminho do arquivo -> lista de objetos
            //converto a lista pra Json
            //escrevo no disco

            string local = stringPath + titulo + ".json";

            using (StreamWriter escritor = new StreamWriter(local))
            {
                //escritor.WriteLine(JsonExtension.ConverteObjectParaJSon<IList<Pessoa>>(pessoas));
            }
        }

        public void AbrirArquivo()
        {

        }
    }
}
