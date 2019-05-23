namespace SmartRockets_1 {
	partial class Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.px = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button_continue = new System.Windows.Forms.Button();
			this.button_pause = new System.Windows.Forms.Button();
			this.button_start = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_mutationrate = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label_maxFitness = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_lifespan = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_intervall = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBox_mutate = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.px)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mutationrate)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lifespan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_intervall)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.px, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.77858F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.22142F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1191, 691);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// px
			// 
			this.px.Dock = System.Windows.Forms.DockStyle.Fill;
			this.px.Location = new System.Drawing.Point(3, 3);
			this.px.Name = "px";
			this.px.Size = new System.Drawing.Size(1185, 565);
			this.px.TabIndex = 0;
			this.px.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button_continue);
			this.groupBox1.Controls.Add(this.button_pause);
			this.groupBox1.Controls.Add(this.button_start);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 574);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1185, 114);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Controlls";
			// 
			// button_continue
			// 
			this.button_continue.Location = new System.Drawing.Point(1101, 77);
			this.button_continue.Name = "button_continue";
			this.button_continue.Size = new System.Drawing.Size(75, 23);
			this.button_continue.TabIndex = 6;
			this.button_continue.Text = "Continue";
			this.button_continue.UseVisualStyleBackColor = true;
			this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
			// 
			// button_pause
			// 
			this.button_pause.Location = new System.Drawing.Point(1101, 48);
			this.button_pause.Name = "button_pause";
			this.button_pause.Size = new System.Drawing.Size(75, 23);
			this.button_pause.TabIndex = 5;
			this.button_pause.Text = "Pause";
			this.button_pause.UseVisualStyleBackColor = true;
			this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
			// 
			// button_start
			// 
			this.button_start.Location = new System.Drawing.Point(1101, 19);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(75, 23);
			this.button_start.TabIndex = 4;
			this.button_start.Text = "Start";
			this.button_start.UseVisualStyleBackColor = true;
			this.button_start.Click += new System.EventHandler(this.button_start_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.checkBox_mutate);
			this.groupBox5.Controls.Add(this.numericUpDown_mutationrate);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(274, 19);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(136, 86);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "DNA";
			// 
			// numericUpDown_mutationrate
			// 
			this.numericUpDown_mutationrate.DecimalPlaces = 2;
			this.numericUpDown_mutationrate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_mutationrate.Location = new System.Drawing.Point(78, 14);
			this.numericUpDown_mutationrate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numericUpDown_mutationrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_mutationrate.Name = "numericUpDown_mutationrate";
			this.numericUpDown_mutationrate.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_mutationrate.TabIndex = 1;
			this.numericUpDown_mutationrate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mutationrate";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label_maxFitness);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Location = new System.Drawing.Point(416, 19);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(200, 86);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Information";
			// 
			// label_maxFitness
			// 
			this.label_maxFitness.AutoSize = true;
			this.label_maxFitness.Location = new System.Drawing.Point(78, 16);
			this.label_maxFitness.Name = "label_maxFitness";
			this.label_maxFitness.Size = new System.Drawing.Size(75, 13);
			this.label_maxFitness.TabIndex = 1;
			this.label_maxFitness.Text = "MAXFITNESS";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Max Fitness:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.numericUpDown_lifespan);
			this.groupBox3.Controls.Add(this.numericUpDown_size);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(132, 19);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(136, 86);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Population";
			// 
			// numericUpDown_lifespan
			// 
			this.numericUpDown_lifespan.Location = new System.Drawing.Point(75, 40);
			this.numericUpDown_lifespan.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numericUpDown_lifespan.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDown_lifespan.Name = "numericUpDown_lifespan";
			this.numericUpDown_lifespan.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_lifespan.TabIndex = 3;
			this.numericUpDown_lifespan.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDown_size
			// 
			this.numericUpDown_size.Location = new System.Drawing.Point(75, 14);
			this.numericUpDown_size.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDown_size.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_size.Name = "numericUpDown_size";
			this.numericUpDown_size.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_size.TabIndex = 2;
			this.numericUpDown_size.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Lifespan";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Size";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numericUpDown_intervall);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(9, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(117, 86);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Timer";
			// 
			// numericUpDown_intervall
			// 
			this.numericUpDown_intervall.Location = new System.Drawing.Point(56, 14);
			this.numericUpDown_intervall.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_intervall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_intervall.Name = "numericUpDown_intervall";
			this.numericUpDown_intervall.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_intervall.TabIndex = 1;
			this.numericUpDown_intervall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Intervall";
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// checkBox_mutate
			// 
			this.checkBox_mutate.AutoSize = true;
			this.checkBox_mutate.Checked = true;
			this.checkBox_mutate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_mutate.Location = new System.Drawing.Point(9, 41);
			this.checkBox_mutate.Name = "checkBox_mutate";
			this.checkBox_mutate.Size = new System.Drawing.Size(59, 17);
			this.checkBox_mutate.TabIndex = 2;
			this.checkBox_mutate.Text = "Mutate";
			this.checkBox_mutate.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1191, 691);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.ShowIcon = false;
			this.Text = "Smart Rockets";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.px)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mutationrate)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lifespan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_intervall)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox px;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.NumericUpDown numericUpDown_intervall;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown_size;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown_lifespan;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.NumericUpDown numericUpDown_mutationrate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label_maxFitness;
		private System.Windows.Forms.Button button_start;
		private System.Windows.Forms.Button button_pause;
		private System.Windows.Forms.Button button_continue;
		private System.Windows.Forms.CheckBox checkBox_mutate;
	}
}

