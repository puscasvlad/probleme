using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FermaAnimalelor.Infrastructura;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    class Oua : IResursa
    {
        public int cantitate;

        public string unitateDeMasura;

        public Oua(int cantitate)
        {
            this.cantitate = cantitate;
            this.unitateDeMasura = "bucati";
        }


        public int Cantitate
        {
            get
            {
                return this.cantitate;
            }
            set
            {
                cantitate = value;
            }
        }

        public string UnitateDeMasura
        {
            get
            {
                return this.unitateDeMasura;
            }
        }

     
    }
}
