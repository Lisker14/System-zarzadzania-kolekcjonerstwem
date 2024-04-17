using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemZarzadzaniaKolekcjami.Services;
using System.Collections.ObjectModel;
using SystemZarzadzaniaKolekcjami.Models;
using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace SystemZarzadzaniaKolekcjami.ViewModels
{
    public class MainPageViewModel
    {
        private readonly KolekcjeService _kolekcjeService;

        public ObservableCollection<Kolekcja> Kolekcje { get; set; }
        public ICommand DodajKolekcjeCommand { get; }

        public MainPageViewModel()
        {
            _kolekcjeService = new KolekcjeService();
            Kolekcje = new ObservableCollection<Kolekcja>(_kolekcjeService.PobierzKolekcje());
            DodajKolekcjeCommand = new Command(DodajKolekcje);
        }

        private void DodajKolekcje()
        {
            var nowaKolekcja = new Kolekcja
            {
                Nazwa = "Nowa kolekcja",
                Elementy = new List<ElementKolekcji>()
            };
            Kolekcje.Add(nowaKolekcja);
        }
    }
}


