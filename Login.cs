using MySql.Data.MySqlClient;
using System.Configuration;

namespace Sorteo
{
    public partial class Login : Form
    {
        Participantes participantesFrm;
        Admin adminFrm;
        public Login()
        {
            InitializeComponent();
            
        }
        private void ingresarBtn_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.conexion);
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            string sql = "SELECT * FROM usuarios WHERE nombre = '" + usuarioTbx.Text + "' AND clave = aes_encrypt('" + contraseniaTbx.Text + "','" + Properties.Settings.Default.key + "')";
            comando.CommandText = sql;
            try
            {
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    usuarioTbx.Text = String.Empty;
                    contraseniaTbx.Text = String.Empty;
                    if (resultado["privilegio"].ToString() == "1")
                    {
                        participantesFrm = new Participantes();
                        participantesFrm.FormClosing += ParticipantesFrm_FormClosing;
                        participantesFrm.Show();

                    }
                    else if(resultado["privilegio"].ToString() == "0")
                    {
                        adminFrm = new Admin();
                        adminFrm.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }



        }

        private void AdminFrm_FormClosing(object? sender, FormClosingEventArgs e)
        {
        }

        private void ParticipantesFrm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //Previene que cierren la aplicación con ALTF4
            e.Cancel = (participantesFrm.DialogResult != DialogResult.OK);
        }

    }
}