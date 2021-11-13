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
    public class TipoController
    {
        TiposView vista;
        TipoDAO tipoDAO = new TipoDAO();
        Tipo tipo = new Tipo();
        string operacion = string.Empty;

        public TipoController(TiposView view)
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
            if (vista.SoporteTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.SoporteTextBox, "Ingrese la soporte");
                vista.SoporteTextBox.Focus();
            }
            try
            {
                tipo.Soporte = vista.SoporteTextBox.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = tipoDAO.InsertarSoporte(tipo);

                    if (inserto)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("Soporte creado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Soporte NO creado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (operacion == "Modificar")
                {
                    tipo.Id = Convert.ToInt32(vista.IdTextBox.Text);
                    bool modifico = tipoDAO.ActulizarSoporte(tipo);

                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("El soporte ha sido modificado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Soporte NO modificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (vista.TipoDataGridView.SelectedRows.Count > 0)
            {
                HabilitarControles();
                operacion = "Modificar";

                vista.IdTextBox.Text = vista.TipoDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.SoporteTextBox.Text = vista.TipoDataGridView.CurrentRow.Cells["SOPORTE"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.TipoDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = tipoDAO.EliminarSoporte(Convert.ToInt32(vista.TipoDataGridView.CurrentRow.Cells["ID"].Value));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    MessageBox.Show("Soporte eliminado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("Soporte NO eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListarClientes()
        {
            vista.TipoDataGridView.DataSource = tipoDAO.GetSoporte();
        }

        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            tipo = null;
        }

        private void Nuevo(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            vista.SoporteTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }

        private void DeshabilitarControles()
        {
            vista.SoporteTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;

        }

        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.SoporteTextBox.Clear();
        }
    }
}
