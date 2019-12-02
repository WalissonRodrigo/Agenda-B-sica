﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaBasica
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            updateGridView();
        }

        private void updateGridView()
        {
            using (var ct = new Context())
            {
                dgvContatos.DataSource = ct.Contatos.ToList<Contato>();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro formCadastro = new Cadastro();
            formCadastro.ShowDialog();
            updateGridView();
        }
    }
}
