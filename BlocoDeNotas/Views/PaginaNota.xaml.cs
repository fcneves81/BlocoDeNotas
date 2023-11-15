using BlocoDeNotas.Models;
namespace BlocoDeNotas.Views;

public partial class PaginaNota : ContentPage
{
    // string _filename = Path.Combine(FileSystem.AppDataDirectory, "notas.txt");
        
    public PaginaNota()
	{
		InitializeComponent();
        
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";
        CarregarNota(Path.Combine(appDataPath, randomFileName));
	}

    private void BtnSalvar_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Nota nota)
        {
            File.WriteAllText(nota.NomeDoArquivo, TxtEditor.Text);
        }

        // await Shell.Current.GoToAsync("..");
        
    }

    private void BtnExcluir_Clicked(object sender, EventArgs e)
    {
        
        if (BindingContext is Nota nota)
        {
            if (File.Exists(nota.NomeDoArquivo))
            {
                File.Delete(nota.NomeDoArquivo);
            }
        }
        
        // await Shell.Current.GoToAsync("..");
        
    }

    public void CarregarNota(string _filename)
    {
        Nota nota = new();
        nota.NomeDoArquivo = _filename;

        if (File.Exists(_filename))
        {
            nota.Data = File.GetCreationTime(_filename);
            nota.Texto = File.ReadAllText(_filename);
        }

        BindingContext = nota;
    }
}