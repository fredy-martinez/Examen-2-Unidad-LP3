﻿using Examen_Empresa.Controladores;
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
    public partial class DetalleView : Form
    {
        public DetalleView()
        {
            InitializeComponent();
            DetalleController controlador = new DetalleController(this);
        }
    }
}
