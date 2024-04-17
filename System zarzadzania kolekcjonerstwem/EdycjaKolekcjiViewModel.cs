using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemZarzadzaniaKolekcjami.Models;
using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace SystemZarzadzaniaKolekcjami.ViewModels
{
    public class EdycjaKolekcjiViewModel
    {
        public Kolekcja AktualnaKolekcja { get; set; }
        public ICommand ZapiszElementCommand { get; }
        public ICommand UsunElementCommand { get; }

        public EdycjaKolekcjiViewModel()
        {
            ZapiszElementCommand = new Command(ZapiszElement);
            UsunElementCommand = new Command(UsunElement);
        }

        private void ZapiszElement()
        {
        }

        private void UsunElement()
        {
        }
    }
}
