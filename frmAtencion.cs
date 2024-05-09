﻿using Clinica.Datos;
using Clinica.Entidades;
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


namespace clinica
{
    public partial class frmAtencion : Form
    {
        private Form formOrigen;
        public frmAtencion(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }

        private void frmAtencion_Load(object sender, EventArgs e)
        {
            CargarLugares();
            CargarEspera(-1);
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            formOrigen.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void CargarLugares()
        {
            cbxLugar.DataSource = null;
            cbxLugar.Items.Clear();
            cbxLugar.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select LugarDeAtencion.id, LugarDeAtencion.Descripcion " +
                    $"from LugarDeAtencion;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> lugares = new();

                    while (reader.Read())
                    {
                        // Obtener el ID y el nombre de la cobertura
                        int id = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);

                        // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                        KeyValuePair<int, string> lugar = new(id, descripcion);
                        lugares.Add(lugar);

                    }

                    cbxLugar.DataSource = lugares;
                    // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox 
                    cbxLugar.DisplayMember = "Value";
                    cbxLugar.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de Lugares");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void cbxLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLugar.SelectedIndex != -1)
            {
                CargarEspera(((KeyValuePair<int, string>)cbxLugar.SelectedItem!).Key);
            }
        }

        private void CargarEspera(int idLugar)
        {
            lbxEnEspera.DataSource = null;
            lbxEnEspera.Items.Clear();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {

                string query = "Select SalaDeEspera.FechaHoraAcreditacion, SalaDeEspera.Paciente_id, " +
                    "Paciente.Apellido, Paciente.Nombre, SalaDeEspera.Estudio_id, Estudio.Descripcion, " +
                    "SalaDeEspera.LugarDeAtencion_id, LugarDeAtencion.Descripcion, SalaDeEspera.Prioridad," +
                    "SalaDeEspera.id " +
                    "from saladeespera inner join Paciente on Paciente.id = SalaDeEspera.Paciente_id " +
                    "inner join LugarDeAtencion on lugardeatencion.id = saladeespera.LugarDeAtencion_id " +
                    "inner join Estudio on Estudio.id = saladeespera.Estudio_id " +
                    $"where saladeespera.LugarDeAtencion_id = {idLugar} ";


                query += " ORDER BY SalaDeEspera.Prioridad, SalaDeEspera.FechaHoraAcreditacion;";

                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> esperas = new();

                    while (reader.Read())
                    {

                        string fecha = reader.GetDateTime(0).ToString();
                        int pacienteId = reader.GetInt32(1);
                        string pacienteApellido = reader.GetString(2);
                        string pacienteNombre = reader.GetString(3);
                        string estudioDescripcion = reader.GetString(5);
                        string lugarDescripcion = reader.GetString(7);
                        int prioridad = reader.GetInt32(8);
                        int id = reader.GetInt32(9);


                        string esperaDescripcion = $"{pacienteApellido}, {pacienteNombre} - " +
                            $"{estudioDescripcion} - {fecha} - {prioridad}";

                        KeyValuePair<int, string> espera = new(pacienteId, esperaDescripcion);
                        esperas.Add(espera);

                    }

                    lbxEnEspera.DataSource = esperas;
                    lbxEnEspera.DisplayMember = "Value";
                    lbxEnEspera.SelectedIndex = 0;
                    lbxEnEspera.Enabled = true;

                }
                else
                {
                    lbxEnEspera.DataSource = null;
                    lbxEnEspera.Items.Clear();
                    lbxEnEspera.Items.Add("No hay datos disponibles con los criterios seleccionados.");
                    lbxEnEspera.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void lbxEnEspera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxEnEspera.SelectedIndex != -1)
            {
                KeyValuePair<int, string> espera = (KeyValuePair<int, string>)lbxEnEspera.SelectedItem!;
                int pacienteId = espera.Key;
                string? historiaClinica = Clinica.Clinica.ObtenerHistoriaClinica(pacienteId);
                if (historiaClinica != null)
                {
                    rtxtHistoriaClinica.Text = historiaClinica;
                }
                else
                {
                    rtxtHistoriaClinica.Text = "No hay historia clínica para este paciente.";
                }
            }   
        }
    }


}
