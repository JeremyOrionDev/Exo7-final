namespace Exo7
{
    partial class frmExo7
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
            this.grdStagiaires = new System.Windows.Forms.DataGridView();
            this.lblNomRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStagiaires
            // 
            this.grdStagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStagiaires.Location = new System.Drawing.Point(12, 36);
            this.grdStagiaires.Name = "grdStagiaires";
            this.grdStagiaires.Size = new System.Drawing.Size(574, 376);
            this.grdStagiaires.TabIndex = 0;
            this.grdStagiaires.DoubleClick += new System.EventHandler(this.grdStagiaires_DoubleClick);
            this.grdStagiaires.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdStagiaires_MouseClick);
            // 
            // lblNomRecherche
            // 
            this.lblNomRecherche.AutoSize = true;
            this.lblNomRecherche.Location = new System.Drawing.Point(12, 9);
            this.lblNomRecherche.Name = "lblNomRecherche";
            this.lblNomRecherche.Size = new System.Drawing.Size(80, 13);
            this.lblNomRecherche.TabIndex = 1;
            this.lblNomRecherche.Text = "Nom recherché";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(107, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(317, 20);
            this.txtRecherche.TabIndex = 2;
            // 
            // btnRecherche
            // 
            this.btnRecherche.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRecherche.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecherche.Location = new System.Drawing.Point(430, 4);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 3;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = false;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnTous
            // 
            this.btnTous.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTous.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTous.Location = new System.Drawing.Point(511, 3);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(75, 23);
            this.btnTous.TabIndex = 4;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = false;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuitter.Location = new System.Drawing.Point(507, 418);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.Location = new System.Drawing.Point(426, 418);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupprimer.Location = new System.Drawing.Point(345, 418);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmExo7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 449);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblNomRecherche);
            this.Controls.Add(this.grdStagiaires);
            this.Name = "frmExo7";
            this.Text = "Visualisation des stagiaires";
            this.Load += new System.EventHandler(this.frmExo7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStagiaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStagiaires;
        private System.Windows.Forms.Label lblNomRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}

