using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ProgramadaLojinha
{
    public class BancoDeDados
    {

        private SqlConnection sqlCon;
        private SqlCommand cmd;
        public SqlDataReader dataReader;        
        private string stringConexao;      
        public  string query { get; private set; }

        public  string Servidor { get; set; }
        public  string DataBase { get; set; }
        public  string TrustedConnection { get; set; }
        public  string UserId { get; set; }
        public  string Password { get; set; }
        

        //Construtor da classe
        public BancoDeDados()
        {
            this.CarregaConfigXML();           
            this.stringConexao = @"Server =" + this.Servidor + ";Database=" + this.DataBase + "; Trusted_Connection=" + this.TrustedConnection + ";"; //stringConexao;           
        }

        //executa a consulta no banco 
        public bool Consulta(string cquery)
        {
            //monta a conexão 
            this.sqlCon = new SqlConnection(this.stringConexao); 

            //armazena a query para consulta
            this.query = cquery;

            //Abre a conexao
            this.sqlCon.Open();

            //Monta a query
            this.cmd = new SqlCommand(cquery, this.sqlCon);           

            //Executa a query no banco  
            this.dataReader = cmd.ExecuteReader();            



            if (!this.dataReader.HasRows)
            {
                throw new Exception("Não há dados.");
            }

            return this.dataReader.HasRows;
                       
        }

        //#####################
        //Executa uma query no banco de dados 
        //#####################
        public void ExecQuery(string cquery)
        {
            //monta a conexão 
            using (this.sqlCon = new SqlConnection(this.stringConexao))
            {

                //armazena a query para consulta
                this.query = cquery;


                //Monta a query
                this.cmd = new SqlCommand(cquery, this.sqlCon);

                //define o tipo de consulta
                cmd.CommandType = CommandType.Text;

                cmd.Connection = sqlCon;

                //Abre a conexao
                this.sqlCon.Open();

                //Executa a query no banco de dados 
                cmd.ExecuteNonQuery();                
            }
            
        }

    

        //#####################################
        //Atualiza as configuração do no XML
        //#####################################
        public static void AtualizaConfigXML(string server, string database, string trustedconnection = "True", string userid = "", string password = "")
        {
            
            XElement x = new XElement("BancoDeDados");

            x.Add(new XAttribute("Servidor", server ));
            x.Add(new XAttribute("DataBase", database));
            x.Add(new XAttribute("TrustedConnection", trustedconnection));
            x.Add(new XAttribute("UserId", userid));
            x.Add(new XAttribute("Password", password));

            //XElement xml = XElement.Load("Configdb.xml");
            // xml.Add(x);
            x.Save("Configdb.xml");
        }

        //#####################################
        //Carrega as configurações do XML
        //#####################################
        public void CarregaConfigXML()
        {
            XElement xml = XElement.Load("Configdb.xml");

            this.Servidor = xml.Attribute("Servidor").Value;
            this.DataBase = xml.Attribute("DataBase").Value;

            this.UserId = xml.Attribute("UserId").Value;
            this.Password = xml.Attribute("Password").Value;
            this.TrustedConnection = xml.Attribute("TrustedConnection").Value;           

        }


        //#####################
        //Fechamentos 
        //#####################

        //Fecha a conexao
        public void FechaConexao()
        {
            this.sqlCon.Close();
        }
        //fecha a query
        public void FechaQuery() {
            this.dataReader.Close();
        }

        //fecha tudo 
        public void FechaTudo() {

            this.dataReader.Close();
            this.sqlCon.Close();

        }

        public static string RetSqlName(string alias, int empresa)
        {
            //alias = SRA
            //EMPRESA = 01
            //SRA010          
            empresa++; //somo 1 pois a numeração no C# começa em zero e no TOTVS começa em 1
            return alias +  empresa.ToString().PadLeft(2,'0') + "0";
        }

    }
}
