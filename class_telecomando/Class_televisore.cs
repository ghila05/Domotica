using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_telecomando
{
    internal class Class_televisore
    {

        private bool stato = false;
        private int Volume;
        private string produttore;
        private string modello;
        private int canale;
        private string[] connettori;

        private float _prezzo

        public float Prezzo
        {
            get
            {
                return prezzo; // introdizione ai set e get automatici
            }
            set
            {
                if(value >0)
                _prezzo = value;
            }

            
        }
        

        public Class_televisore()
        { //costruttore, possiamo avere più tipi di costruttori che prendono in ingresso diverse variabili 
            produttore = "";
            modello = "";


        }

        //i costruttori si distiniguono anche se hanno lo stesso nome "TV" dato che prendono in ingresso diverse variabili 

        public Class_televisore(string ilproduttore, string ilmodello)
        { //costruttore, N.B:il nome del metodo "costruttore" DEVE  avere lo stesso nome della classe 
            produttore = ilproduttore;
            modello = ilmodello;
            // NON RITORNA NULLA
        }

        public void AlzaVol()
        {
            if (Volume == 100)
            {
                throw new Exception("max volume");
            }

            Volume++;

        }
        public void AbbassaVol()
        {
            if (Volume == 0)
            {
                throw new Exception("min volume");
            }
            Volume--;
        }

      
        public void accendi()
        {
            stato = true;
        }

        public void spegni()
        {
            stato = false;
        }

        public void CambiaCanale(int Newcanale)
        {
            canale = Newcanale;
        }



        public string getProduttore()
        {
            return produttore;
        }

        public string getModello()
        {
            return modello;
        }

        public int getCanale()
        {
            return canale;
        }
        public int getVolume()
        {
            return Volume;
        }

        public void setStato(bool nuovostato)
        {
            bool stato = nuovostato;
        }
      
        public bool getStato()
        {
            return stato;
        }
        public void setProduttore(string ilproduttore)
        {
            string produttore = ilproduttore;
        }
        public void setModello(string ilmodello)
        {
            string modello = ilmodello;
        }


    }
}
