using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sorteo
{
    public partial class Participantes : Form
    {
        public Participantes()
        {
            DialogResult = DialogResult.None;
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Participantes_Load(object sender, EventArgs e)
        {

        }

        private void participarBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.conexion);
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;

            string sql = "SELECT * FROM usuarios WHERE nombre = '" + nombreTbx.Text + "' AND clave = aes_encrypt('" + apellidoTbx.Text + "','" + Properties.Settings.Default.key + "')";
            comando.CommandText = sql;
            try
            {
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    if (resultado["privilegio"].ToString() == "1")
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                        

                    }

                }
            }
            catch
            {
                //Vacío...
            }
            finally
            {
                conexion.Close();
            }

            if(DialogResult == DialogResult.OK)
            {
                return;
            }

            string cedula = cedulaTbx.Text.Trim();
            string nombre = nombreTbx.Text.Trim();
            string apellido = apellidoTbx.Text.Trim();
            string telefono = telefonoTbx.Text.Trim();
            if(!String.IsNullOrEmpty(cedula) && !String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(telefono))
            {
                if (Utilities.ValidarCedula(cedula))
                {
                    sql = "INSERT INTO Participantes VALUES('" + cedula + "','" + nombre + "','" + apellido + "','" + telefono+ "')";
                    comando.CommandText = sql;
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se registaron sus datos, ¡Gracias por participar!", "Datos regsitrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nombreTbx.Text = String.Empty;
                        cedulaTbx.Text = String.Empty;
                        apellidoTbx.Text = String.Empty;
                        telefonoTbx.Text = String.Empty;

                    }
                    catch (MySqlException ex)
                    {
                        string texto = "Error " + ex.Number;
                        if (ex.Number == 1062)
                        {
                            texto += ":\n¡La cédula " + cedulaTbx.Text + " ya estaba participando! Ingrese otra cédula ";
                        }
                        MessageBox.Show(texto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conexion.Close();
                    }
                    return;
                }
                MessageBox.Show("La cédula es inválida o no tiene el formato correcto", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            MessageBox.Show("Rellene todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombreTbx_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
