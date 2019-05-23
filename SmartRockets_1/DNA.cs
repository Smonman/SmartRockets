using System;
using System.Windows;

namespace SmartRockets_1
{
    class DNA
    {
        public Vector[] genes;
        Random r;
        int lifespan;
        public DNA(int lifespan, Random r)
        {
            this.r = r;
            this.lifespan = lifespan;

            genes = new Vector[lifespan];
            for (int i = 0; i < lifespan; i++)
            {
                Vector v = new Vector(r.Next(-90, 90), r.Next(-10, 0));
                v.Normalize();
                genes[i] = v;
            }
        }

        public DNA Crossover(DNA partner)
        {
            DNA newDNA = new DNA(lifespan, r);
            int mid = r.Next(0, genes.Length);
            for (int i = 0; i < genes.Length; i++)
            {
                if (i > mid)
                {
                    newDNA.genes[i] = genes[i];
                }
                else
                {
                    newDNA.genes[i] = partner.genes[i];
                }
            }
            return newDNA;
        }

        public void Mutation(double rate)
        {
            for (int i = 0; i < genes.Length; i++)
            {
                if (r.Next() < rate)
                {
                    Vector temp = new Vector(r.Next(-90, 90), r.Next(-10, 0));
                    temp.Normalize();
                    genes[i] = temp;
                }
            }
        }
    }
}
