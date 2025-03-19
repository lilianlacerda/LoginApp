using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.Telas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += applicationClose;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void applicationClose(object sender, FormClosingEventArgs evento)
        {
            DialogResult resposta = MessageBox.Show("Realmente deseja fechar a aplicação?", "Sair da aplicação", MessageBoxButtons.YesNo);
            if(resposta == DialogResult.No)
            {
                evento.Cancel = true;

            }
            else
            {
                Application.ExitThread();
            }
            
        }
    }
}
