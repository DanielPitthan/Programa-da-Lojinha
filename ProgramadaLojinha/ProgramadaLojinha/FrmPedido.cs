using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramadaLojinha
{
    public partial class FrmLojinha : Form
    {
        //faz a conexao com o banco de dados
        BancoDeDados db= new BancoDeDados();

        //Cria um dicionário para guardar os itens do pedido 
        Dictionary<string, ItensPedido> dcItensPv = new Dictionary<string, ItensPedido>(); //Cria um dicionário de pesquisa      

       
        public FrmLojinha()
        {
            InitializeComponent();

        }

        //#############################################
        // Incicialização do formulário 
        //#############################################
        private void Form1_Load(object sender, EventArgs e)
        {

            
            //pre carrega  alguns itens e valores
            cBEmpresa.Items.Add("Sanchez Cano Ltda");
            cBEmpresa.Items.Add("Fini Guloseimas");
            cBEmpresa.Items.Add("Fini Franquias");
            cBEmpresa.DropDownStyle = ComboBoxStyle.DropDownList; //Impede de selecionar o combobox com o cursor

            picLogo.Image = null;// Define o loding inicial do programa quanto a imagem //Properties.Resources.lgmid03;

            //Cria as colunas iniciais  do Listview
            lstvItens.Columns.Add("Produto", 150, HorizontalAlignment.Left);
            lstvItens.Columns.Add("Descrição", 300, HorizontalAlignment.Left);
            lstvItens.Columns.Add("Quantidade", 100, HorizontalAlignment.Left);
            lstvItens.Columns.Add("Preço Unit", 100, HorizontalAlignment.Left);
            lstvItens.Columns.Add("Total", 100, HorizontalAlignment.Left);

        }
        //#############################################
        // Gatilho após digitar nome do funcionário 
        //#############################################
        private void txMatricula_Leave(object sender, EventArgs e)
        {
            cbBoxSRA.Items.Clear(); //Limpa a lista atual de nomes 

            if (cBEmpresa.SelectedIndex==-1)
            {
                MessageBox.Show("Ecolha uma empresa antes de continuar.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txMatricula.Text = "";                
                return;
            }         

            try
            {
                db.Consulta("SELECT RA_MAT,RA_NOME FROM " + BancoDeDados.RetSqlName("SRA", cBEmpresa.SelectedIndex) + " WHERE RA_NOME LIKE '%" + txMatricula.Text.ToUpper() + "%'  AND D_E_L_E_T_='' AND RA_SITFOLH='' ");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.FechaTudo();
                return;
            }

            string primeiraMatricula="";
            bool first = true;

            while (db.dataReader.Read())
            {
                if (first)
                {
                     primeiraMatricula = Convert.ToString(db.dataReader[0]) + "-" + Convert.ToString(db.dataReader[1]);
                    first = false;
                }

                cbBoxSRA.Items.Add(Convert.ToString(db.dataReader[0])+"-"+ Convert.ToString(db.dataReader[1]));                
            }

            cbBoxSRA.SelectedIndex = 0;
            cbBoxSRA.Text = primeiraMatricula;

        db.FechaTudo();

        }

      

        //####################################
        // Leitura do código de Barras
        //####################################
        private void LeiaCodBar(object sender, EventArgs e)
        {
            

            //##########
            // Validação de campos
            //##########
            if ( String.IsNullOrEmpty(cbBoxSRA.Text))
            {
                MessageBox.Show("Escolha uma Matrícula antes de continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCodbar.Text = "";
                return;
            }


            if (cBEmpresa.SelectedIndex == -1)
            {
                MessageBox.Show("Ecolha uma empresa antes de continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCodbar.Text = "";
                return;
            }


            if (String.IsNullOrEmpty(txCodbar.Text))
            {                
                txCodbar.Text = "";
                return;
            }


            //Inicializando a Pesquisa no banco 
            string cquery = "";


            //Monta a query de consulta ao banco de dados            
            cquery = " SELECT B1_COD,B1_DESC,DA1_PRCVEN  ";
            cquery +=" FROM " + BancoDeDados.RetSqlName("SB1", cBEmpresa.SelectedIndex) + " AS SB1 WITH(NOLOCK) ";
            cquery +=" JOIN " +BancoDeDados.RetSqlName("DA1", cBEmpresa.SelectedIndex) + "  AS DA1 WITH(NOLOCK) ON  DA1_CODPRO=B1_COD ";
            cquery +=" WHERE ( B1_COD='" + txCodbar.Text + "' OR  B1_CODBAR='" + txCodbar.Text + "' or B1_EAN13A='" + txCodbar.Text + "' or B1_EAN13B='" + txCodbar.Text + "' or B1_EAN13C='" + txCodbar.Text + "') ";
            cquery +=" AND DA1_CODTAB='3FC'";
            cquery +=" AND DA1.D_E_L_E_T_='' AND SB1.D_E_L_E_T_ = ''";

            try
            {
                db.Consulta(cquery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.FechaTudo();
                return;
            }

            while (db.dataReader.Read()) //Faço um while para o caso de retornar mais de um registro
            {
               
                //guarda os dados em variáveis 
                string matricula         = cbBoxSRA.Text.Substring(0,6);
                int    empresa           = cBEmpresa.SelectedIndex;
                string produto           = Convert.ToString(db.dataReader[0]);
                string descricaoProduto  = Convert.ToString(db.dataReader[1]);                
                double precoUnitario     = Convert.ToDouble(db.dataReader[2]);

                //cria um novo item do pedido 
                ItensPedido items = new ItensPedido(matricula, empresa, produto,descricaoProduto, 1, precoUnitario);


                try
                {
                   
                    //pesquisa se o item já exites 
                   ItensPedido seekPedido = dcItensPv[produto];
                    //Se encontrei o item do pedido eu somo mais na quantidade e recalculo o total
                   seekPedido.Soma1();
                    //atualiza o item no dictinary
                    dcItensPv[produto] = seekPedido;
                    

                }
                catch (Exception)
                {
                    //adiciona no Dictionary
                    dcItensPv.Add(Convert.ToString(db.dataReader[0]), items);
                    
                }
                
                              
            }

            //Limpa a lista atual, para não adcionar itens repetidos 
            lstvItens.Items.Clear();

            double ntotal=0;

            foreach ( KeyValuePair<string,ItensPedido> par in dcItensPv)
            {
                
                string[] additens = new string[5];

                additens[0] = par.Value.Produto;
                additens[1] = par.Value.Descricao;
                additens[2] = Convert.ToString(par.Value.Quantidade);
                additens[3] = Convert.ToString(par.Value.PrecoUnit);
                additens[4] = Convert.ToString(par.Value.Total);
                                
                lstvItens.Items.Add(new ListViewItem(additens));

                //Soma de todos os itens 
                ntotal += par.Value.Total;
            }



            //atualiza o texto em tela do total
            txTotal.Text = Convert.ToString(ntotal);

            db.FechaTudo();
            txCodbar.Text = "";
            txCodbar.Focus();

        }


        //#######################################
        // Validação da escolha da empresa
        //#######################################
        private void ValidaEmpresa(object sender, EventArgs e)
        {


            //Conforme troco a empresa - mudo o Logotipo 
            if (cBEmpresa.SelectedIndex == 0)
            {
                picLogo.Image = Properties.Resources.lgmid01;
            }
            if (cBEmpresa.SelectedIndex == 1)
            {
                picLogo.Image = Properties.Resources.lgmid02;
            }
            if (cBEmpresa.SelectedIndex == 2)
            {
                picLogo.Image = Properties.Resources.lgmid03;
            }

            //Limpo também a caixa de pesquisa de nome 
            txMatricula.Text = "";
            cbBoxSRA.Text = "";
            cbBoxSRA.Items.Clear();
            

        }

        private void btGrava_Click(object sender, EventArgs e)
        {

            DialogResult pergunta = MessageBox.Show("Confirma a Gravação do Pedido?","Grava Pedido",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (pergunta==DialogResult.No)
            {
                return;
            }


            //Empresa Protheus 
            string empresa;

            if (cBEmpresa.SelectedIndex == 0)
            {
                empresa = "01";
            }else if (cBEmpresa.SelectedIndex == 1)
            {
                empresa = "02";

            }
            else
            {
                empresa = "03";
            }           

            //Grava o cabeçalho do pedido 
            string cExecQuery = string.Format("insert into PV_HEADER (Matricula,Empresa,NomeFunc,empresaTotvs) values ('{0}',{1},'{2}','{3}')", cbBoxSRA.Text.Substring(0, 6),cBEmpresa.SelectedIndex,cbBoxSRA.Text.Substring(7,cbBoxSRA.Text.Length-7), empresa);
            db.ExecQuery(cExecQuery);


            //PEGA O NÚMERO DO PEDIDO GERADO
            db.Consulta("select max(Id) as Id from PV_HEADER");
            db.dataReader.Read();
            int idped = Convert.ToInt32( db.dataReader[0]);            


            //faz a gravação dos itens do pedido
            foreach (KeyValuePair<string,ItensPedido> p in dcItensPv)
            {
                
              
                cExecQuery = "insert into PV_DETAIL (Idpv,CodProduto,Descricao,Quantidade,PrecoUnitario,Total) ";
                cExecQuery +="values (" + idped + ",'" + p.Value.Produto + "','" + p.Value.Descricao + "'," + p.Value.Quantidade.ToString().Replace(",", ".") + "," + p.Value.PrecoUnit.ToString().Replace(",", ".") + "," + p.Value.Total.ToString().Replace(",", ".") + ") ";

                db.ExecQuery(cExecQuery);
            }
            pergunta = MessageBox.Show("Pedido gravado com sucesso. Pedido: " + idped + "\n\r" + "Deseja imprimir o pedido", "PEDIDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //gravar o número do pedido do protheus

            if (pergunta == DialogResult.Yes)
            {
                FrmUltimoPedidoLojinha impPedido = new FrmUltimoPedidoLojinha();
                impPedido.ShowDialog();
            }

            //Limpa os dados em tela
            Close();


        

        }


        //##############################
        //Exclusao do item na Grade
        //##############################
        private void btExclui_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txTotal.Text);

            //itens marcados
            var marked = lstvItens.CheckedIndices;
           
            while (marked.Count>0)
            {

                total -= dcItensPv[lstvItens.Items[marked[0]].Text].Total;

                //Primeiro remove o item do Dictonary
                dcItensPv.Remove(lstvItens.Items[marked[0]].Text);

                //Depois o item do list view (visual)
                lstvItens.Items[marked[0]].Remove();  
                
                //atualiza os itens marcados
                marked = lstvItens.CheckedIndices;

            }

            txTotal.Text = total.ToString();


        }

        private void btImprime_Click(object sender, EventArgs e)
        {
           
        }
    }
    }   
        


