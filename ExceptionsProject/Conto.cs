using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsProject {
    class Conto {
        public decimal Saldo { get; set; }
        public decimal Ritira( decimal somma)
        {
            if(Saldo >= somma)
            {
                Saldo -= somma;
                return Saldo;
            }
            //FondiInsufficientiException fe = new FondiInsufficientiException("Fondi insufficienti", Saldo, somma);
            //throw fe;
            throw new FondiInsufficientiException("Fondi insufficienti", Saldo, somma);
        }
    }
}
