#include <iostream>
#include <cstdlib>
#include <string>
#include <ctime>


//
// alter these parameters to observe their influence
//
#define TARGET "Hello World"
#define IND_SIZE sizeof(TARGET) - 1 // total number of genes
#define MAX_GENS 100 // max number of generations allowed
#define POP_SIZE 500 // population size
#define MUT_RATE 0.02 // mutation rate out of 100% 
#define CRS_RATE 0.70 // crossover rate out of 100%
#define NUM_MATES 5 // number of individuals competing to be a parent


struct Individual {
	char genes[IND_SIZE] = {};
	int fitness = 0;
};


int RandomNumber(int low, int high);
int CalculateFitness(char (&genes)[IND_SIZE]);
int FindParent(Individual (&population)[POP_SIZE]);
void Crossover(Individual firstParent, Individual secondParent, Individual &child);
void Mutate(Individual &child);


int main() 
{
	srand((unsigned)time(NULL));

	// prompt user
	std::cout << "Program will use the Genetic Algorithm to replicate the phrase...\n\n";
	std::cout << TARGET << std::endl;
	std::cout << std::endl;

	// initialize population
	Individual population[POP_SIZE] = {};
	for (int i = 0; i < POP_SIZE; i++)
		for (int j = 0; j < IND_SIZE; j++)
			population[i].genes[j] = (char)RandomNumber(32, 126);

	// evolve generations
	int generation = 1;
	while (generation < MAX_GENS) 
	{
		// evaluate fitness and find most fit individual
		int elite = 0;
		for (int i = 0; i < POP_SIZE; i++) 
		{
			population[i].fitness = CalculateFitness(population[i].genes);
			if (population[i].fitness >= population[elite].fitness)
				elite = i;
		}

		// create phenotype for most fit individual
		std::string phenotype = "";
		for (int i = 0; i < IND_SIZE; i++)
			phenotype += population[elite].genes[i];

		std::cout << "Generation: " << generation << "\t Most Fit: " << phenotype << std::endl;

		// quit evolving generations if individual is fully evolved
		if (population[elite].fitness == IND_SIZE)
			break;

		// evolve current generation
		Individual newPopulation[POP_SIZE] = {};
		for (int i = 0; i < POP_SIZE; i++) 
		{
			// find parents
			int firstParent = FindParent(population);
			int secondParent = FindParent(population);

			// prevent asexual reproduction
			if (firstParent == secondParent)
				secondParent = (secondParent + 1) % POP_SIZE;

			// breed parents
			Individual child;
			Crossover(population[firstParent], population[secondParent], child);

			// mutate child
			Mutate(child);

			// add child to new population
			newPopulation[i] = child;
		}

		// kill off current generation
		for (int i = 0; i < POP_SIZE; i++)
			population[i] = newPopulation[i];

		generation++;
	}
}


int RandomNumber(int low, int high) 
{
	int diff = high - low;
	return rand() % diff + low;
}

int CalculateFitness(char (&genes)[IND_SIZE]) 
{
	std::string target = TARGET;
	int fitness = 0;

	for (int i = 0; i < IND_SIZE; i++)
		if (genes[i] == target[i])
			fitness++;

	return fitness;
}

int FindParent(Individual (&population)[POP_SIZE]) 
{
	// grab five random individuals from the population
	int mates[NUM_MATES] = {};
	for (int i = 0; i < NUM_MATES; i++)
		mates[i] = RandomNumber(0, POP_SIZE);

	// choose the best among those five 
	int elite = mates[0];
	for (int i = 1; i < NUM_MATES; i++)
		if (population[mates[i]].fitness > population[elite].fitness)
			elite = mates[i];

	return elite;
}

void Crossover(Individual firstParent, Individual secondParent, Individual &child) 
{
	int crossoverRate = (int)(CRS_RATE * IND_SIZE);

	for (int i = 0; i < IND_SIZE; i++)
		if (i < crossoverRate)
			child.genes[i] = firstParent.genes[i];
		else
			child.genes[i] = secondParent.genes[i];
}

void Mutate(Individual &child) 
{
	int mutationRate = (int)(MUT_RATE * 100);
	
	for (int i = 0; i < IND_SIZE; i++)
		if (RandomNumber(1, 100) <= mutationRate)
			child.genes[i] = (char)RandomNumber(32, 126);
}

