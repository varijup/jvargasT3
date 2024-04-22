namespace jvargasT3.Vistas;

public partial class Vnotas : ContentPage
{
    int count = 0;

    public Vnotas(string usuario)
    {
        InitializeComponent();
        Informacion.Text = "Bienvenido "+ usuario;
    }

    private void CalcularButton_Clicked(object sender, EventArgs e)
    {
        // Obtener las notas ingresadas
        int seguimiento1 = int.Parse(seguimiento1Picker.SelectedItem.ToString());
        int examen1 = int.Parse(examen1Picker.SelectedItem.ToString());
        int seguimiento2 = int.Parse(seguimiento2Picker.SelectedItem.ToString());
        int examen2 = int.Parse(examen2Picker.SelectedItem.ToString());

        // Calcular las notas parciales y final
        double notaParcial1 = seguimiento1 * 0.3 + examen1 * 0.2;
        double notaParcial2 = seguimiento2 * 0.3 + examen2 * 0.2;
        double notaFinal = notaParcial1 + notaParcial2;

        // Determinar el estado
        string estado = "";
        if (notaFinal >= 7)
            estado = "APROBADO";
        else if (notaFinal >= 5 && notaFinal <= 6.9)
            estado = "COMPLEMENTARIO";
        else
            estado = "REPROBADO";

        // Mostrar resultados en un Display Alert
        string mensaje = $"Nombre: {estudiantePicker.SelectedItem}\n" +
                         $"Fecha: {fechaPicker.Date.ToShortDateString()}\n" +
                         $"Nota Parcial 1: {notaParcial1}\n" +
                         $"Nota Parcial 2: {notaParcial2}\n" +
                         $"Nota Final: {notaFinal}\n" +
                         $"Estado: {estado}";

        DisplayAlert("Resultados", mensaje, "OK");

    }

}

    