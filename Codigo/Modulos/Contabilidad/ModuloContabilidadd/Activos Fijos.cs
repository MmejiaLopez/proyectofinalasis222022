﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloContabilidadd
{
    public partial class Activos_Fijos : Form
    {
        public Activos_Fijos()
        {
            InitializeComponent();
        }

        private void Activos_Fijos_Load(object sender, EventArgs e)
        {

        }

        private void bnt_menuP_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContenedorCF menuP = new ContenedorCF();
            menuP.Show();
        }
    }
}
