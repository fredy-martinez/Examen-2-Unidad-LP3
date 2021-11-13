using Examen_Empresa.Controladores;
using Examen_Empresa.Modelos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Empresa.Vista
{
    public partial class TicketView : Form
    {
        public TicketView()
        {
            InitializeComponent();
            TicketController controlador = new TicketController(this);
        }

        private void TicketDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
