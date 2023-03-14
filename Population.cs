using System;

namespace Clasificare
{
    public class Population
    {
        private readonly Random random = new Random();
        private Individual[] individuals;

        public Individual[] Individuals
        {
            get { return individuals; }
        }
        public Individual BestIndividual
        {
            get
            {
                Array.Sort(individuals);

                if (individuals.Length > 0) return individuals[0];
                else return null;
            }
        }

        public Population(Individual[] setIndividuals)
        {
            individuals = setIndividuals;
        }
        public Population(int size, int minHeight, int maxHeight) : this(new Individual[size])
        {
            for (int i = 0; i < size; i++) individuals[i] = new Individual(minHeight, maxHeight);
        }

        public Population NextGeneration()
        {
            var result = new Population(new Individual[individuals.Length]);
            double mutationProbability = RandomGenerator.Generator.NextDouble();
            double selectionProbability = RandomGenerator.Generator.NextDouble();
            int copiedIndividuals = RandomGenerator.Generator.Next(1, individuals.Length);

            Array.Sort(individuals);
            if (individuals.Length >= copiedIndividuals) Array.Copy(individuals, result.Individuals, copiedIndividuals);

            for (var i = copiedIndividuals; i < individuals.Length; i++)
            {
                Individual fiu = null;

                if (RandomGenerator.Generator.NextDouble() < 0.5) fiu = individuals[random.Next(0, individuals.Length)].Cross(individuals[random.Next(0, individuals.Length)], selectionProbability);
                else fiu = individuals[random.Next(0, individuals.Length)].Mutation(mutationProbability);

                result.individuals[i] = fiu;
            }

            return result;
        }
    }
}