namespace dquicaliquinExamen.Views;

public partial class Login : ContentPage
{
    string[,] acceso = {
        {"estudiante2024", "uisrael2024"},
        {"examen1", "parcial1"}
    };

    public Login()
    {
        InitializeComponent();
    }

    private void btnAction_Clicked(object sender, EventArgs e)
    {

        string usuario = this.txtUsuario.Text;
        string contrase�a = this.txtContrase�a.Text;

        bool inicio = false;
        for (int i = 0; i < acceso.GetLength(0); i++)
        {
            if (acceso[i, 0] == usuario && acceso[i, 1] == contrase�a)
            {
                inicio = true;
                break;
            }
        }

        if (inicio)
        {
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o Contrase�a Incorrecta", "Aceptar");
            txtUsuario.Text = "";
            txtContrase�a.Text = "";
        }
    }
}



