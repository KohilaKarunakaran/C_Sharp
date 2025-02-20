using OpintoJaksotApp;
using System;
using System.Collections.Generic;

// Luodaan opettajat
Opettaja opettaja1 = new Opettaja("Minna Meronen");
Opettaja opettaja2 = new Opettaja("Ritva Koistila");
Opettaja opettaja3 = new Opettaja("Mikä Korhonen");
Opettaja opettaja4 = new Opettaja("Jenni Vanhanen");

// Luodaan opintojaksot ja lisätään opettajat
Opintojakso algebra = new Opintojakso("Algebra");
algebra.LisääOpettaja(opettaja1);

Opintojakso ohjelmointi = new Opintojakso("Ohjelmointi");
ohjelmointi.LisääOpettaja(opettaja2);


Opintojakso tietokannat = new Opintojakso("Tietokannat ja SQL");
tietokannat.LisääOpettaja(opettaja3);

Opintojakso englanti = new Opintojakso("Englanti");
englanti.LisääOpettaja(opettaja4);

// Luodaan opiskelijat ja lisätään heille opintojaksot
Opiskelija opiskelija1 = new Opiskelija("Tero Terävä");
opiskelija1.LisääOpintojakso(algebra);
opiskelija1.LisääOpintojakso(ohjelmointi);

Opiskelija opiskelija2 = new Opiskelija("Maija Mallikas");
opiskelija2.LisääOpintojakso(ohjelmointi);
opiskelija2.LisääOpintojakso(tietokannat);

Opiskelija opiskelija3 = new Opiskelija("Sakari Mironen");
opiskelija3.LisääOpintojakso(englanti);

Opiskelija opiskelija4 = new Opiskelija("Hanna Hyttynen");
opiskelija4.LisääOpintojakso(tietokannat);
opiskelija4.LisääOpintojakso(algebra);

// Tallennetaan opiskelijat listaan
List<Opiskelija> opiskelijat = new List<Opiskelija> { opiskelija1, opiskelija2, opiskelija3, opiskelija4 };

// Listataan opiskelijoiden nimet
Console.WriteLine("Opiskelijat:");
foreach (var opiskelija in opiskelijat)
{
    Console.WriteLine(opiskelija.Nimi);
}

// 6️⃣ Käyttäjän syöte ja tietojen tulostus
Console.Write("\nAnna opiskelijan nimi: ");
string nimi = Console.ReadLine();

Opiskelija valittuOpiskelija = opiskelijat.Find(o => o.Nimi.Equals(nimi, StringComparison.OrdinalIgnoreCase));

if (valittuOpiskelija != null)
{
    Console.WriteLine("\n" + valittuOpiskelija);
}
else
{
    Console.WriteLine("\nOpiskelijaa ei löytynyt.");
}
