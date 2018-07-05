using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Hrana;
using FermaAnimalelor.Infrastructura;

namespace FermaAnimalelor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intr-o ferma se afla 3 vaci, 2 oi si 5 gaini. Defineste clasele corespunzatoare
            //folosind clasele si interfetele predefinite fara a le modifica in vreun fel si 
            // afiseaza raspunsurile la cele 4 intrebari de mai jos.

            //adauga animalele in lista predefinita
            Animal[] animale = new Animal[10];


            animale[0] =  new Gaina();
            animale[1] =  new Gaina();
            animale[2] =  new Oi();
            animale[3] =  new Oi();
            animale[4] =  new Gaina();
            animale[5] =  new Gaina();
            animale[6] = new Vaca();
            animale[7] = new Vaca();
            animale[8] = new Gaina();
            animale[9] = new Vaca();



            //1. Tipareste numarul de gaini calculandul programatic

            #region NumarGaini
            //int suma = 0;

            //for (int i = 0; i < animale.Length; i++)
            //{                
            //    if(animale[i].Rasa=="Cocos")
            //    {
            //        suma++;
            //    }
            //}
            //Console.WriteLine($"In ferma de animale avem {suma} gaini");

            #endregion NumarGaini

            //2. Hraneste animalele cu tipul de hrana adecvat. Tipurile de hrana vor fi definite
            // folosind IHRana si create in folderul Hrana

            #region HranesteAnimale
            //foreach (var item in animale)
            //{
            //    if(item.Rasa=="Cocos")
            //    {
            //        item.Mananca(item.HranaPreferata);
            //        Console.WriteLine($"Gaina a fost hranita");
            //    }
            //    else if(item.Rasa=="Alba")
            //    {
            //        item.Mananca(item.HranaPreferata);
            //        Console.WriteLine($"Oaia a fost hranita");
            //    }
            //    else 
            //    {
            //        item.Mananca(item.HranaPreferata);
            //        Console.WriteLine($"Vaca a fost hranita");
            //    }
            //}
            #endregion HranesteAnimale

            //3. Colecteaza toate resursele produse de animale (oua, lapte) si afisati totalul cantitatii
            //   colectate pentru fiecare din ele.
            //   Tipurile de resurse vor fi definite folosind IResursa si vor fi puse in folderul
            //   Resurse


            IResursa resursa;
            int CantitateOua = 0;
            int CantitateLalpteOi = 0;
            int CantitateLapteVaci = 0;

            Oua ou = new Oua(2);
            Lapte lapte = new Lapte(10);

            foreach (var item in animale)
            {
                resursa = item.ColecteazaResurse();

                if (item.Rasa == "Cocos")
                {
                    CantitateOua += resursa.Cantitate;

                }
                if (item.Rasa == "Alba")
                {
                    CantitateLalpteOi += resursa.Cantitate;
                }
                if (item.Rasa == "Neagra")
                {
                    CantitateLapteVaci += resursa.Cantitate;
                }
            }

            Console.WriteLine($"Gainile au produs in total {CantitateOua} {ou.UnitateDeMasura} oua");
            Console.WriteLine($"Oile au produs in total {CantitateLalpteOi} {lapte.UnitateDeMasura} de lapte");
            Console.WriteLine($"Vacile au produs in total {CantitateLapteVaci} {lapte.UnitateDeMasura} de lapte");

            //4. Pune animalele la somn. Pentru a ne asigura ca animalele sunt la somn se va 
            // verifica ca fiecare Animal este "AnimalAdormit"- proprietate disponibila pe clasa 
            // animal. 

            Console.ReadLine();
        }
    }
}
