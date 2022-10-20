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
        string Nserie;
        string Datainstall;
        bool stato;
        string modalità;
        int TempRiscaldamento;
        int TempAcqua;
        string error;



 

        public Class_Caldaia(string ilproduttore, string ilmodello, string ilNserie)
        {
            setProduttore(ilproduttore);
            setModello(ilmodello);
            setNserie(ilNserie);
            
        }

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

        public void setModalità(int mod)
        {
            if (mod == 1)
            {
                Modalità = "acqua sanitaria e riscaldamento";
            }
            else if (mod == 0)
            {
                Modalità = "acqua sanitaria";
            }
        }
      
        public void setRiscaldamento(int temp)
        {
            if (temp > 0 && temp < 30)
            {
                TempRiscaldamento = temp;
            }
            else
            {
                error = "temperatura non rispetta i criteri >0 e <40"; 
            }

            
        }

        public void setAcqua(int temp)
        {
            if (temp > 0 && temp < 60)
            {
                TempAcqua = temp;
            }
        }
        
        private void setProduttore(string ilproduttore)
        {
            produttore = ilproduttore;
        }
        
        private void setModello(string ilmodello)
        {
            modello = ilmodello;
        }

        private void setNserie(string ilNserie)
        {
            Nserie = ilNserie;
        }

        public bool getStato()
        {
            return stato;
        }
        public string getModello()
        {
            return modello;
        }
        public string getNserie()
        {
            return Nserie;
        }

        public string getDatainstall()
        {
            return Datainstall;
        }

        public string getMod()
        {
            return Modalità;
        }

        public int getRiscaldamento()
        {
            return TempRiscaldamento;
        }

        public int getAcqua()
        {
            return TempAcqua;
        }

        public string getError()
        {
            return error;
        }

    }


}
