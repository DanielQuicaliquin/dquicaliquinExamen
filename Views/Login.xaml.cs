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
        string contraseña = this.txtContraseña.Text;

        bool inicio = false;
        for (int i = 0; i < acceso.GetLength(0); i++)
        {
            if (acceso[i, 0] == usuario && acceso[i, 1] == contraseña)
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
            DisplayAlert("Alerta", "Usuario o Contraseña Incorrecta", "Aceptar");
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
    }
}



