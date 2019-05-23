using System;
using System.Drawing;
using System.Windows;

namespace SmartRockets_1
{
    class Rocket
    {
        Vector pos;
        Vector vel;
        Vector acc;

        public DNA dna;

        Vector target;
        Bitmap b;

        public double fitness;
        double distance;
        bool completed;
        bool crashed;

        public Rocket(int life, Vector target, Random r, Bitmap b)
        {
            this.b = b;
            pos = new Vector(b.Width / 2, b.Height);
            vel = new Vector();
            acc = new Vector();
            dna = new DNA(life, r);
            fitness = 0;
            this.target = target;
            completed = false;
            crashed = false;
        }

        public void AddForce(Vector force)
        {
            acc += force;
        }

        public void Update(int count)
        {
            if (!completed && !crashed)
            {
                AddForce(dna.genes[count]);
                vel += acc;
                pos += vel;
                acc *= 0;

                if (pos.X < 0 || pos.X > b.Width || pos.Y < 0 || pos.Y > b.Height)
                {
                    crashed = true;
                }
            }

            distance = Math.Sqrt(Math.Pow(pos.X - target.X, 2) + Math.Pow(pos.Y - target.Y, 2));
            if (distance < 10)
            {
                completed = true;
            }
        }

        public void Show(Bitmap b)
        {
            Graphics g = Graphics.FromImage(b);

            Color rocketColor;
            if (completed)
            {
                rocketColor = Color.LawnGreen;
            }
            else if (crashed)
            {
                rocketColor = Color.Red;
            }
            else
            {
                rocketColor = Color.White;
            }

            g.FillEllipse(new SolidBrush(rocketColor), new Rectangle((int)pos.X - 5, (int)pos.Y - 5, 10, 10));
        }

        public void CalculateFitness()
        {
            distance = Math.Sqrt(Math.Pow(pos.X - target.X, 2) + Math.Pow(pos.Y - target.Y, 2));
            fitness = 1 / distance * 100;

            if (completed)
            {
                fitness *= 10;
            }
            if (crashed)
            {
                fitness /= 10;
            }
        }
    }
}
