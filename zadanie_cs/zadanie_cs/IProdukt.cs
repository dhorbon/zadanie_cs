using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_cs
{
    public interface IProdukt
    {
        public void WyswietlInfo();
        public int AktualnaCena();
        public int DostepnaIlosc();
    }
}
