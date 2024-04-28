using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Abonați_telefonici
{
    public class Plati : ICloneable, IComparable<Plati>
    {
        private int idPlata;
        private float sumaPlata;
        private DateTime dataPlata;

        public Plati()
        {
            this.idPlata = 1;
            this.sumaPlata = 0;
            this.dataPlata = DateTime.Now;
        }

        public Plati(int idPlata, float sumaPlata, DateTime dataPlata)
        {
            this.idPlata = idPlata;
            this.sumaPlata = sumaPlata;
            this.dataPlata = dataPlata;
        }

        public int IdPlata { get => idPlata; set => idPlata = value; }
        public float SumaPlata { get => sumaPlata; set => sumaPlata = value; }
        public DateTime DataPlata { get => dataPlata; set => dataPlata = value; }

        public override string ToString()
        {
            string rezultat = "Plata cu ID-ul " + idPlata + " are suma de plata" + sumaPlata + " si data platii " + dataPlata;
            return rezultat;
        }
        public object Clone()
        {
            Plati clona = (Plati)this.MemberwiseClone();
            return clona;
        }
        public float CalculeazaValoarePlata()
        {
            int anulPlatii = this.DataPlata.Year;
            if (anulPlatii < 2020)// Dacă plata s-a efectuat înainte de 2020, nu se aplică niciun ajustament
            {
                return sumaPlata;
            }
            else
            {
                return sumaPlata * 1.05f; // Pentru plățile efectuate după 2020, se aplică un ajustament de 5%
            }
        }
        public int CompareTo(Plati other)
        {
            if (this.SumaPlata < other.SumaPlata)
                return -1;
            else if (this.sumaPlata > other.SumaPlata)
                return 1;
            else return 0;

        }

        //Supraincarcarea operatorului '+' pentru adunarea a doua obiecte de tipul Plati:
        public static Plati operator +(Plati p1, Plati p2)
        {
            return new Plati(p1.IdPlata + p2.IdPlata, p1.SumaPlata + p2.SumaPlata, p1.DataPlata);
        }

        //Supraincarcarea operatorului '*' pentru inmultirea unei plati cu un scalar:
        public static Plati operator *(Plati p, float scalar)
        {
            return new Plati(p.IdPlata, p.SumaPlata * scalar, p.DataPlata);
        }



        // Supraincarcarea operatorului de comparare '==' pentru compararea a doua obiecte de tipul Plati(comparare dupa id-ul platii):
        public static bool operator ==(Plati p1, Plati p2)
        {
            return p1.IdPlata == p2.IdPlata;
        }

        public static bool operator !=(Plati p1, Plati p2)
        {
            return !(p1 == p2);
        }


    }
}

