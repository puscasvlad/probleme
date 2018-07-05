using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Hrana;

namespace FermaAnimalelor
{ 
    class Gaina : Animal
    {
        public Gaina ()
        {
            this.hranaPreferata = new Cereale();
            this.rasa = "Cocos"; 
        }

 
        private IHrana hranaPreferata;
        private string rasa;
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
            
            return new Oua(2);

           
        }
    }
}
