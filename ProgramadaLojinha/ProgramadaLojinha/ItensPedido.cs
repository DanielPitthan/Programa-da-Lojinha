using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramadaLojinha
{
    public class ItensPedido:Pedido
    {
        
        public string Produto { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; private set; }
        public double PrecoUnit { get; private set; }
        public double Total { get; private set; }
                                
        public ItensPedido(string mat,int emp,string codProduto, string DescricaoProduto,double quantidade, double precoUnit) 
            :base(mat,emp)
        {
            this.Produto = codProduto;
            this.Descricao = DescricaoProduto;
            this.Quantidade = quantidade;
            this.PrecoUnit = precoUnit;
            this.Total = quantidade * precoUnit;
        }

        //############################################
        // Soma mais um na quantidade 
        // atualizando o valor total
        //############################################
        public void Soma1()
        {
            this.Quantidade++;
            this.Total = this.Quantidade * PrecoUnit;
        }

    }
}
