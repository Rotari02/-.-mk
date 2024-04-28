using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonați_telefonici
{
    public class TipAbonament: ExtraOptiuni2, ICloneable
    {
        private string numeAbonament;
        private double pretAbonament;
        private int minuteIncluse;
        private int traficDateInclus;
        private int smsIncluse;

        public TipAbonament():base()
        {
            this.numeAbonament = "Necunoscut";
            this.pretAbonament = 0.0f;
            this.minuteIncluse = 0;
            this.traficDateInclus = 0;
            this.smsIncluse = 0;
        }

        public TipAbonament(string numeAbonament, double pretAbonament, int minuteIncluse, int traficDateInclus, int smsIncluse,int min,int roaming) : base(min,roaming)
        {
            this.numeAbonament = numeAbonament;
            this.pretAbonament = pretAbonament;
            this.minuteIncluse = minuteIncluse;
            this.traficDateInclus = traficDateInclus;
            this.smsIncluse = smsIncluse;
        }

        public string NumeAbonament { get => numeAbonament; set => numeAbonament = value; }
        public double PretAbonament { get => pretAbonament; set => pretAbonament = value; }
        public int MinuteIncluse { get => minuteIncluse; set => minuteIncluse = value; }
        public int TraficDateInclus { get => traficDateInclus; set => traficDateInclus = value; }
        public int SmsIncluse { get => smsIncluse; set => smsIncluse = value; }

        public override string alegeTipAbonament()
        {
            return numeAbonament;
        }

        public object Clone()
        {
            TipAbonament clona = (TipAbonament)this.MemberwiseClone();
            return clona;
        }
        public override string ToString()
        {
            string rezultat;
            rezultat = base.ToString() + ", are numele abonamentului " + numeAbonament + ", prețul de " + pretAbonament + " lei și include "
                + minuteIncluse + " minute, " + traficDateInclus + " MB trafic de date și " + smsIncluse + " SMS-uri incluse.";
            return rezultat;
        }


        public string RedareDetalii()
        {
            return "Abonament: " + numeAbonament + ", preț: " + pretAbonament + " lei, minute incluse: " + minuteIncluse + ", trafic date inclus: " + traficDateInclus + " MB, SMS-uri incluse: " + smsIncluse;
        }

    }
}

