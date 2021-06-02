
namespace lab2_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.X = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.X_input = new System.Windows.Forms.TextBox();
            this.A_input = new System.Windows.Forms.TextBox();
            this.B_input = new System.Windows.Forms.TextBox();
            this.N_select = new System.Windows.Forms.ComboBox();
            this.R_select = new System.Windows.Forms.ComboBox();
            this.N = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.Select_equation = new System.Windows.Forms.GroupBox();
            this.Equation2 = new System.Windows.Forms.RadioButton();
            this.Equaiton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Label();
            this.Z_box = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.Label();
            this.M_input = new System.Windows.Forms.NumericUpDown();
            this.Select_equation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_input)).BeginInit();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(53, 47);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(18, 20);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(53, 154);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(17, 20);
            this.a.TabIndex = 1;
            this.a.Text = "a";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(52, 212);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(18, 20);
            this.b.TabIndex = 2;
            this.b.Text = "b";
            // 
            // X_input
            // 
            this.X_input.Location = new System.Drawing.Point(76, 44);
            this.X_input.Name = "X_input";
            this.X_input.Size = new System.Drawing.Size(139, 27);
            this.X_input.TabIndex = 3;
            // 
            // A_input
            // 
            this.A_input.Location = new System.Drawing.Point(76, 151);
            this.A_input.Name = "A_input";
            this.A_input.Size = new System.Drawing.Size(139, 27);
            this.A_input.TabIndex = 4;
            // 
            // B_input
            // 
            this.B_input.Location = new System.Drawing.Point(76, 209);
            this.B_input.Name = "B_input";
            this.B_input.Size = new System.Drawing.Size(139, 27);
            this.B_input.TabIndex = 5;
            // 
            // N_select
            // 
            this.N_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.N_select.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "100",
            "1280",
            "7000"});
            this.N_select.Location = new System.Drawing.Point(281, 43);
            this.N_select.Name = "N_select";
            this.N_select.Size = new System.Drawing.Size(168, 28);
            this.N_select.TabIndex = 6;
            // 
            // R_select
            // 
            this.R_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R_select.FormattingEnabled = true;
            this.R_select.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "50",
            "500",
            "1000",
            "3000"});
            this.R_select.Location = new System.Drawing.Point(281, 99);
            this.R_select.Name = "R_select";
            this.R_select.Size = new System.Drawing.Size(168, 28);
            this.R_select.TabIndex = 7;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(255, 46);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(20, 20);
            this.N.TabIndex = 8;
            this.N.Text = "N";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(257, 102);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(18, 20);
            this.R.TabIndex = 9;
            this.R.Text = "R";
            // 
            // Select_equation
            // 
            this.Select_equation.Controls.Add(this.Equation2);
            this.Select_equation.Controls.Add(this.Equaiton1);
            this.Select_equation.Location = new System.Drawing.Point(537, 22);
            this.Select_equation.Name = "Select_equation";
            this.Select_equation.Size = new System.Drawing.Size(196, 120);
            this.Select_equation.TabIndex = 10;
            this.Select_equation.TabStop = false;
            this.Select_equation.Text = "Выбор уравнения";
            // 
            // Equation2
            // 
            this.Equation2.AutoSize = true;
            this.Equation2.Location = new System.Drawing.Point(43, 81);
            this.Equation2.Name = "Equation2";
            this.Equation2.Size = new System.Drawing.Size(119, 24);
            this.Equation2.TabIndex = 1;
            this.Equation2.TabStop = true;
            this.Equation2.Text = "Уравнение 2";
            this.Equation2.UseVisualStyleBackColor = true;
            // 
            // Equaiton1
            // 
            this.Equaiton1.AutoSize = true;
            this.Equaiton1.Location = new System.Drawing.Point(43, 39);
            this.Equaiton1.Name = "Equaiton1";
            this.Equaiton1.Size = new System.Drawing.Size(119, 24);
            this.Equaiton1.TabIndex = 0;
            this.Equaiton1.TabStop = true;
            this.Equaiton1.Text = "Уравнение 1";
            this.Equaiton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(485, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 113);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Calculate
            // 
            this.Calculate.Image = ((System.Drawing.Image)(resources.GetObject("Calculate.Image")));
            this.Calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calculate.Location = new System.Drawing.Point(87, 284);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(299, 92);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Вычислить";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calcualte_Z);
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Location = new System.Drawing.Point(513, 320);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(18, 20);
            this.Z.TabIndex = 13;
            this.Z.Text = "Z";
            // 
            // Z_box
            // 
            this.Z_box.Location = new System.Drawing.Point(537, 317);
            this.Z_box.Name = "Z_box";
            this.Z_box.ReadOnly = true;
            this.Z_box.Size = new System.Drawing.Size(231, 27);
            this.Z_box.TabIndex = 14;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(48, 99);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(22, 20);
            this.M.TabIndex = 15;
            this.M.Text = "M";
            // 
            // M_input
            // 
            this.M_input.Location = new System.Drawing.Point(76, 97);
            this.M_input.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.M_input.Name = "M_input";
            this.M_input.Size = new System.Drawing.Size(139, 27);
            this.M_input.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.M_input);
            this.Controls.Add(this.M);
            this.Controls.Add(this.Z_box);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Select_equation);
            this.Controls.Add(this.R);
            this.Controls.Add(this.N);
            this.Controls.Add(this.R_select);
            this.Controls.Add(this.N_select);
            this.Controls.Add(this.B_input);
            this.Controls.Add(this.A_input);
            this.Controls.Add(this.X_input);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.X);
            this.Name = "Form1";
            this.Text = "Lab2_1";
            this.Select_equation.ResumeLayout(false);
            this.Select_equation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox X_input;
        private System.Windows.Forms.TextBox A_input;
        private System.Windows.Forms.TextBox B_input;
        private System.Windows.Forms.ComboBox N_select;
        private System.Windows.Forms.ComboBox R_select;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.GroupBox Select_equation;
        private System.Windows.Forms.RadioButton Equation2;
        private System.Windows.Forms.RadioButton Equaiton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.TextBox Z_box;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.NumericUpDown M_input;
    }
}

