namespace jvargasT3.Vistas;

public partial class Login : ContentPage
{
    // Datos de usuarios y contraseñas
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };

    public Login()
    {
        InitializeComponent();
    }

    private void IniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtContrasena.Text;

        bool usuarioValido = false;

        for (int i = 0; i < users.Length; i++)
        {
            if (usuario == users[i] && contraseña == passwords[i])
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
        {
            DisplayAlert("Bienvenido", $"Bienvenido {usuario}!", "OK");
            Navigation.PushAsync(new Vnotas(usuario));
            // Aquí podrías navegar a la página principal de tu aplicación
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }

    }
}