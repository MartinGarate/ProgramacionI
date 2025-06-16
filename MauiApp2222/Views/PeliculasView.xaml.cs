using MauiApp2222.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace MauiApp2222.Views;

public partial class PeliculasView : ContentPage
{
    //Creamos campos / propiedades
    HttpClient clientHttp = new HttpClient();
    string url = "https://netflisp-77fe.restdb.io/rest/peliculas?apikey=7e3b2f3b47495345da5617567d822a55dfd7f";
    ObservableCollection<Pelicula> peliculas;

    public PeliculasView()
	{
		InitializeComponent();
		TituloLabel.Text = "Hola mundo";
        ObtenemosPeliculas();
    }

    private async void ObtenemosPeliculas()
    {
        var response = await clientHttp.GetAsync(url);
        if (response != null)
        {
            peliculas = await response.Content.ReadFromJsonAsync<ObservableCollection<Pelicula>>();
            PeliculasListView.ItemsSource = peliculas;
        }
    }

}