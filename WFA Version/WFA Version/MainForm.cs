using System;
using System.Windows.Forms;

namespace WFA_Version
{
    public partial class MainForm : Form
    {
        string target = "";
        int numberOfGenes = 0;
        int maxGenerations = 0;
        int populationSize = 0;
        int numberOfMates = 0;
        float mutationRate = 0.0f;
        float crossoverRate = 0.0f;


        public MainForm()
        {
            InitializeComponent();
            InstantiateLabels();
        }

        private void trkbar_maxGenerations_Scroll(object sender, EventArgs e)
        {
            lbl_maxGenerations.Text = trkbar_maxGenerations.Value.ToString();
        }

        private void trkbar_populationSize_Scroll(object sender, EventArgs e)
        {
            lbl_populationSize.Text = trkbar_populationSize.Value.ToString();
        }

        private void trkBar_crossoverRate_Scroll(object sender, EventArgs e)
        {
            lbl_crossoverRate.Text = trkBar_crossoverRate.Value.ToString() + "%";
        }

        private void trkBar_mutationRate_Scroll(object sender, EventArgs e)
        {
            lbl_mutationRate.Text = trkBar_mutationRate.Value.ToString() + "%";
        }

        private void trkBar_numMates_Scroll(object sender, EventArgs e)
        {
            lbl_numMates.Text = trkBar_numMates.Value.ToString();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            if (txtBx_target.Text.Trim().Length > 0)
            {
                target = txtBx_target.Text.Trim();
                numberOfGenes = txtBx_target.Text.Trim().Length;
                maxGenerations = trkbar_maxGenerations.Value;
                populationSize = trkbar_populationSize.Value;
                crossoverRate = (float)trkBar_crossoverRate.Value / 100;
                mutationRate = (float)trkBar_mutationRate.Value / 100;
                numberOfMates = trkBar_numMates.Value;

                Console.WriteLine("Target: " + target);
                Console.WriteLine("Number of genes: " + numberOfGenes);
                Console.WriteLine("Max number of generations: " + maxGenerations);
                Console.WriteLine("Population size: " + populationSize);
                Console.WriteLine("Crossover rate: " + crossoverRate);
                Console.WriteLine("Mutation rate: " + mutationRate);
                Console.WriteLine("Number of mates: " + numberOfMates);
            }
            else
            {
                MessageBox.Show("Please enter text in the target control", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtBx_target.Clear();
                txtBx_target.Focus();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtBx_target.Text = "Enter Text";
            InstantiateLabels();
            lstView_output.Clear();
        }

        private void InstantiateLabels()
        {
            trkbar_maxGenerations.Value = trkbar_maxGenerations.Minimum;
            lbl_maxGenerations.Text = trkbar_maxGenerations.Minimum.ToString();

            trkbar_populationSize.Value = trkbar_populationSize.Minimum;
            lbl_populationSize.Text = trkbar_populationSize.Minimum.ToString();

            trkBar_crossoverRate.Value = trkBar_crossoverRate.Minimum;
            lbl_crossoverRate.Text = trkBar_crossoverRate.Minimum.ToString() + "%";

            trkBar_mutationRate.Value = trkBar_mutationRate.Minimum;
            lbl_mutationRate.Text = trkBar_mutationRate.Minimum.ToString() + "%";

            trkBar_numMates.Value = trkBar_numMates.Minimum;
            lbl_numMates.Text = trkBar_numMates.Minimum.ToString();
        }
    }
}
