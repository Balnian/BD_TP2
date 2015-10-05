namespace TP2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV_Inventaire = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Rafraichir = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Ajouter = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Supprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Lister = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_Recherche = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerInventaireBasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Inventaire
            // 
            this.DGV_Inventaire.AllowUserToAddRows = false;
            this.DGV_Inventaire.AllowUserToDeleteRows = false;
            this.DGV_Inventaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Inventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inventaire.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_Inventaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Inventaire.Location = new System.Drawing.Point(0, 45);
            this.DGV_Inventaire.Name = "DGV_Inventaire";
            this.DGV_Inventaire.ReadOnly = true;
            this.DGV_Inventaire.RowHeadersVisible = false;
            this.DGV_Inventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Inventaire.Size = new System.Drawing.Size(523, 281);
            this.DGV_Inventaire.TabIndex = 0;
            this.DGV_Inventaire.DoubleClick += new System.EventHandler(this.DGV_Inventaire_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Rafraichir,
            this.TSMI_Ajouter,
            this.TSMI_Supprimer,
            this.TSMI_Modifier,
            this.TSMI_Lister});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // TSMI_Rafraichir
            // 
            this.TSMI_Rafraichir.Name = "TSMI_Rafraichir";
            this.TSMI_Rafraichir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.TSMI_Rafraichir.Size = new System.Drawing.Size(218, 22);
            this.TSMI_Rafraichir.Text = "&Rafraichir";
            this.TSMI_Rafraichir.Click += new System.EventHandler(this.rafraichirToolStripMenuItem_Click);
            // 
            // TSMI_Ajouter
            // 
            this.TSMI_Ajouter.Name = "TSMI_Ajouter";
            this.TSMI_Ajouter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TSMI_Ajouter.Size = new System.Drawing.Size(218, 22);
            this.TSMI_Ajouter.Text = "&Ajouter";
            this.TSMI_Ajouter.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // TSMI_Supprimer
            // 
            this.TSMI_Supprimer.Name = "TSMI_Supprimer";
            this.TSMI_Supprimer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.TSMI_Supprimer.Size = new System.Drawing.Size(218, 22);
            this.TSMI_Supprimer.Text = "&Supprimer";
            this.TSMI_Supprimer.Click += new System.EventHandler(this.TSMI_Supprimer_Click);
            // 
            // TSMI_Modifier
            // 
            this.TSMI_Modifier.Name = "TSMI_Modifier";
            this.TSMI_Modifier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.TSMI_Modifier.Size = new System.Drawing.Size(218, 22);
            this.TSMI_Modifier.Text = "&Modifier";
            this.TSMI_Modifier.Click += new System.EventHandler(this.TSMI_Modifier_Click);
            // 
            // TSMI_Lister
            // 
            this.TSMI_Lister.Name = "TSMI_Lister";
            this.TSMI_Lister.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.TSMI_Lister.Size = new System.Drawing.Size(218, 22);
            this.TSMI_Lister.Text = "&Lister Inventaire Bas";
            this.TSMI_Lister.Click += new System.EventHandler(this.TSMI_Lister_Click);
            // 
            // TB_Recherche
            // 
            this.TB_Recherche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Recherche.Location = new System.Drawing.Point(77, 0);
            this.TB_Recherche.Name = "TB_Recherche";
            this.TB_Recherche.Size = new System.Drawing.Size(446, 20);
            this.TB_Recherche.TabIndex = 2;
            this.TB_Recherche.TextChanged += new System.EventHandler(this.TB_Recherche_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.suppressionToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.listerInventaireBasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ajouterToolStripMenuItem.Text = "&Ajout";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.suppressionToolStripMenuItem.Text = "&Suppression";
            this.suppressionToolStripMenuItem.Click += new System.EventHandler(this.suppressionToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "&Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // listerInventaireBasToolStripMenuItem
            // 
            this.listerInventaireBasToolStripMenuItem.Name = "listerInventaireBasToolStripMenuItem";
            this.listerInventaireBasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listerInventaireBasToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.listerInventaireBasToolStripMenuItem.Text = "&Lister Inventaire bas";
            this.listerInventaireBasToolStripMenuItem.Click += new System.EventHandler(this.listerInventaireBasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recherche:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_Recherche);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 21);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 326);
            this.Controls.Add(this.DGV_Inventaire);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Inventaire;
        private System.Windows.Forms.TextBox TB_Recherche;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerInventaireBasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Rafraichir;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Ajouter;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Supprimer;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Modifier;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Lister;
    }
}

