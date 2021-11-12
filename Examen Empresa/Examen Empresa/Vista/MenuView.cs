using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_Empresa.Vista
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        TiposView vistaTipos;
        EstadoView vistaEstado;
        TicketView vistaTicket;
        DetalleView vistaDetalle;

        private void TipoStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTipos == null)
            {
                vistaTipos = new TiposView();
                vistaTipos.MdiParent = this;
                vistaTipos.FormClosed += VistaTipos_FormClosed;
                vistaTipos.Show();
            }
            else
            {
                vistaTipos.Activate();
            }
        }

        private void VistaTipos_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaTipos = null;
        }

        private void EstadoStripButton_Click(object sender, EventArgs e)
        {
            if (vistaEstado == null)
            {
                vistaEstado = new EstadoView();
                vistaEstado.MdiParent = this;
                vistaEstado.FormClosed += VistaEstado_FormClosed;
                vistaEstado.Show();
            }
            else
            {
                vistaEstado.Activate();
            }
        }

        private void VistaEstado_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaEstado = null;
        }

        private void TicketStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTicket == null)
            {
                vistaTicket = new TicketView();
                vistaTicket.MdiParent = this;
                vistaTicket.FormClosed += VistaTicket_FormClosed; 
                vistaTicket.Show();
            }
            else
            {
                vistaTicket.Activate();
            }
        }

        private void VistaTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaTicket = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (vistaDetalle == null)
            {
                vistaDetalle = new DetalleView();
                vistaDetalle.MdiParent = this;
                vistaDetalle.FormClosed += VistaDetalle_FormClosed;
                vistaDetalle.Show();
            }
            else
            {
                vistaDetalle.Activate();
            }
        }

        private void VistaDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaDetalle = null;
        }
    }
}
