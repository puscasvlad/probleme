using System;
using FermaAnimalelor.Infrastructura;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    public class Cereale : IHrana
    {
        public string Denumire
        {
            get
            {
                return "Cereale";
            }
        }

        
    }
}
