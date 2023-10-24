

using System.Data;
using System.Runtime.CompilerServices;

private void btnConfigurarNotificacion_Click(object sender, EvantArgs e);

private void MostrarNotificacion(string mensaje)
{
    MessageBox.Show(mensaje, "Notificación", MessageBoxButton.OK, MessageBoxIccon.Information);
}
{
    DataSetDateTime fechaNotificacion = dateTimePickerFecha.Value;
    string mensajeNotificacion = textBoxMensaje.Text;

    Timer timer = new Timer();
    timer.Interval = (int)(fechaNotificacion - DateTime.Now).TotalMilliseconds;
    timer.Tick += (string, args) =>
    {
        MostrarNotificacion(mensajeNotificacion);
        timer.Stop();
    }
    timer.Start();
}


