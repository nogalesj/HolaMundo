namespace HolaMundo
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Recuperar los dos textos introducidos por el usuario
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Regex: al menos una mayúscula, una minúscula,
            // un número y un símbolo
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^A-Za-z0-9]).+$";

            // Primera validación: comprobar la estructura de la contraseña
            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show(
                    "La contraseña debe contener al menos una letra mayúscula, una letra minúscula, un número y un símbolo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Segunda validación: comprobar que las dos contraseñas sean iguales
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Si las dos validaciones son correctas
            MessageBox.Show(
                "La contraseña ha sido validada",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
