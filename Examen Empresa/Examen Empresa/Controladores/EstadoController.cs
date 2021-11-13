using Examen_Empresa.Modelos.DAO;
using Examen_Empresa.Modelos.Entidades;
using Examen_Empresa.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Empresa.Controladores
{
    public class EstadoController
    {
        EstadoView vista;
        EstadoDAO estadoDAO = new EstadoDAO();
        Estado estado = new Estado();
        string operacion = string.Empty;

        public EstadoController(EstadoView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
            vista.ModificarButton.Click += new EventHandler(Modificar);
            vista.Load += new EventHandler(Load);
            vista.EliminarButton.Click += new EventHandler(Eliminar);
            vista.CancelarButton.Click += new EventHandler(Cancelar);
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (vista.EstadoTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EstadoTextBox, "Ingrese la estado de su ticket");
                vista.EstadoTextBox.Focus();
            }
            vista.EstadoTextBox.Text.ToUpper();
            if (vista.EstadoTextBox.Text != "SIN RESOLVER" || vista.EstadoTextBox.Text != "ABIERTO" || vista.EstadoTextBox.Text != "CERRADO" || vista.EstadoTextBox.Text != "EN ESPERA")
            {
                
            }
            else
            {
                MessageBox.Show("Debe ingresar los parametros 'Sin resolver' 'Abierto' 'En espera' o 'Cerrado'");
            }
            try
            {
                estado.Estados = vista.EstadoTextBox.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = estadoDAO.InsertarEstado(estado);

                    if (inserto)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("Estado creado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Estado NO creado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (operacion == "Modificar")
                {
                    estado.Id = Convert.ToInt32(vista.IdTextBox.Text);
                    bool modifico = estadoDAO.ActulizarEstado(estado);

                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("El estado ha sido modificado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Estado NO modificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            if (vista.EstadoDataGridView.SelectedRows.Count > 0)
            {
                HabilitarControles();
                operacion = "Modificar";

                vista.IdTextBox.Text = vista.EstadoDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.EstadoTextBox.Text = vista.EstadoDataGridView.CurrentRow.Cells["ESTADO"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.EstadoDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = estadoDAO.EliminarEstado(Convert.ToInt32(vista.EstadoDataGridView.CurrentRow.Cells["ID"].Value));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    MessageBox.Show("Estado eliminado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("Estado NO eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListarClientes()
        {
            vista.EstadoDataGridView.DataSource = estadoDAO.GetEstado();
        }

        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void Nuevo(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            estado = null;
        }

        private void HabilitarControles()
        {
            vista.EstadoTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }

        private void DeshabilitarControles()
        {
            vista.EstadoTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;

        }

        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.EstadoTextBox.Clear();
        }
    }
}
