using Bassirou_test.models;
using Bassirou_test.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bassirou_test
{
    public partial class Form1 : Form
    {
        private CargaisonServicebd service = new CargaisonServicebd();
        private List<Cargaison> cargaisons;
        Cargaison cargaisonSelect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            cargaisons = service.ListerCargaison();
            foreach (Cargaison car in cargaisons)
            {
                lbCargaison.Items.Add(car);
            }

            lbCargaison.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cargaison cargaison = null;
            if(!string.IsNullOrEmpty(txtDistance.Text))
            {
                if(cboType.Text.CompareTo("Aerienne")==0)
                {
                    cargaison = new Aerienne();
                }
                else
                {
                    cargaison = new Routiere();
                }
                cargaison.Distance = double.Parse(txtDistance.Text);
                if (service.addCargaison(cargaison))
                {
                    MessageBox.Show("Cargaison Ajoutée avec succes!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbCargaison.Items.Add(cargaison);
                    txtDistance.Clear();
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir la distance!!" , "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void lbCargaison_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbCargaison_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargaisonSelect = (Cargaison)lbCargaison.SelectedItem;
            LoadDataGridView();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddMarchandise_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtbPoids.Text)  || string.IsNullOrEmpty(txtbVolume.Text))
            {
                MessageBox.Show("Veuillez remplir les champs", "erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Marchandise mar = new Marchandise()
                {
                    Poids = double.Parse(txtbPoids.Text),
                    Volume = double.Parse(txtbVolume.Text), 
                    Cargaison = cargaisonSelect
                };
                service.AddMarchandiseInCargaison(mar);
                MessageBox.Show("Marchandise Ajouté avec succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtbPoids.Clear();
                txtbVolume.Clear();

                cargaisonSelect.PoidsTotal = 0;
                cargaisonSelect.VolumeTotal = 0;
                LoadDataGridView();

            }
        }
        private void LoadDataGridView()
        {

            dgvMarchandise.DataSource = service.ListerMarchandiseDunenCargaison(cargaisonSelect);
            txtPoidsTotal.Text = cargaisonSelect.PoidsTotal.ToString();
            txtVolumeTotal.Text = cargaisonSelect.VolumeTotal.ToString();
            txtcout.Text = cargaisonSelect.Cout().ToString();

        }

        private void btnup_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
