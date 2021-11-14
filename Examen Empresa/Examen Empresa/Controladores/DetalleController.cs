using Examen_Empresa.Modelos.DAO;
using Examen_Empresa.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Empresa.Controladores
{
    public class DetalleController
    {
        DetalleView vista;
        TicketDAO ticketDAO = new TicketDAO();

        public DetalleController(DetalleView view)
        {
            vista = view;
            vista.Load += new EventHandler(Load);
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTicket();
        }

        private void ListarTicket()
        {
            vista.DetalleDataGridView.DataSource = ticketDAO.GetTicket();
        }
    }
}
