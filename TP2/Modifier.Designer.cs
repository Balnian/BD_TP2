﻿namespace TP2
{
    partial class Modifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier));
            this.BT_Annuler = new System.Windows.Forms.Button();
            this.BT_Appliquer = new System.Windows.Forms.Button();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Fournisseurs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_MinQte = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_MaxQte = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUD_Stock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MinQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MaxQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Annuler
            // 
            this.BT_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Annuler.Location = new System.Drawing.Point(116, 261);
            this.BT_Annuler.Name = "BT_Annuler";
            this.BT_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BT_Annuler.TabIndex = 23;
            this.BT_Annuler.Text = "Annuler";
            this.BT_Annuler.UseVisualStyleBackColor = true;
            // 
            // BT_Appliquer
            // 
            this.BT_Appliquer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Appliquer.Location = new System.Drawing.Point(197, 261);
            this.BT_Appliquer.Name = "BT_Appliquer";
            this.BT_Appliquer.Size = new System.Drawing.Size(75, 23);
            this.BT_Appliquer.TabIndex = 22;
            this.BT_Appliquer.Text = "Appliquer";
            this.BT_Appliquer.UseVisualStyleBackColor = true;
            this.BT_Appliquer.Click += new System.EventHandler(this.BT_Appliquer_Click);
            // 
            // TB_Description
            // 
            this.TB_Description.Location = new System.Drawing.Point(12, 156);
            this.TB_Description.MaxLength = 500;
            this.TB_Description.Multiline = true;
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(260, 94);
            this.TB_Description.TabIndex = 21;
            this.TB_Description.TextChanged += new System.EventHandler(this.TB_Description_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description:";
            // 
            // CB_Fournisseurs
            // 
            this.CB_Fournisseurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Fournisseurs.FormattingEnabled = true;
            this.CB_Fournisseurs.Location = new System.Drawing.Point(125, 96);
            this.CB_Fournisseurs.Name = "CB_Fournisseurs";
            this.CB_Fournisseurs.Size = new System.Drawing.Size(121, 21);
            this.CB_Fournisseurs.TabIndex = 19;
            this.CB_Fournisseurs.SelectedIndexChanged += new System.EventHandler(this.CB_Fournisseurs_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fournisseur:";
            // 
            // NUD_MinQte
            // 
            this.NUD_MinQte.Location = new System.Drawing.Point(125, 68);
            this.NUD_MinQte.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NUD_MinQte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_MinQte.Name = "NUD_MinQte";
            this.NUD_MinQte.Size = new System.Drawing.Size(120, 20);
            this.NUD_MinQte.TabIndex = 17;
            this.NUD_MinQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_MinQte.ValueChanged += new System.EventHandler(this.NUD_MinQte_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantité Minimum:";
            // 
            // NUD_MaxQte
            // 
            this.NUD_MaxQte.Location = new System.Drawing.Point(125, 47);
            this.NUD_MaxQte.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NUD_MaxQte.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_MaxQte.Name = "NUD_MaxQte";
            this.NUD_MaxQte.Size = new System.Drawing.Size(120, 20);
            this.NUD_MaxQte.TabIndex = 15;
            this.NUD_MaxQte.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_MaxQte.ValueChanged += new System.EventHandler(this.NUD_MaxQte_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantité Maximum:";
            // 
            // NUD_Stock
            // 
            this.NUD_Stock.Location = new System.Drawing.Point(125, 25);
            this.NUD_Stock.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NUD_Stock.Name = "NUD_Stock";
            this.NUD_Stock.Size = new System.Drawing.Size(120, 20);
            this.NUD_Stock.TabIndex = 13;
            this.NUD_Stock.ValueChanged += new System.EventHandler(this.NUD_Stock_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantité de stock:";
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.BT_Annuler);
            this.Controls.Add(this.BT_Appliquer);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_Fournisseurs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUD_MinQte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUD_MaxQte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUD_Stock);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 334);
            this.MinimumSize = new System.Drawing.Size(300, 334);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MinQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MaxQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Annuler;
        private System.Windows.Forms.Button BT_Appliquer;
        private System.Windows.Forms.TextBox TB_Description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Fournisseurs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_MinQte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUD_MaxQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUD_Stock;
        private System.Windows.Forms.Label label1;

    }
}