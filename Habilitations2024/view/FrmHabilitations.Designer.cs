namespace Habilitations2024.view
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.developpersGroup = new System.Windows.Forms.GroupBox();
            this.modifBTN = new System.Windows.Forms.Button();
            this.addDev = new System.Windows.Forms.GroupBox();
            this.cbProfil = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.passwordBTN = new System.Windows.Forms.Button();
            this.pwdGP = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPwdConfirm = new System.Windows.Forms.TextBox();
            this.savePwdBTN = new System.Windows.Forms.Button();
            this.cancelPwdBTN = new System.Windows.Forms.Button();
            this.saveDevBTN = new System.Windows.Forms.Button();
            this.cancelDevBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.developpersGroup.SuspendLayout();
            this.addDev.SuspendLayout();
            this.pwdGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(637, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // developpersGroup
            // 
            this.developpersGroup.Controls.Add(this.passwordBTN);
            this.developpersGroup.Controls.Add(this.deleteBTN);
            this.developpersGroup.Controls.Add(this.modifBTN);
            this.developpersGroup.Controls.Add(this.dataGridView1);
            this.developpersGroup.Location = new System.Drawing.Point(12, 12);
            this.developpersGroup.Name = "developpersGroup";
            this.developpersGroup.Size = new System.Drawing.Size(776, 369);
            this.developpersGroup.TabIndex = 1;
            this.developpersGroup.TabStop = false;
            this.developpersGroup.Text = "Les développeurs";
            // 
            // modifBTN
            // 
            this.modifBTN.Location = new System.Drawing.Point(7, 331);
            this.modifBTN.Name = "modifBTN";
            this.modifBTN.Size = new System.Drawing.Size(75, 23);
            this.modifBTN.TabIndex = 1;
            this.modifBTN.Text = "Modifier";
            this.modifBTN.UseVisualStyleBackColor = true;
            this.modifBTN.Click += new System.EventHandler(this.modifBTN_Click);
            // 
            // addDev
            // 
            this.addDev.Controls.Add(this.cancelDevBTN);
            this.addDev.Controls.Add(this.saveDevBTN);
            this.addDev.Controls.Add(this.cbProfil);
            this.addDev.Controls.Add(this.txtMail);
            this.addDev.Controls.Add(this.txtTel);
            this.addDev.Controls.Add(this.label5);
            this.addDev.Controls.Add(this.label4);
            this.addDev.Controls.Add(this.label3);
            this.addDev.Controls.Add(this.txtPrenom);
            this.addDev.Controls.Add(this.label2);
            this.addDev.Controls.Add(this.label1);
            this.addDev.Controls.Add(this.txtNom);
            this.addDev.Location = new System.Drawing.Point(13, 388);
            this.addDev.Name = "addDev";
            this.addDev.Size = new System.Drawing.Size(775, 116);
            this.addDev.TabIndex = 2;
            this.addDev.TabStop = false;
            this.addDev.Text = "Ajouter développeur";
            // 
            // cbProfil
            // 
            this.cbProfil.FormattingEnabled = true;
            this.cbProfil.Location = new System.Drawing.Point(394, 83);
            this.cbProfil.Name = "cbProfil";
            this.cbProfil.Size = new System.Drawing.Size(214, 21);
            this.cbProfil.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(394, 21);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(214, 20);
            this.txtMail.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(394, 57);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(214, 20);
            this.txtTel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Profil : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tel : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail : ";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(68, 54);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(214, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(68, 22);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(214, 20);
            this.txtNom.TabIndex = 0;
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(99, 331);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(75, 23);
            this.deleteBTN.TabIndex = 2;
            this.deleteBTN.Text = "Supprimer";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // passwordBTN
            // 
            this.passwordBTN.Location = new System.Drawing.Point(194, 331);
            this.passwordBTN.Name = "passwordBTN";
            this.passwordBTN.Size = new System.Drawing.Size(89, 23);
            this.passwordBTN.TabIndex = 3;
            this.passwordBTN.Text = "changer pwd";
            this.passwordBTN.UseVisualStyleBackColor = true;
            this.passwordBTN.Click += new System.EventHandler(this.passwordBTN_Click);
            // 
            // pwdGP
            // 
            this.pwdGP.Controls.Add(this.cancelPwdBTN);
            this.pwdGP.Controls.Add(this.savePwdBTN);
            this.pwdGP.Controls.Add(this.txtPwdConfirm);
            this.pwdGP.Controls.Add(this.label7);
            this.pwdGP.Controls.Add(this.txtPwd);
            this.pwdGP.Controls.Add(this.label6);
            this.pwdGP.Enabled = false;
            this.pwdGP.Location = new System.Drawing.Point(13, 511);
            this.pwdGP.Name = "pwdGP";
            this.pwdGP.Size = new System.Drawing.Size(775, 80);
            this.pwdGP.TabIndex = 3;
            this.pwdGP.TabStop = false;
            this.pwdGP.Text = "Changer le mot de passe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mot de passe : ";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(99, 17);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(130, 20);
            this.txtPwd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Répéter mot de passe : ";
            // 
            // txtPwdConfirm
            // 
            this.txtPwdConfirm.Location = new System.Drawing.Point(390, 17);
            this.txtPwdConfirm.Name = "txtPwdConfirm";
            this.txtPwdConfirm.Size = new System.Drawing.Size(131, 20);
            this.txtPwdConfirm.TabIndex = 3;
            // 
            // savePwdBTN
            // 
            this.savePwdBTN.Location = new System.Drawing.Point(16, 49);
            this.savePwdBTN.Name = "savePwdBTN";
            this.savePwdBTN.Size = new System.Drawing.Size(75, 23);
            this.savePwdBTN.TabIndex = 4;
            this.savePwdBTN.Text = "Enregistrer";
            this.savePwdBTN.UseVisualStyleBackColor = true;
            this.savePwdBTN.Click += new System.EventHandler(this.savePwdBTN_Click);
            // 
            // cancelPwdBTN
            // 
            this.cancelPwdBTN.Location = new System.Drawing.Point(111, 49);
            this.cancelPwdBTN.Name = "cancelPwdBTN";
            this.cancelPwdBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelPwdBTN.TabIndex = 5;
            this.cancelPwdBTN.Text = "Annuler";
            this.cancelPwdBTN.UseVisualStyleBackColor = true;
            // 
            // saveDevBTN
            // 
            this.saveDevBTN.Location = new System.Drawing.Point(16, 83);
            this.saveDevBTN.Name = "saveDevBTN";
            this.saveDevBTN.Size = new System.Drawing.Size(75, 23);
            this.saveDevBTN.TabIndex = 11;
            this.saveDevBTN.Text = "Enregistrer";
            this.saveDevBTN.UseVisualStyleBackColor = true;
            this.saveDevBTN.Click += new System.EventHandler(this.saveDevBTN_Click);
            // 
            // cancelDevBTN
            // 
            this.cancelDevBTN.Location = new System.Drawing.Point(111, 82);
            this.cancelDevBTN.Name = "cancelDevBTN";
            this.cancelDevBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelDevBTN.TabIndex = 12;
            this.cancelDevBTN.Text = "Annuler";
            this.cancelDevBTN.UseVisualStyleBackColor = true;
            this.cancelDevBTN.Click += new System.EventHandler(this.cancelDevBTN_Click);
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.pwdGP);
            this.Controls.Add(this.addDev);
            this.Controls.Add(this.developpersGroup);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations 2024";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.developpersGroup.ResumeLayout(false);
            this.addDev.ResumeLayout(false);
            this.addDev.PerformLayout();
            this.pwdGP.ResumeLayout(false);
            this.pwdGP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox developpersGroup;
        private System.Windows.Forms.Button modifBTN;
        private System.Windows.Forms.GroupBox addDev;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfil;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button passwordBTN;
        private System.Windows.Forms.GroupBox pwdGP;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPwdConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelPwdBTN;
        private System.Windows.Forms.Button savePwdBTN;
        private System.Windows.Forms.Button cancelDevBTN;
        private System.Windows.Forms.Button saveDevBTN;
    }
}

