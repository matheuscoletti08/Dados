
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

        }
    }



