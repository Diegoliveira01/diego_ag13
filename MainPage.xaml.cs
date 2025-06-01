using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobrePage());
        }

        private void OnAdicionarAdulto(object sender, EventArgs e)
        {
            int valorAtual = int.TryParse(adultosEntry.Text, out int result) ? result : 0;
            valorAtual++;
            adultosEntry.Text = valorAtual.ToString();
        }

        private void OnRemoverAdulto(object sender, EventArgs e)
        {
            int valorAtual = int.TryParse(adultosEntry.Text, out int result) ? result : 0;
            valorAtual = Math.Max(0, valorAtual - 1);
            adultosEntry.Text = valorAtual.ToString();
        }

        private void OnAdicionarCrianca(object sender, EventArgs e)
        {
            int valorAtual = int.TryParse(criancasEntry.Text, out int result) ? result : 0;
            valorAtual++;
            criancasEntry.Text = valorAtual.ToString();
        }

        private void OnRemoverCrianca(object sender, EventArgs e)
        {
            int valorAtual = int.TryParse(criancasEntry.Text, out int result) ? result : 0;
            valorAtual = Math.Max(0, valorAtual - 1);
            criancasEntry.Text = valorAtual.ToString();
        }
    }
}
