using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using avaliacao2703.Models;
using avaliacao2703.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace avaliacao2703.ViewModels
{
    public partial class DadoViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _dadovalue;

        [ObservableProperty]
        private int _numerolados;

        public ICommand Rolarcommand { get; }

        public void Rolar()
        {
            Dado dado = new Dado(Numerolados);
            dado.Rolar();
            Dadovalue = dado.NumeroSorteado;
        }

        public DadoViewModel()
        {
            Rolarcommand = new Command(Rolar);
        }
    }
}
