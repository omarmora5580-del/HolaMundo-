using System.Text.RegularExpressions;

namespace HolaMundo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    // Este evento se ejecuta cuando se presiona el botón.
    private void BtnValidar_Click(object sender, EventArgs e)
        {
            // Obtenemos la contraseña del primer campo.
            string contraseña = txtContraseña4.Text;

            // Obtenemos la contraseña del segundo campo.
            string confirmarContraseña = txtConfirmarContraseña4.Text;

            // Expresión regular para validar la contraseña.
            // Debe contener una mayúscula, una minúscula,
            // un número y un símbolo.
            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z\d]).{8,}$";

            // Comprobamos si la contraseña cumple las reglas.
            bool contraseñaValida = Regex.IsMatch(contraseña, patron);

            // Si no cumple las reglas, mostramos un mensaje.
            if (!contraseñaValida)
            {
                MessageBox.Show(
                    "La contraseña debe contener al menos una letra mayúscula, " +
                    "una letra minúscula, un número y un símbolo.",
                    "Contraseña no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Comprobamos que las dos contraseñas sean iguales.
            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Si todo es correcto, mostramos el mensaje solicitado.
            MessageBox.Show(
                "La contraseña ha sido validada",
                "Validación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }

}
