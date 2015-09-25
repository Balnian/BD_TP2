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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataSet Data;
        private void Form1_Load(object sender, EventArgs e)
        {
            recherche();
        }

        private void TB_Recherche_TextChanged(object sender, EventArgs e)
        {
            recherche();
        }

        private void recherche()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            try
            {
                if (!String.IsNullOrWhiteSpace(TB_Recherche.Text))
                {
                    dico.Add("@Terme", "%" + TB_Recherche.Text + "%");
                    Data = DAL_Inventaire.Query("select * from Inventaire where DescriptionInventaire like @Terme", dico);
                }
                else
                {
                    Data = DAL_Inventaire.Query("select * from Inventaire");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            DGV_Inventaire.AutoGenerateColumns = true;
            DGV_Inventaire.DataSource = Data;
            DGV_Inventaire.DataMember = "Inventaire";
        }

        private void listerInventaireBasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeInventaireBas inv = new ListeInventaireBas();
            inv.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout aj = new Ajout();
            aj.ShowDialog();
            

        }

        private void suppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGV_Inventaire.SelectedRows.Count > 0)
            {
                Dictionary<String, Object> dico;
                if (MessageBox.Show("Êtes-vous sur de vouloir supprimer " + ((DGV_Inventaire.SelectedRows.Count > 1) ? ("les " + DGV_Inventaire.SelectedRows.Count.ToString() + " éléments sélectionnés") : "l'élément sélectionné") + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    foreach (DataGridViewRow row in DGV_Inventaire.SelectedRows)
                    {
                        dico = new Dictionary<String, Object>();
                        try
                        {

                            dico.Add("@Id", row.Cells["IdInventaire"].Value);
                            int count = 0;
                            if ((count = DAL_Inventaire.NonQuery("delete from Inventaire where IdInventaire = @Id", dico)) != 1)
                            {
                                MessageBox.Show("Une erreur ses produite: " + count.ToString() + " éléments ont été modifiés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
