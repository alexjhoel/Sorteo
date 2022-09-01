using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            RecargarTabla(false);
        }

        private void RecargarTabla(bool random, string filtro = "")
        {
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.conexion);
            conexion.Open();
            string sql = "SELECT cedula as Cédula, nombre as Nombre, apellido as Apellido, telefono as Teléfono FROM participantes " + filtro;
            if (random) sql += " ORDER BY RAND() LIMIT 1";
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    tablaDgv.DataSource = ds.Tables[0];
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

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("CONFIRMAR BORRAR TODAS LAS ENTRADAS", "CONFIRMAR LIMPIAR", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) != DialogResult.Yes)
            {
                return;
            }
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.conexion);
            string sql = "DELETE FROM Participantes";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                nombreTbx.Text = String.Empty;
                cedulaTbx.Text = String.Empty;
                apellidoTbx.Text = String.Empty;
                telefonoTbx.Text = String.Empty;

            }
            catch (MySqlException ex)
            {
                

            }
            finally
            {

                conexion.Close();
                
            }
            RecargarTabla(false);
            return;
        }

        private void sortearBtn_Click(object sender, EventArgs e)
        {
            RecargarTabla(true);
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string where = "WHERE";
            string nombre = nombreTbx.Text.Trim();
            string cedula = cedulaTbx.Text.Trim();
            string apellido = apellidoTbx.Text.Trim();
            string telefono = telefonoTbx.Text.Trim();

            if (!String.IsNullOrEmpty(cedula)) where += " cedula= '" + cedula + "' AND";
            if (!String.IsNullOrEmpty(nombre)) where += " nombre= '" + nombre + "' AND";
            if (!String.IsNullOrEmpty(apellido)) where += " apellido= '" + apellido + "' AND";
            if (!String.IsNullOrEmpty(telefono)) where += " telefono= '" + telefono + "' AND";
            where += " 1=1 ";

            RecargarTabla(false, where);

        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar borrar", "Confirmar borrar la entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) != DialogResult.Yes)
            {
                return;
            }
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.conexion);
            string sql = "DELETE FROM Participantes WHERE cedula= " + tablaDgv.SelectedRows[0].Cells[0].Value;
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {


            }
            finally
            {

                conexion.Close();

            }
            RecargarTabla(false);
            return;
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            string cedula = cedulaTbx.Text.Trim();
            string nombre = nombreTbx.Text.Trim();
            string apellido = apellidoTbx.Text.Trim();
            string telefono = telefonoTbx.Text.Trim();
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.conexion);
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            if (!String.IsNullOrEmpty(cedula) && !String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(telefono))
            {
                if (Utilities.ValidarCedula(cedula))
                {
                    string sql = "INSERT INTO Participantes VALUES('" + cedula + "','" + nombre + "','" + apellido + "','" + telefono + "')";
                    comando.CommandText = sql;

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se registaron sus datos", "Datos regsitrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            texto += ":\n¡La cédula " + cedulaTbx.Text + " ya estaba participando!";
                        }
                        MessageBox.Show(texto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conexion.Close();
                    }
                    RecargarTabla(false);
                    return;
                }
                MessageBox.Show("La cédula es inválida o no tiene el formato correcto", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Rellene todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void coparBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCellCollection datos = tablaDgv.SelectedRows[0].Cells;
                Clipboard.SetText(datos[1].Value + " " + datos[2].Value + " Cédula: " + datos[0].Value + " Teléfono: " + datos[3].Value);
                MessageBox.Show("Copiado!");
            }
            catch
            {

            }
            
        }
    }
    
}
