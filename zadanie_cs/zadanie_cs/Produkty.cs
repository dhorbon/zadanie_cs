using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_cs
{
    public class Produkt : IProdukt
    {
        public int ilosc, cena;
        string info;

        public Produkt(int ilosc, int cena , string info)
        {
            this.ilosc = ilosc;
            this.cena = cena;
            this.info = info;
        }
        
        public void WyswietlInfo() { Console.Write(info); }
        public int AktualnaCena() { return cena; }
        public int DostepnaIlosc() { return ilosc; }
    }

    public class Ksiazka : Produkt
    {
        public Ksiazka(int ilosc, int cena, string info) : base(ilosc, cena, info) { }
    }

    public class Elektronika : Produkt
    {
        public Elektronika(int ilosc, int cena, string info) : base(ilosc, cena, info) { }
    }

    public class Odziez : Produkt
    {
        public Odziez(int ilosc, int cena, string info) : base(ilosc, cena, info) { }
    }
}