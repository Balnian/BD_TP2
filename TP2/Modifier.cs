using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Modifier : Form
    {
        private int IdInventaire;
        private DataSet Data;
        private DataSet DataFournisseur;

        private int CurrStock;
        private int CurrMax;
        private int CurrMin;
        private int CurrFournisseur;
        private String CurrDescription;
        public Modifier(int IdInventaire)
        {
            InitializeComponent();
            this.IdInventaire = IdInventaire;
        }

        private void getData()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            try
            {
                
                dico.Add("@IdInventaire", IdInventaire);
                Data = DAL_Inventaire.Query("select * from Inventaire where IdInventaire = @IdInventaire", dico);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            fillFournisseur();
            registerCurrentValue();
            ResetValues();
        }

        private void ResetValues()
        {
            
            
            NUD_Stock.Value = CurrStock;
            NUD_MaxQte.Value = CurrMax;
            NUD_MinQte.Value = CurrMin;
            TB_Description.Text = CurrDescription;
            CB_Fournisseurs.SelectedValue = CurrFournisseur;

        }
        private void registerCurrentValue()
        {
            DataRow Row = Data.Tables["Inventaire"].Rows[0];
            CurrDescription = (string)Row.ItemArray[1];
            CurrFournisseur = (int)Row.ItemArray[2];
            CurrStock = (int)Row.ItemArray[3];
            CurrMin = (int)Row.ItemArray[4];
            CurrMax = (int)Row.ItemArray[5];
        }

        private void fillFournisseur()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            try
            {

                DataFournisseur = DAL_Inventaire.Query("select IdFournisseur, NomFournisseur from Fournisseur");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            CB_Fournisseurs.DataSource = DataFournisseur.Tables["Inventaire"];
            CB_Fournisseurs.ValueMember = "IdFournisseur";
            CB_Fournisseurs.DisplayMember = "NomFournisseur";
        }

        

        private void Modifier_Load(object sender, EventArgs e)
        {

            getData();

        }

        void save()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            dico.Add("@Idinventaire", IdInventaire);
            dico.Add("@Stock", (int)NUD_Stock.Value);
            dico.Add("@Max", (int)NUD_MaxQte.Value);
            dico.Add("@Min", (int)NUD_MinQte.Value);
            dico.Add("@IdFournisseur", CB_Fournisseurs.SelectedValue);
            dico.Add("@Description", TB_Description.Text);

            try
            {

                DAL_Inventaire.NonQuery("update Inventaire set DescriptionInventaire = @Description, IdFournisseur = @IdFournisseur, QteStock = @Stock, QteMinimum = @Min, QteMaximum = @Max where IdInventaire = @Idinventaire", dico);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void enableAppliquer()
        {
            BT_Appliquer.Enabled = (int)NUD_Stock.Value != CurrStock || (int)NUD_MinQte.Value != CurrMin ||(int)NUD_MaxQte.Value != CurrMax || (int)CB_Fournisseurs.SelectedValue != CurrFournisseur || TB_Description.Text != CurrDescription;
        }

        private void BT_Appliquer_Click(object sender, EventArgs e)
        {
            save();
        }

        private void NUD_Stock_ValueChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void NUD_MaxQte_ValueChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void NUD_MinQte_ValueChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void CB_Fournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void TB_Description_TextChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }
    }
}
