using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_telecomando
{

    class Class_Caldaia
    {
        string produttore;
        string modello;
        string nserie;
        string datainstall;
        bool stato;
        string modalita;
        int tempRiscaldamento;
        int tempAcqua;
        string error;





        public Class_Caldaia(string ilproduttore, string ilmodello, string ilNserie)
        {
            Produttore = ilproduttore;
            Modello = ilmodello;
            NSerie = ilNserie;
        }

        public string Produttore
        {
            get
            {
                return Produttore;
            }
            set
            {
                if(value != "")
                {
                    produttore = value;
                }
            }
        }
        public string Modello
        {
            get {return modello;}
            set
            {
                if (value != "")
                {
                    modello = value;
                }
            }
        }

        public string NSerie
        {
            get
            {
                return nserie;
            }
            set
            {
                if (value != "")
                {
                    nserie = value;
                }
            }
        }

        public string Datainstall
        {
            get
            {
                return datainstall;
            }
            set
            {
                if (value != "")
                {
                    datainstall = value;
                }
            }
        }

        public bool Stato { get; set; }

        public string Modalita
        {
            get
            {
                return modalita;
            }
            set
            {
                if (value != "")
                {
                    modalita = value;
                }

            }
        }

        public int TempRiscaldamento
        {
            get
            {
                return tempRiscaldamento;
            }
            set
            {
                if (value >= 0 || value <= 100)
                    tempRiscaldamento = value;
            }
        }
        public int TempAcqua
        {
            get
            {
                return tempAcqua;
            }
            set
            {
                if (value >= 0 || value <= 100)
                    tempAcqua = value;
            }
        }

        public string Error { get; }
        public void Accendi()
        {
            if (stato == false)
            {
                stato = true;
            }
            else
            {
                error = "Caldaia già attiva";
            }
            
        }

        public void Spegni()
        {
            if (stato == true)
            {
                stato = false;
            }
            else
            {
                error = "Caldaia già spenta";
            }
        }

       

    }


}
