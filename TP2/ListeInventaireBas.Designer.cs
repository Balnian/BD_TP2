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
            this.DGV_Inventaire = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Inventaire
            // 
            this.DGV_Inventaire.AllowUserToAddRows = false;
            this.DGV_Inventaire.AllowUserToDeleteRows = false;
            this.DGV_Inventaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Inventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inventaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Inventaire.Location = new System.Drawing.Point(0, 0);
            this.DGV_Inventaire.Name = "DGV_Inventaire";
            this.DGV_Inventaire.ReadOnly = true;
            this.DGV_Inventaire.RowHeadersVisible = false;
            this.DGV_Inventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Inventaire.Size = new System.Drawing.Size(284, 262);
            this.DGV_Inventaire.TabIndex = 1;
            // 
            // ListeInventaireBas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.DGV_Inventaire);
            this.Name = "ListeInventaireBas";
            this.Text = "ListeInventaireBas";
            this.Load += new System.EventHandler(this.ListeInventaireBas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Inventaire;

    }
}