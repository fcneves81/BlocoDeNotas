namespace BlocoDeNotas;

public partial class PaginaNota : ContentPage
{
    string _filename = Path.Combine(FileSystem.AppDataDirectory, "notas.txt");
	public PaginaNota()
	{
		InitializeComponent();
        if (File.Exists(_filename))
        {
            TxtEditor.Text = File.ReadAllText(_filename);
        }
	}

    private void BtnSalvar_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_filename, TxtEditor.Text);
    }

    private void BtnExcluir_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(_filename))
        {
            File.Delete(_filename);
        }
        TxtEditor.Text = string.Empty;

    }
}