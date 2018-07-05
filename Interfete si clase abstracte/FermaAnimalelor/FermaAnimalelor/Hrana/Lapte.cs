using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Infrastructura;

namespace FermaAnimalelor.Hrana
{
    public class Lapte : IResursa
    {
        public int cantitate;
        public string unitateDeMasura;

        public Lapte(int cantitate)
        {
            this.cantitate = cantitate;
            this.unitateDeMasura = "Litri";
        }

        public int Cantitate
        {
            get
            {
                return this.cantitate;
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
