using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_telecomando
{
    internal class Class_telecomando
    {
        private string Produttore;
        private string Modello;
        private string Modalità;
        private bool Stato = false;
        private int Canale;
        private int Volume;

        public Class_telecomando(string ilproduttore, string ilmodello)
        {
            Produttore = ilproduttore;
            Modello = ilmodello;
        }

        public void accendi()
        {
            if (Stato == false)
            {
                Stato = true;
            }
            
        }

        public void spegni()
        {
            if (Stato == true)
            {
                Stato = false;
            }
        }

        public void AlzaVolume()
        {
            if(Volume == 100)
            {
                throw new Exception("max volume");
            }
            Volume++;

        }

        public void AbbassaVolume()
        {
            if (Volume == 0)
            {
                throw new Exception("min volume");
            }
            Volume--;
        }
        public void CambiaCanale(int Newcanale)
        {
            Canale = Newcanale;
        }

        public int getVolume()
        {
            return Volume;
        }
        public string getProduttore()
        {
            return Produttore;
        }

        public string getModello()
        {
            return Modello;
        }

        public int getCanale()
        {
            return Canale;
        }

        


    }
}
