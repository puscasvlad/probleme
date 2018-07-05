using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FermaAnimalelor.Infrastructura;
using System.Threading.Tasks;

namespace FermaAnimalelor.Hrana
{
    public class Fan : IHrana
    {
        public string Denumire
        {
            get
            {
                return "Fan";
            }
        }
    }
}
