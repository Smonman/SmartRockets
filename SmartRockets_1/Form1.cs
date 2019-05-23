using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace SmartRockets_1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Load();
            Clear();
        }

        int width;
        int height;
        Bitmap mainBit;
        Graphics graphics;
        Random r = new Random();
        Vector target;
        int count;

        int intervall;
        Population pop;
        int lifespan;
        int size;
        double mutationRate;
        bool mutate;

        private void button_start_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            button_pause.Enabled = false;
            button_continue.Enabled = true;
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            timer.Start();
            button_pause.Enabled = true;
            button_continue.Enabled = false;
        }

        void Load()
        {
            button_pause.Enabled = false;
            button_continue.Enabled = false;

            Clear();
        }

        void Clear()
        {
            label_maxFitness.Text = "";
        }

        void Setup()
        {
            button_pause.Enabled = true;

            width = px.Width;
            height = px.Height;

            mainBit = new Bitmap(width, height);
            graphics = Graphics.FromImage(mainBit);

            target = new Vector(width / 2, 150);

            intervall = (int)numericUpDown_intervall.Value;
            timer.Interval = intervall;

            lifespan = (int)numericUpDown_lifespan.Value;
            size = (int)numericUpDown_size.Value;
            mutationRate = (double)numericUpDown_mutationrate.Value;
            mutate = checkBox_mutate.Checked;
            pop = new Population(size, lifespan, mutationRate, mutate, target, r, mainBit);

            count = 0;

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        void Draw()
        {
            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, width, height)); //Black BG
            graphics.FillEllipse(new SolidBrush(Color.Green), new Rectangle((int)target.X - 10, (int)target.Y - 10, 20, 20)); //Green Target
            px.Image = mainBit; //Set Image

            pop.Run(count); //Run the Populaton
            count++;
            if (count == lifespan)
            {
                label_maxFitness.Text = pop.Evaluate();
                pop.Selection();
                count = 0;
            }
        }
    }
}
