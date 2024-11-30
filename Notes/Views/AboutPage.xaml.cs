namespace Notes.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private async void OpenLink_Tapped(object sender, EventArgs e)
    {
        string url = "https://github.com/Altermanns/Notes.git";
        try
        {
            await Launcher.Default.OpenAsync(url);
        }
        catch (Exception ex)
        {
            // Manejo de errores si no se puede abrir el enlace
            await DisplayAlert("Error", $"No se pudo abrir el enlace: {ex.Message}", "OK");
        }
    }
}
