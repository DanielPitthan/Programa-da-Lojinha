using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramadaLojinha
{
    public class Arquivos
    {
        public string Ext { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }
        public string FullPath { get; set; }

        public Arquivos(string extensao, string arquivo, string caminho)
        {
            this.Ext = extensao;
            this.Arquivo = arquivo;
            this.Caminho = caminho;
            this.FullPath = this.Caminho + this.Arquivo+this.Ext;
        }

        //Grava um novo arquivo em disco ou substitui o existente
        public bool GravaNovo(string texto)
        {
            using (Stream saida = File.Open(this.FullPath, FileMode.Create))            
            using (StreamWriter grv = new StreamWriter(saida))
             {
                grv.WriteLine(texto);
             }
            
            return true;
        }

        //Append ao arquivo existente
        public bool GravaAppend(string texto)
        {
            using (Stream saida = File.Open(this.FullPath, FileMode.Append))
            using (StreamWriter grv = new StreamWriter(saida))
            {
                grv.WriteLine(texto);
            }

            return true;
        }


        //Leitura do arquivo 
        public string LeiaTudo()
        {
            using (Stream entrada = File.Open(this.FullPath, FileMode.Open))
            using (StreamReader leitor = new StreamReader(entrada))
            {

                return leitor.ReadToEnd();                           
               
            }

            return null;
        }

        //Verifica se o arquivo já existe 
        public static bool JaExisteArquivo(string arquivo)
        {
            if (!File.Exists(arquivo))
            {
                return false;
            }
            return true;
        }

    }
}
