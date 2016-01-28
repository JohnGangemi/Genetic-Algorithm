using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;


namespace WFA_Version
{
  public partial class MainForm : Form
  {
    #region Global Variables
    string target = "";
    int numberOfGenes = 0;
    int maxGenerations = 0;
    int populationSize = 0;
    int numberOfMates = 0;
    float mutationRate = 0.0f;
    float crossoverRate = 0.0f;
    static Random generator = new Random();
    #endregion
    
    public MainForm()
    {
      InitializeComponent();
      lbl_maxGenerations.Text = trkbar_maxGenerations.Value.ToString();
      lbl_populationSize.Text = trkbar_populationSize.Value.ToString();
      lbl_crossoverRate.Text = trkBar_crossoverRate.Value.ToString() + "%";
      lbl_mutationRate.Text = trkBar_mutationRate.Value.ToString() + "%";
      lbl_numMates.Text = trkBar_numMates.Value.ToString();
    }

    #region UI Components
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

        lstBx_output.Items.Clear();
        btn_run.Enabled = false;
        btn_reset.Enabled = false;
        btn_about.Enabled = false;

        var timer = Stopwatch.StartNew();

        // Initialize population
        List<Individual> population = new List<Individual>();
        for (int i = 0; i < populationSize; i++)
        {
          population.Add(new Individual());
          population[i].GenerateRandomGenes(numberOfGenes, ref generator);
        }

        // evolve generations
        int generation = 1;
        while (generation <= maxGenerations)
        {
          // evaluate fitness
          int elite = 0;
          for (int i = 0; i < populationSize; i++)
          {
            population[i].CalculateFitness(target);
            if (population[i].GetFitness() >= population[elite].GetFitness())
              elite = i;
          }

          // display most fit individual
          string result = "Generation: " + generation + "\tBest Fit: " + population[elite].GetPhenotype();
          lstBx_output.Items.Add(result);

          // evaluate fitness of most fit individual
          if (population[elite].GetPhenotype().Equals(target))
            break;

          // evolve current generation
          List<Individual> newPopulation = new List<Individual>();
          for (int i = 0; i < populationSize; i++)
          {
            Evolution selection = new Evolution();

            int firstParent = selection.FindParent(numberOfMates, populationSize, ref generator, population);
            int secondParent = selection.FindParent(numberOfMates, populationSize, ref generator, population);
            if (secondParent == firstParent)
                secondParent = (secondParent + 1) % populationSize;

            Individual child = selection.BreedParents(numberOfGenes, crossoverRate, population[firstParent], population[firstParent]);
            child.Mutate(numberOfGenes, mutationRate, ref generator);

            newPopulation.Add(child);
          }

          // kill off current generation
          population.Clear();
          population.AddRange(newPopulation);

          generation++;
        }

        timer.Stop();
        var runTime = timer.ElapsedMilliseconds;
        lbl_time.Text = "Run time: " + runTime + "ms";
      }
      else
      {
        MessageBox.Show("Please enter text in the target control", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        txtBx_target.Clear();
        txtBx_target.Focus();
      }

      btn_run.Enabled = true;
      btn_reset.Enabled = true;
      btn_about.Enabled = true;
    }

    private void btn_reset_Click(object sender, EventArgs e)
    {
      txtBx_target.Text = "Enter Text";
      ResetSliders();
      lstBx_output.Items.Clear();
      lbl_time.Text = "";
    }

    private void btn_about_Click(object sender, EventArgs e)
    {
      string msg = "Use this program to observe the influence of certain parameters on the Genetic Algorithm.\n"
        + "\ncreated by John A. Gangemi\n"
        + "code is open-source";

      MessageBox.Show(msg, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    #endregion

    #region Utility Methods
    private void ResetSliders()
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
    #endregion
  }
}
