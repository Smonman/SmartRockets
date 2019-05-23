using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;

namespace SmartRockets_1
{
    class Population
    {
        Rocket[] rockets;
        Rocket[] newRockets;
        public int populationSize;
        double maxFitness;
        List<Rocket> matingPool;

        int lifetime;
        double mutationRate;
        bool mutate;
        Vector target;
        Random rand;
        Bitmap b;

        public Population(int size, int life, double mutationRate, bool mutate, Vector target, Random r, Bitmap b)
        {
            lifetime = life;
            this.mutationRate = mutationRate;
            this.mutate = mutate;
            this.target = target;
            rand = r;
            this.b = b;
            populationSize = size;
            matingPool = new List<Rocket>();
            rockets = new Rocket[populationSize];
            newRockets = new Rocket[populationSize];
            for (int i = 0; i < populationSize; i++)
            {
                rockets[i] = new Rocket(life, target, r, this.b);
            }
        }

        public void Run(int count)
        {
            foreach (Rocket r in rockets)
            {
                r.Update(count);
                r.Show(b);
            }
        }

        public string Evaluate()
        {
            maxFitness = 0;
            foreach (Rocket r in rockets)
            {
                r.CalculateFitness();
                if (r.fitness > maxFitness)
                {
                    maxFitness = r.fitness;
                }
            }

            foreach (Rocket r in rockets)
            {
                r.fitness /= maxFitness;
            }

            foreach (Rocket r in rockets)
            {
                double n = r.fitness * 100;
                for (int i = 0; i < n; i++)
                {
                    matingPool.Add(r);
                }
            }
            return maxFitness.ToString("#.#######");
        }

        public void Selection()
        {
            for (int i = 0; i < rockets.Length; i++)
            {
                DNA parentA = matingPool[rand.Next(0, matingPool.Count)].dna;
                DNA parentB = matingPool[rand.Next(0, matingPool.Count)].dna;
                DNA child = parentA.Crossover(parentB);
                Rocket temp = new Rocket(lifetime, target, rand, b);
                temp.dna = child;
                if (mutate)
                {
                    child.Mutation(mutationRate);
                }
                newRockets[i] = temp;
            }

            rockets = newRockets;
        }
    }
}
