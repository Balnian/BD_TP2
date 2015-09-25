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
            Dictionary<String, Object> dico = new Dictionary<String, Object>();
            dico.Add("@Id", 1);
            try
            {
                Data = DAL_Inventaire.Query("select * from Inventaire where IdInventaire = @Id", dico);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            DGV_Inventaire.AutoGenerateColumns = true;
            DGV_Inventaire.DataSource = Data;
            DGV_Inventaire.DataMember = "Inventaire";
        }
    }
}
