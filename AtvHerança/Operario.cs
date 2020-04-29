using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvHerança
{
    class Operario : Colaborador
    {
        private double valorProducao;
        private int comisao;

        public Operario(string Nome, string End, string Tel) :
            base(Nome, End, Tel)
        {

        }
        /* GET SET */
        public double ValorProducao
        {
            get { return valorProducao; }
            set { valorProducao = value; }
        }
        public int Comissao
        {
            get { return comisao; }
            set { comisao = value; }
        }

        public override double calcularSalario()
        {
            double valorFinal = valorProducao - (valorProducao * ((double)
                 Comissao / 100));
            return base.calcularSalario() + valorFinal;
        }
    }
}
