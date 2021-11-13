using Examen_Empresa.Controladores;
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
    public partial class TiposView : Form
    {
        public TiposView()
        {
            InitializeComponent();
            TipoController controlador = new TipoController(this);
        }

        private void TiposView_Load(object sender, EventArgs e)
        {

        }
    }
}
