using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_telecomando
{
    class Class_termostato
    {
        string produttore;
        string modello;
        string Nserie;
        Class_Caldaia caldaia;

        public Class_termostato(string produttore, string modello, string nserie)
        {
            setProduttore(produttore);
            setModello(modello);
            setNserie(nserie);

        }


        public void Accendi()
        {
            if (caldaia.getStato() == false)
            {
                caldaia.Accendi();
            }
 

        }

        public void Spegni()
        {
            if (caldaia.getStato() == true)
            {
                caldaia.Spegni();
            }

        }

        public void setProduttore(string ilproduttore)
        {
            produttore = ilproduttore;
        }

        public void setModello(string ilmodello)
        {
            modello = ilmodello;
        }
        public string getNserie()
        {
            return Nserie;
        }

        public void setNserie(string ilNserie)
        {
            Nserie = ilNserie;
        }

        public void setModalità(int a)
        {
            caldaia.setModalità(a);
           
        }

        public void setRiscaldamento(int temp)
        {
            caldaia.setRiscaldamento(temp);
        }

        public void setAcqua(int temp)
        {
            caldaia.setAcqua(temp);
        }

        public void setCaldaia(Class_Caldaia lacaldaia)
        {
            caldaia = lacaldaia;
        }

        public string getModalità()
        {
            return caldaia.getMod();
        }

        public string getError()
        {
            return caldaia.getError();
        }


        public Class_Caldaia getCaldaia()
        {
            return caldaia;
        }
    }
}
