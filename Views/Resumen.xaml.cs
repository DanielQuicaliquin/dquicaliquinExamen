namespace dquicaliquinExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen(string nombre, string apellido, int edad, DateTime fecha, string pais, string ciudad, double montoInicial, double pagoMensual)
	{
		InitializeComponent();
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad.ToString();
        lblFecha.Text = fecha.ToString("dd/MM/yyyy");
        lblPais.Text = pais;
        lblCiudad.Text = ciudad;
        lblMontoInicial.Text = montoInicial.ToString();
        lblPagoMensual.Text = pagoMensual.ToString();
    }
}