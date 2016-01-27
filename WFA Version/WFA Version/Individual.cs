using System;
using System.Collections.Generic;


namespace WFA_Version
{
  public class Individual
  {
    private List<char> genes;
    private int fitness;

    public Individual()
    {
      genes = new List<char>();
      fitness = 0;
    }

    public void GenerateRandomGenes(int numberOfGenes, ref Random generator)
    {
      for (int i = 0; i < numberOfGenes; i++)
        genes.Add(Convert.ToChar(generator.Next(32, 127)));
    }

    public void CalculateFitness(string target)
    {
      for (int i = 0; i < genes.Count; i++)
        if (genes[i] == target[i])
          fitness++;
    }

    public void Mutate(int numberOfGenes, float mutationRate, ref Random generator)
    {
      int flipPoint = Convert.ToInt32(mutationRate * 100f);

      for (int i = 0; i < numberOfGenes; i++)
        if (generator.Next(1, 100) <= flipPoint)
          genes[i] = Convert.ToChar(generator.Next(32, 127));
    }

    public int GetFitness()
    {
      return fitness;
    }

    public void SetGene(int index, char gene)
    {
      genes.Insert(index, gene);
    }

    public char GetGene(int index)
    {
      return genes[index];
    }

    public string GetPhenotype()
    {
      string phenotype = null;

      foreach (char character in genes)
        phenotype += character;

      return phenotype;
    }
  }
}
