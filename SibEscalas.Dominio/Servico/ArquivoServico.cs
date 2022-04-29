using SibEscalas.Dominio.Extensions;
using System.IO;
using System.Windows.Forms;

namespace SibEscalas.Dominio.Servico
{
    public static class ArquivoServico
    {
        public static void SalvarArquivo(SaveFileDialog fileDialog, Store store)
        {
            string jsonStore = JsonExtension.ConverteObjectParaJSon<Store>(store);

            FileStream fs = new FileStream(fileDialog.FileName, FileMode.Create);
            StreamWriter escritor = new StreamWriter(fs);

            escritor.WriteLine(jsonStore);
            escritor.Close();
        }

        public static Store AbrirArquivo(OpenFileDialog fileDialog)
        {
            StreamReader sr = new StreamReader(fileDialog.FileName);
         
            return JsonExtension.ConverteJSonParaObject<Store>(sr.ReadLine());
        }
    }
}
