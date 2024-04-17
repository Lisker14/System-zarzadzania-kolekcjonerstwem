using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemZarzadzaniaKolekcjami.Models;
using System.IO;

namespace SystemZarzadzaniaKolekcjami.Services
{
    public class KolekcjeService
    {
        private const string SciezkaDoPliku = "";

        public List<Kolekcja> PobierzKolekcje()
        {
            if (!File.Exists(SciezkaDoPliku))
            {
                File.Create(SciezkaDoPliku).Dispose();
                return new List<Kolekcja>();
            }

            var linie = File.ReadAllLines(SciezkaDoPliku);
            var kolekcje = new List<Kolekcja>();

            foreach (var linia in linie)
            {
                var daneKolekcji = linia.Split(';'); 
                var kolekcja = new Kolekcja
                {
                    Nazwa = daneKolekcji[0],
                    Elementy = new List<ElementKolekcji>()
                };

                for (int i = 1; i < daneKolekcji.Length; i += 2)
                {
                    var element = new ElementKolekcji
                    {
                        Nazwa = daneKolekcji[i],
                        Opis = daneKolekcji[i + 1]
                    };
                    kolekcja.Elementy.Add(element);
                }

                kolekcje.Add(kolekcja);
            }

            return kolekcje;
        }

        public void ZapiszKolekcje(List<Kolekcja> kolekcje)
        {
            var linie = new List<string>();

            foreach (var kolekcja in kolekcje)
            {
                var linia = $"{kolekcja.Nazwa};";
                foreach (var element in kolekcja.Elementy)
                {
                    linia += $"{element.Nazwa};{element.Opis};";
                }
                linie.Add(linia);
            }

            File.WriteAllLines(SciezkaDoPliku, linie);
        }
    }
}

