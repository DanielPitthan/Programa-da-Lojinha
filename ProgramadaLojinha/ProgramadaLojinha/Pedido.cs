using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramadaLojinha
{
    public class Pedido
    {
        private string Matricula { get; set; }
        private int Empresa { get; set; }
        public double Total { get; private set; }

        public Pedido(string mat, int emp)
        {
            this.Matricula = mat;
            this.Empresa = emp;
        }


        public void ManipulaTotal(double valor)
        {
            this.Total = valor;
        }


    }
}
