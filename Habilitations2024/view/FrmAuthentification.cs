using Habilitations2024.model;
using Habilitations2024.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habilitations2024.view
{
    public partial class FrmAuthentification : Form
    {
        private FrmAuthentificationController controller;
        public FrmAuthentification()
        {
            Init();
            InitializeComponent();
        }

        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrenom.Text) || string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Admin admin = new Admin(txtNom.Text, txtPrenom.Text, txtPwd.Text);
            bool auth = controller.ControleAuthentification(admin);
            if (!auth)
            {
                MessageBox.Show("Authentification échouée. Veuillez vérifier vos informations de connexion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmHabilitations frm = new FrmHabilitations();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
