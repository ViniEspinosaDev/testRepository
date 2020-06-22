using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTesteComandosGitHUb
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtBoxUsuario.Text;
            string senha = txtBoxSenha.Text;

            FazLogin(login, senha);
        }

        private void FazLogin(string login, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
