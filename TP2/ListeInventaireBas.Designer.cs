namespace TP2
{
    partial class ListeInventaireBas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeInventaireBas));
            this.DGV_Inventaire = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rafraichirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.DGV_Inventaire.Location = new System.Drawing.Point(0, 0);
            this.DGV_Inventaire.Name = "DGV_Inventaire";
            this.DGV_Inventaire.ReadOnly = true;
            this.DGV_Inventaire.RowHeadersVisible = false;
            this.DGV_Inventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Inventaire.Size = new System.Drawing.Size(284, 262);
            this.DGV_Inventaire.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rafraichirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 26);
            // 
            // rafraichirToolStripMenuItem
            // 
            this.rafraichirToolStripMenuItem.Name = "rafraichirToolStripMenuItem";
            this.rafraichirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rafraichirToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.rafraichirToolStripMenuItem.Text = "Rafraichir";
            this.rafraichirToolStripMenuItem.Click += new System.EventHandler(this.rafraichirToolStripMenuItem_Click);
            // 
            // ListeInventaireBas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.DGV_Inventaire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeInventaireBas";
            this.Text = "ListeInventaireBas";
            this.Load += new System.EventHandler(this.ListeInventaireBas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Inventaire;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rafraichirToolStripMenuItem;

    }
}