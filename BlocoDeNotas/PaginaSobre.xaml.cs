namespace BlocoDeNotas;

public partial class PaginaSobre : ContentPage
{
	public PaginaSobre()
	{
		InitializeComponent();
	}

    private async void BtnSobre_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://curriculo-fernando-camargo.web.app/");
    }
}