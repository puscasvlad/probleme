using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Hrana;

namespace FermaAnimalelor
{
    class Vaca : Animal
    {
        private string rasa;
        private IHrana hranaPreferata;

        public Vaca()
        {
            this.rasa = "Neagra";
            this.hranaPreferata = new Fan();
        }

        public override string Rasa
        {
            get
            {
                return this.rasa;
            }
        }

        public override IHrana HranaPreferata
        {
            get
            {
                return this.hranaPreferata;
            }
        }

        public override IResursa ColecteazaResurse()
        {
            return new Lapte(20);
        }
    }
}
