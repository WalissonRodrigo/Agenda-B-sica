using System;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
                Contato contato = new Contato();
                contato.Nome = txtNome.Text;
                contato.Endereco = txtEndereco.Text;
                contato.Email = txtEmail.Text;
                contato.Telefone = txtTelefone.Text;

                ctx.Contatos.Add(contato);
                ctx.SaveChanges();
            }
            this.Dispose();
        }
    }
}
