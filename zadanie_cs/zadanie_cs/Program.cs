using zadanie_cs;

Ksiazka ksiazka = new(4, 15, "najnowsze wydanie bestsellera new york times");
Elektronika konkuter = new(1, 3999, "opis komputera");
Odziez koszulka = new(15, 99, "rozmiar: amerykanskie M (3XL)");

Klient klient = new("Tomasz", "Hajto");
klient.DodajProdukt(ksiazka);
klient.DodajProdukt(konkuter);
klient.DodajProdukt(koszulka);

Console.WriteLine("cena komputera: " + klient.CenaProduktu(1));
Console.WriteLine("wartosc koszyka: " + klient.WartoscKoszyka());