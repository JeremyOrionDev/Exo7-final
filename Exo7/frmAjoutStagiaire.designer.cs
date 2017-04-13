namespace exercice6
{
    partial class frmAjouterStagiaire
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpStagiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxVirtuelStagiaireCodePostal
            // 
            this.txtBxVirtuelStagiaireCodePostal.TabIndex = 6;
            // 
            // txtBxVirtuelStagiaireVille
            // 
            this.txtBxVirtuelStagiaireVille.TabIndex = 5;
            // 
            // txtBxVirtuelStagiaireAdresse
            // 
            this.txtBxVirtuelStagiaireAdresse.TabIndex = 4;
            // 
            // txtBxVirtuelStagiairePrenom
            // 
            this.txtBxVirtuelStagiairePrenom.TabIndex = 3;
            // 
            // txtBxVirtuelStagiaireNom
            // 
            this.txtBxVirtuelStagiaireNom.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(238, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAnnuler.Location = new System.Drawing.Point(342, 226);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmAjouterStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Name = "frmAjouterStagiaire";
            this.ShowInTaskbar = false;
            this.Text = "Afficher stagiaire";
            this.Load += new System.EventHandler(this.frmAjouterStagiaire_Load);
            this.Controls.SetChildIndex(this.grpStagiaire, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.grpStagiaire.ResumeLayout(false);
            this.grpStagiaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
