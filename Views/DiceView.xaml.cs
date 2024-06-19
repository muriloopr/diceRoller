
using System;
using avaliacao2703.Models;
using avaliacao2703.ViewModels;
using Microsoft.Maui.Controls;

namespace avaliacao2703.Views
{
    public partial class DiceView : ContentPage
    {
        int numeroAleatorio = 0;

        public DiceView()
        {
            InitializeComponent();
            BindingContext = new DadoViewModel();
        }

        private void SliderDado_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Atualiza o valor do Label com o valor do Slider
            valueTextBlock.Text = e.NewValue.ToString("F0");
        }
    }
}



