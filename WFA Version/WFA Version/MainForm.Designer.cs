namespace WFA_Version
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.txtBx_target = new System.Windows.Forms.TextBox();
      this.trkbar_maxGenerations = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_maxGenerations = new System.Windows.Forms.Label();
      this.trkbar_populationSize = new System.Windows.Forms.TrackBar();
      this.lbl_populationSize = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.trkBar_mutationRate = new System.Windows.Forms.TrackBar();
      this.lbl_mutationRate = new System.Windows.Forms.Label();
      this.trkBar_crossoverRate = new System.Windows.Forms.TrackBar();
      this.label5 = new System.Windows.Forms.Label();
      this.lbl_crossoverRate = new System.Windows.Forms.Label();
      this.lbl_numMates = new System.Windows.Forms.Label();
      this.trkBar_numMates = new System.Windows.Forms.TrackBar();
      this.label7 = new System.Windows.Forms.Label();
      this.btn_run = new System.Windows.Forms.Button();
      this.btn_reset = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel6 = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.lstBx_output = new System.Windows.Forms.ListBox();
      this.btn_about = new System.Windows.Forms.Button();
      this.lbl_time = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.trkbar_maxGenerations)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkbar_populationSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkBar_mutationRate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkBar_crossoverRate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkBar_numMates)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel6.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtBx_target
      // 
      this.txtBx_target.Location = new System.Drawing.Point(3, 31);
      this.txtBx_target.MaxLength = 50;
      this.txtBx_target.Name = "txtBx_target";
      this.txtBx_target.Size = new System.Drawing.Size(150, 25);
      this.txtBx_target.TabIndex = 0;
      this.txtBx_target.Text = "Enter text";
      this.txtBx_target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // trkbar_maxGenerations
      // 
      this.trkbar_maxGenerations.Cursor = System.Windows.Forms.Cursors.Hand;
      this.trkbar_maxGenerations.LargeChange = 100;
      this.trkbar_maxGenerations.Location = new System.Drawing.Point(3, 31);
      this.trkbar_maxGenerations.Maximum = 500;
      this.trkbar_maxGenerations.Minimum = 100;
      this.trkbar_maxGenerations.Name = "trkbar_maxGenerations";
      this.trkbar_maxGenerations.Size = new System.Drawing.Size(150, 45);
      this.trkbar_maxGenerations.TabIndex = 1;
      this.trkbar_maxGenerations.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trkbar_maxGenerations.Value = 200;
      this.trkbar_maxGenerations.Scroll += new System.EventHandler(this.trkbar_maxGenerations_Scroll);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 17);
      this.label1.TabIndex = 100;
      this.label1.Text = "Target";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(107, 17);
      this.label2.TabIndex = 100;
      this.label2.Text = "Max Generations";
      // 
      // lbl_maxGenerations
      // 
      this.lbl_maxGenerations.AutoSize = true;
      this.lbl_maxGenerations.Location = new System.Drawing.Point(153, 31);
      this.lbl_maxGenerations.Name = "lbl_maxGenerations";
      this.lbl_maxGenerations.Size = new System.Drawing.Size(0, 17);
      this.lbl_maxGenerations.TabIndex = 4;
      // 
      // trkbar_populationSize
      // 
      this.trkbar_populationSize.Cursor = System.Windows.Forms.Cursors.Hand;
      this.trkbar_populationSize.LargeChange = 100;
      this.trkbar_populationSize.Location = new System.Drawing.Point(3, 31);
      this.trkbar_populationSize.Maximum = 1000;
      this.trkbar_populationSize.Minimum = 100;
      this.trkbar_populationSize.Name = "trkbar_populationSize";
      this.trkbar_populationSize.Size = new System.Drawing.Size(150, 45);
      this.trkbar_populationSize.TabIndex = 2;
      this.trkbar_populationSize.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trkbar_populationSize.Value = 500;
      this.trkbar_populationSize.Scroll += new System.EventHandler(this.trkbar_populationSize_Scroll);
      // 
      // lbl_populationSize
      // 
      this.lbl_populationSize.AutoSize = true;
      this.lbl_populationSize.Location = new System.Drawing.Point(153, 31);
      this.lbl_populationSize.Name = "lbl_populationSize";
      this.lbl_populationSize.Size = new System.Drawing.Size(0, 17);
      this.lbl_populationSize.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(27, 11);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(97, 17);
      this.label3.TabIndex = 100;
      this.label3.Text = "Population Size";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(30, 11);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 17);
      this.label4.TabIndex = 100;
      this.label4.Text = "Mutation Rate";
      // 
      // trkBar_mutationRate
      // 
      this.trkBar_mutationRate.Cursor = System.Windows.Forms.Cursors.Hand;
      this.trkBar_mutationRate.LargeChange = 1;
      this.trkBar_mutationRate.Location = new System.Drawing.Point(3, 31);
      this.trkBar_mutationRate.Maximum = 5;
      this.trkBar_mutationRate.Name = "trkBar_mutationRate";
      this.trkBar_mutationRate.Size = new System.Drawing.Size(150, 45);
      this.trkBar_mutationRate.TabIndex = 4;
      this.trkBar_mutationRate.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trkBar_mutationRate.Value = 2;
      this.trkBar_mutationRate.Scroll += new System.EventHandler(this.trkBar_mutationRate_Scroll);
      // 
      // lbl_mutationRate
      // 
      this.lbl_mutationRate.AutoSize = true;
      this.lbl_mutationRate.Location = new System.Drawing.Point(153, 31);
      this.lbl_mutationRate.Name = "lbl_mutationRate";
      this.lbl_mutationRate.Size = new System.Drawing.Size(0, 17);
      this.lbl_mutationRate.TabIndex = 12;
      // 
      // trkBar_crossoverRate
      // 
      this.trkBar_crossoverRate.Cursor = System.Windows.Forms.Cursors.Hand;
      this.trkBar_crossoverRate.Location = new System.Drawing.Point(3, 31);
      this.trkBar_crossoverRate.Maximum = 100;
      this.trkBar_crossoverRate.Name = "trkBar_crossoverRate";
      this.trkBar_crossoverRate.Size = new System.Drawing.Size(150, 45);
      this.trkBar_crossoverRate.TabIndex = 3;
      this.trkBar_crossoverRate.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trkBar_crossoverRate.Value = 50;
      this.trkBar_crossoverRate.Scroll += new System.EventHandler(this.trkBar_crossoverRate_Scroll);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(27, 11);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(97, 17);
      this.label5.TabIndex = 100;
      this.label5.Text = "Crossover Rate";
      // 
      // lbl_crossoverRate
      // 
      this.lbl_crossoverRate.AutoSize = true;
      this.lbl_crossoverRate.Location = new System.Drawing.Point(153, 31);
      this.lbl_crossoverRate.Name = "lbl_crossoverRate";
      this.lbl_crossoverRate.Size = new System.Drawing.Size(0, 17);
      this.lbl_crossoverRate.TabIndex = 15;
      // 
      // lbl_numMates
      // 
      this.lbl_numMates.AutoSize = true;
      this.lbl_numMates.Location = new System.Drawing.Point(153, 31);
      this.lbl_numMates.Name = "lbl_numMates";
      this.lbl_numMates.Size = new System.Drawing.Size(0, 17);
      this.lbl_numMates.TabIndex = 18;
      // 
      // trkBar_numMates
      // 
      this.trkBar_numMates.Cursor = System.Windows.Forms.Cursors.Hand;
      this.trkBar_numMates.LargeChange = 2;
      this.trkBar_numMates.Location = new System.Drawing.Point(3, 31);
      this.trkBar_numMates.Maximum = 20;
      this.trkBar_numMates.Minimum = 2;
      this.trkBar_numMates.Name = "trkBar_numMates";
      this.trkBar_numMates.Size = new System.Drawing.Size(150, 45);
      this.trkBar_numMates.TabIndex = 5;
      this.trkBar_numMates.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trkBar_numMates.Value = 10;
      this.trkBar_numMates.Scroll += new System.EventHandler(this.trkBar_numMates_Scroll);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(19, 11);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(112, 17);
      this.label7.TabIndex = 100;
      this.label7.Text = "Number of Mates";
      // 
      // btn_run
      // 
      this.btn_run.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_run.Location = new System.Drawing.Point(33, 557);
      this.btn_run.Name = "btn_run";
      this.btn_run.Size = new System.Drawing.Size(150, 42);
      this.btn_run.TabIndex = 6;
      this.btn_run.Text = "RUN";
      this.btn_run.UseVisualStyleBackColor = true;
      this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
      // 
      // btn_reset
      // 
      this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btn_reset.Location = new System.Drawing.Point(33, 615);
      this.btn_reset.Name = "btn_reset";
      this.btn_reset.Size = new System.Drawing.Size(150, 42);
      this.btn_reset.TabIndex = 7;
      this.btn_reset.Text = "RESET";
      this.btn_reset.UseVisualStyleBackColor = true;
      this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.trkbar_maxGenerations);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.lbl_maxGenerations);
      this.panel1.Location = new System.Drawing.Point(30, 110);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(202, 79);
      this.panel1.TabIndex = 21;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.trkbar_populationSize);
      this.panel2.Controls.Add(this.lbl_populationSize);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Location = new System.Drawing.Point(30, 195);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(202, 79);
      this.panel2.TabIndex = 22;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.trkBar_mutationRate);
      this.panel3.Controls.Add(this.label4);
      this.panel3.Controls.Add(this.lbl_mutationRate);
      this.panel3.Location = new System.Drawing.Point(30, 365);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(202, 79);
      this.panel3.TabIndex = 24;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.trkBar_crossoverRate);
      this.panel4.Controls.Add(this.label5);
      this.panel4.Controls.Add(this.lbl_crossoverRate);
      this.panel4.Location = new System.Drawing.Point(30, 280);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(202, 79);
      this.panel4.TabIndex = 23;
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.trkBar_numMates);
      this.panel5.Controls.Add(this.label7);
      this.panel5.Controls.Add(this.lbl_numMates);
      this.panel5.Location = new System.Drawing.Point(30, 450);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(202, 79);
      this.panel5.TabIndex = 25;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.txtBx_target);
      this.panel6.Controls.Add(this.label1);
      this.panel6.Location = new System.Drawing.Point(30, 25);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(202, 79);
      this.panel6.TabIndex = 26;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(412, 36);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(136, 17);
      this.label6.TabIndex = 100;
      this.label6.Text = "Results From Last Run";
      // 
      // lstBx_output
      // 
      this.lstBx_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lstBx_output.FormattingEnabled = true;
      this.lstBx_output.ItemHeight = 17;
      this.lstBx_output.Location = new System.Drawing.Point(260, 56);
      this.lstBx_output.Name = "lstBx_output";
      this.lstBx_output.SelectionMode = System.Windows.Forms.SelectionMode.None;
      this.lstBx_output.Size = new System.Drawing.Size(433, 597);
      this.lstBx_output.TabIndex = 8;
      // 
      // btn_about
      // 
      this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_about.Location = new System.Drawing.Point(618, 691);
      this.btn_about.Name = "btn_about";
      this.btn_about.Size = new System.Drawing.Size(75, 32);
      this.btn_about.TabIndex = 9;
      this.btn_about.Text = "about";
      this.btn_about.UseVisualStyleBackColor = true;
      this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
      // 
      // lbl_time
      // 
      this.lbl_time.AutoSize = true;
      this.lbl_time.Location = new System.Drawing.Point(257, 656);
      this.lbl_time.Name = "lbl_time";
      this.lbl_time.Size = new System.Drawing.Size(0, 17);
      this.lbl_time.TabIndex = 101;
      // 
      // MainForm
      // 
      this.AcceptButton = this.btn_run;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btn_reset;
      this.ClientSize = new System.Drawing.Size(729, 735);
      this.Controls.Add(this.lbl_time);
      this.Controls.Add(this.btn_about);
      this.Controls.Add(this.lstBx_output);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btn_reset);
      this.Controls.Add(this.btn_run);
      this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Genetic Algorithm";
      ((System.ComponentModel.ISupportInitialize)(this.trkbar_maxGenerations)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkbar_populationSize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkBar_mutationRate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkBar_crossoverRate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkBar_numMates)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_target;
        private System.Windows.Forms.TrackBar trkbar_maxGenerations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_maxGenerations;
        private System.Windows.Forms.TrackBar trkbar_populationSize;
        private System.Windows.Forms.Label lbl_populationSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkBar_mutationRate;
        private System.Windows.Forms.Label lbl_mutationRate;
        private System.Windows.Forms.TrackBar trkBar_crossoverRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_crossoverRate;
        private System.Windows.Forms.Label lbl_numMates;
        private System.Windows.Forms.TrackBar trkBar_numMates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox lstBx_output;
    private System.Windows.Forms.Button btn_about;
    private System.Windows.Forms.Label lbl_time;
  }
}

