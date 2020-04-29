using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvHerança 
{
    class Administrador : Colaborador
    {
        private double ajudaDeCusto;

        public Administrador(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {

        }
        

        public double AjudaDeCusto
        {
            get { return ajudaDeCusto; }
            set { AjudaDeCusto = value; }
        }

        public override double calcularSalario()
        {
            return base.calcularSalario() + AjudaDeCusto;
        }
    }
}
