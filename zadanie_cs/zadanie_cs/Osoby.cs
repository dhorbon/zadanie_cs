using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_cs
{
    public abstract class Osoba
    {
        public string imie, nazwisko;
        public List<IProdukt> koszyk;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            koszyk = new();
        }
        
        public void DodajProdukt(IProdukt produkt)
        {
            if(produkt.DostepnaIlosc() > 0)
            {
                koszyk.Add(produkt);
            }
        }

        public int CenaProduktu(int index)
        {
            return koszyk[index].AktualnaCena();
        }

        public int WartoscKoszyka()
        {
            int wartosc = 0;

            for(int i = 0; i < koszyk.Count; i++)
            {
                wartosc += koszyk[i].AktualnaCena();
            }

            return wartosc;
        }
    }

    public class Klient : Osoba
    {
        public Klient(string imie, string nazwisko) : base(imie, nazwisko) { }
    }
}
