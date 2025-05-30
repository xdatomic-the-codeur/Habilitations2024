using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Habilitations2024.controller;
using Habilitations2024.model;

namespace Habilitations2024.view
{
    public partial class FrmHabilitations : Form
    {
        private FrmHabilitationsController controller;

        private BindingSource bdgDeveloppeurs = new BindingSource();

        private bool isModifDeveloppeur = false;

        public FrmHabilitations()
        {
            InitializeComponent();
            controller = new FrmHabilitationsController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemplirListeDeveloppeurs();

            // Remplissage de la liste des profils
            var listeProfils = controller.GetLesProfils();
            cbProfil.DataSource = listeProfils;

            // Remplir cbFiltre avec les profils
            cbFiltre.DataSource = new List<Profil> { new Profil(0, " ") }.Concat(listeProfils).ToList();
            cbFiltre.DisplayMember = "Nom";

        }

        /// <summary>
        /// Remplit le DataGridView avec la liste des développeurs
        /// </summary>
        private void RemplirListeDeveloppeurs(string filtre = "All")
        {
            var lesDeveloppeurs = controller.GetLesDeveloppeurs(filtre);

            bdgDeveloppeurs.DataSource = lesDeveloppeurs;

            // Projection pour n'afficher que les colonnes utiles
            var data = lesDeveloppeurs.Select(d => new
            {
                Nom = d.Nom,
                Prénom = d.Prenom,
                Téléphone = d.Tel,
                Mail = d.Mail,
                Profil = d.Profil.Nom
            }).ToList();

            dataGridView1.DataSource = data;

            // Configuration du DataGridView selon le cahier des charges
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
        }

        private void modifBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un développeur à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            addDev.Text = "Modifier un développeur";
            developpersGroup.Enabled = false;
            Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[index];

            txtNom.Text = developpeur.Nom;
            txtPrenom.Text = developpeur.Prenom;
            txtTel.Text = developpeur.Tel;
            txtMail.Text = developpeur.Mail;
            cbProfil.SelectedIndex = cbProfil.FindStringExact(developpeur.Profil.Nom);
            boolModifDev(true);
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un développeur à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            developpersGroup.Enabled = false;
            Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[index];
            DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le développeur {developpeur.Nom} {developpeur.Prenom} ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Test si le code fonctionne avant de décommenter
                //MessageBox.Show($"Suppression du développeur {developpeur.Nom} {developpeur.Prenom} effectuée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controller.DelDeveloppeur(developpeur);
                boolModifDev(false);
            }
        }
        private void passwordBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un développeur pour modifier son mot de passe.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            developpersGroup.Enabled = false;
            addDev.Enabled = false;
            pwdGP.Enabled = true;
        }

        private void saveDevBTN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text) || string.IsNullOrWhiteSpace(txtTel.Text) || string.IsNullOrWhiteSpace(txtMail.Text) || cbProfil.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Profil profil = (Profil)cbProfil.SelectedItem;
                if (isModifDeveloppeur)
                {
                    // Modification d'un développeur
                    Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[dataGridView1.SelectedRows[0].Index];
                    developpeur.Nom = txtNom.Text;
                    developpeur.Prenom = txtPrenom.Text;
                    developpeur.Tel = txtTel.Text;
                    developpeur.Mail = txtMail.Text;
                    developpeur.Profil = profil;
                    developpeur.Pwd = developpeur.Pwd;
                    controller.UpdateDeveloppeur(developpeur);
                }
                else
                {
                    // Ajout d'un nouveau développeur
                    Developpeur newDev = new Developpeur(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, profil);
                    controller.AddDeveloppeur(newDev);
                }
                RemplirListeDeveloppeurs();
                boolModifDev(false);
            }
        }

        private void boolModifDev(bool isModifDev)
        {
            this.isModifDeveloppeur = isModifDev;
            if (isModifDev)
            {
                addDev.Text = "Modifier un développeur";
                developpersGroup.Enabled = false;
            }
            else
            {
                addDev.Text = "Ajouter un développeur";
                developpersGroup.Enabled = true;
                txtNom.Clear();
                txtPrenom.Clear();
                txtTel.Clear();
                txtMail.Clear();
                cbProfil.SelectedIndex = -1;
            }
        }

        private void cancelDevBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir annuler les modifications ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                boolModifDev(false);
            }
        }

        private void savePwdBTN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPwd.Text) || string.IsNullOrWhiteSpace(txtPwdConfirm.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtPwd.Text != txtPwdConfirm.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un développeur pour modifier son mot de passe.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[index];

            // Modification du mot de passe
            developpeur.Pwd = txtPwd.Text;
            controller.UpdatePwd(developpeur);
            MessageBox.Show("Mot de passe modifié avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Réinitialisation des champs et retour à l'état normal
            pwdGP.Enabled = false;
            addDev.Enabled = true;
            developpersGroup.Enabled = true;
            txtPwd.Clear();
            txtPwdConfirm.Clear();
        }

        private void cbFiltre_SelectedValueChanged(object sender, EventArgs e)
        {
            RemplirListeDeveloppeurs(cbFiltre.SelectedValue.ToString());
        }
    }
}
