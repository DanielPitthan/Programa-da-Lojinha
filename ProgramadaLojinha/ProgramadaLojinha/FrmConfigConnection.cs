using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProgramadaLojinha
{
    public partial class FrmConfigConnection : Form
    {
        public FrmConfigConnection()
        {
            InitializeComponent();
        }

        private void btGravaConfigDb_Click(object sender, EventArgs e)
        {

            //Testa se o arquivo de configuração já existe 
            if (Arquivos.JaExisteArquivo(@"Configdb.xml"))
            {
                DialogResult msnPergunta = MessageBox.Show("Arquivo de configuração já existe.\n\r Deseja Sobreecrever","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if(msnPergunta == DialogResult.No) 
                {
                    return;
                }

            }

            string trusted;
            if (ckTrustedConnection.Checked) { trusted = "True"; } else { trusted = "False"; }
            BancoDeDados.AtualizaConfigXML(txServer.Text, txDabaBase.Text, trusted);
            Close();

        }

        private void FrmConfigConnection_Load(object sender, EventArgs e)
        {
            //define que o texto digitado será do tipo passaword
            txPassword.PasswordChar = '*';
            
            
            //Testa se o arquivo de configuração já existe 
            if (!Arquivos.JaExisteArquivo(@"Configdb.xml"))
            {
                DialogResult msnPergunta = MessageBox.Show("Arquivo de configuração não já existe.\n\r Deseja criá-lo", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (msnPergunta == DialogResult.No)
                {
                    return;
                }

            }

            //Carrega os dados do XML
            XElement xml = XElement.Load("Configdb.xml");

            txServer.Text = xml.Attribute("Servidor").Value;
            txDabaBase.Text = xml.Attribute("DataBase").Value;            

            txUserdb.Text = xml.Attribute("UserId").Value;
            txPassword.Text = xml.Attribute("Password").Value;

            if (xml.Attribute("TrustedConnection").Value == "True")
            {
                ckTrustedConnection.Checked = true;
            }
            else
            {
                ckTrustedConnection.Checked = false;
            }

        }

    }
}
