using System;
using System.Collections.Generic;


namespace WFA_Version
{
  public class Evolution
  {
    public Evolution() {}

    public int FindParent(int numberOfMates, int populationSize, ref Random generator, List<Individual> population)
    {
      List<int> mates = new List<int>();
      for (int i = 0; i < numberOfMates; i++)
        mates.Add(generator.Next(populationSize));

      int parent = mates[0];
      for (int i = 1; i < numberOfMates; i++)
        if (population[mates[i]].GetFitness() > population[parent].GetFitness())
            parent = mates[i];

      return parent;
    }

    public Individual BreedParents(int numberOfGenes, float crossoverRate, Individual firstParent, Individual secondParent)
    {
      Individual child = new Individual();
      int branchPoint = Convert.ToInt32(crossoverRate * (float)numberOfGenes);

      for (int i = 0; i < numberOfGenes; i++)
      {
        if (i < branchPoint)
            child.SetGene(i, firstParent.GetGene(i));
        else
            child.SetGene(i, secondParent.GetGene(i));
      }

      return child;
    }
  }
}
