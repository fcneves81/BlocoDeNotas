namespace BlocoDeNotas.Views;

public partial class PaginaSobre : ContentPage
{
	public PaginaSobre()
	{
		InitializeComponent();
	}

    private async void BtnSobre_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Sobre sobre)
        { 
        await Launcher.Default.OpenAsync(sobre.MaisInformacoesUrl);
        }
    }
}