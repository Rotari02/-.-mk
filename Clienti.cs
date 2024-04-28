using System;
using System.Collections.Generic;

namespace Abonați_telefonici
{
    [Serializable]
    public class Clienti:ICloneable
    {
        private string numeClient;
        private string adresa;
        private string numarTelefon;

        public Clienti()
        {
            this.numeClient = "";
            this.adresa = "";
            this.numarTelefon = "";
        }

        public Clienti(string numeClient, string adresa, string numarTelefon)
        {
            this.numeClient = numeClient;
            this.adresa = adresa;
            this.numarTelefon = numarTelefon;
        }

        public string NumeClient { get => numeClient; set => numeClient = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string NumarTelefon { get => numarTelefon; set => numarTelefon = value; }

        public override string ToString()
        {
            string rezultat = "Clientul " + numeClient + " cu adresa " + adresa + " are numărul de telefon " + numarTelefon;
            return rezultat;
        }

        public object Clone()
        {
            Clienti clona = (Clienti)this.MemberwiseClone();
            return clona;
        }

        // Supraincarcarea operatorului ==
        public static bool operator ==(Clienti client1, Clienti client2)
        {
            if (ReferenceEquals(client1, client2))
                return true;

            if (client1 is null || client2 is null)
                return false;

            return client1.NumeClient == client2.NumeClient &&
                   client1.Adresa == client2.Adresa &&
                   client1.NumarTelefon == client2.NumarTelefon;
        }
        // Supraincarcarea operatorului !=
        public static bool operator !=(Clienti client1, Clienti client2)
        {
            return !(client1 == client2);
        }
    
    }
}
