namespace jvargasT3.Vistas;

public partial class Login : ContentPage
{
    // Datos de usuarios y contrase�as
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };

    public Login()
    {
        InitializeComponent();
    }

    private void IniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrasena.Text;

        bool usuarioValido = false;

        for (int i = 0; i < users.Length; i++)
        {
            if (usuario == users[i] && contrase�a == passwords[i])
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
        {
            DisplayAlert("Bienvenido", $"Bienvenido {usuario}!", "OK");
            Navigation.PushAsync(new Vnotas(usuario));
            // Aqu� podr�as navegar a la p�gina principal de tu aplicaci�n
        }
        else
        {
            DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }

    }
}