using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZarzadzaniaKolekcjami.Models
{
    public class Kolekcja
    {
        public string Nazwa { get; set; }
        public List<ElementKolekcji> Elementy { get; set; }
    }
}
