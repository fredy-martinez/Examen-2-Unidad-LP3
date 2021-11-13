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
    public class TicketController
    {
        TicketView vista;
        TicketDAO ticketDAO = new TicketDAO();
        Ticket ticket = new Ticket();
        TipoDAO tipoDAO = new TipoDAO();
        EstadoDAO estadoDAO = new EstadoDAO();

        string operacion = string.Empty;

        public TicketController(TicketView view)
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
            if (vista.NombreTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreTextBox, "Ingrese el nombre");
                vista.NombreTextBox.Focus();
            }
            
            try
            {
                ticket.Soporte = vista.TipoComboBox.Text;
                ticket.NombreCliente = vista.NombreTextBox.Text;
                ticket.Estado = vista.EstadoComboBox.Text;
                ticket.FechaInicio = vista.FechaDateTimePicker.Value;

                if (operacion == "Nuevo")
                {
                    bool inserto = ticketDAO.InsertarTicket(ticket);

                    if (inserto)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("Ticket creado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarTicket();
                    }
                    else
                    {
                        MessageBox.Show("Ticket NO creado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (operacion == "Modificar")
                {
                    ticket.Id = Convert.ToInt32(vista.IdTextBox.Text);
                    bool modifico = ticketDAO.ActulizarTicket(ticket);

                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        MessageBox.Show("El ticket ha sido modificado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarTicket();
                    }
                    else
                    {
                        MessageBox.Show("Ticket NO modificado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (vista.TicketDataGridView.SelectedRows.Count > 0)
            {
                HabilitarControles();
                operacion = "Modificar";

                vista.IdTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.NombreTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["NOMBRECLIENTE"].Value.ToString();
                vista.TipoComboBox.Text = vista.TicketDataGridView.CurrentRow.Cells["SOPORTE"].Value.ToString();
                vista.EstadoComboBox.Text = vista.TicketDataGridView.CurrentRow.Cells["ESTADO"].Value.ToString();
                //vista.FechaDateTimePicker.Value = Convert.ToDateTime(vista.TicketDataGridView.CurrentRow.Cells["FECHAINICIO"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.TicketDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = ticketDAO.EliminarTicket(Convert.ToInt32(vista.TicketDataGridView.CurrentRow.Cells["ID"].Value));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    MessageBox.Show("Ticket eliminado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarTicket();
                }
                else
                {
                    MessageBox.Show("Ticket NO eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListarTicket()
        {
            vista.TicketDataGridView.DataSource = ticketDAO.GetTicket();
        }

        private void ListarTipos()
        {
            vista.TipoComboBox.DataSource =  tipoDAO.GetSoporte();
            vista.TipoComboBox.DisplayMember = "TIPOS";
            vista.TipoComboBox.ValueMember = "SOPORTE";
        }

        private void ListarEstado()
        {
            vista.EstadoComboBox.DataSource = estadoDAO.GetEstado();
            vista.EstadoComboBox.DisplayMember = "ESTADO";
            vista.EstadoComboBox.ValueMember = "ESTADO";
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTicket();
            ListarEstado();
            ListarTipos();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
            ticket = null;
        }

        private void Nuevo(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
            ListarEstado();
            ListarTipos();
        }

        private void HabilitarControles()
        {
            vista.NombreTextBox.Enabled = true;
            vista.TipoComboBox.Enabled = true;
            vista.EstadoComboBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }

        private void DeshabilitarControles()
        {
            vista.NombreTextBox.Enabled = false;
            vista.TipoComboBox.Enabled = false;
            vista.EstadoComboBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;

        }

        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.NombreTextBox.Clear();
            vista.TipoComboBox.Text = "";
            vista.EstadoComboBox.Text = "";
        }
    }
}
