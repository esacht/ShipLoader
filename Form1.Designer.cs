﻿
namespace ShipLoader
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
            this.track_trainCars = new System.Windows.Forms.TrackBar();
            this.track_cars = new System.Windows.Forms.TrackBar();
            this.track_motorCycles = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_cycleCount = new System.Windows.Forms.Label();
            this.label_carCount = new System.Windows.Forms.Label();
            this.label_truckCount = new System.Windows.Forms.Label();
            this.label_trainCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_shipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // track_trainCars
            // 
            this.track_trainCars.Location = new System.Drawing.Point(431, 377);
            this.track_trainCars.Name = "track_trainCars";
            this.track_trainCars.Size = new System.Drawing.Size(268, 45);
            this.track_trainCars.TabIndex = 0;
            this.track_trainCars.Scroll += new System.EventHandler(this.track_trainCars_Scroll);
            // 
            // track_cars
            // 
            this.track_cars.Location = new System.Drawing.Point(431, 268);
            this.track_cars.Name = "track_cars";
            this.track_cars.Size = new System.Drawing.Size(268, 45);
            this.track_cars.TabIndex = 1;
            this.track_cars.Scroll += new System.EventHandler(this.track_cars_Scroll);
            // 
            // track_motorCycles
            // 
            this.track_motorCycles.Location = new System.Drawing.Point(28, 268);
            this.track_motorCycles.Name = "track_motorCycles";
            this.track_motorCycles.Size = new System.Drawing.Size(268, 45);
            this.track_motorCycles.TabIndex = 2;
            this.track_motorCycles.Scroll += new System.EventHandler(this.track_motorCycles_Scroll);
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(28, 377);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(268, 45);
            this.track_trucks.TabIndex = 3;
            this.track_trucks.Scroll += new System.EventHandler(this.track_trucks_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(165, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 86);
            this.progressBar1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShipLoader.Properties.Resources.cargoship;
            this.pictureBox1.Location = new System.Drawing.Point(28, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label_cycleCount
            // 
            this.label_cycleCount.AutoSize = true;
            this.label_cycleCount.Location = new System.Drawing.Point(89, 240);
            this.label_cycleCount.Name = "label_cycleCount";
            this.label_cycleCount.Size = new System.Drawing.Size(38, 15);
            this.label_cycleCount.TabIndex = 6;
            this.label_cycleCount.Text = "label1";
            // 
            // label_carCount
            // 
            this.label_carCount.AutoSize = true;
            this.label_carCount.Location = new System.Drawing.Point(524, 240);
            this.label_carCount.Name = "label_carCount";
            this.label_carCount.Size = new System.Drawing.Size(38, 15);
            this.label_carCount.TabIndex = 7;
            this.label_carCount.Text = "label2";
            // 
            // label_truckCount
            // 
            this.label_truckCount.AutoSize = true;
            this.label_truckCount.Location = new System.Drawing.Point(89, 345);
            this.label_truckCount.Name = "label_truckCount";
            this.label_truckCount.Size = new System.Drawing.Size(38, 15);
            this.label_truckCount.TabIndex = 8;
            this.label_truckCount.Text = "label3";
            // 
            // label_trainCount
            // 
            this.label_trainCount.AutoSize = true;
            this.label_trainCount.Location = new System.Drawing.Point(524, 345);
            this.label_trainCount.Name = "label_trainCount";
            this.label_trainCount.Size = new System.Drawing.Size(38, 15);
            this.label_trainCount.TabIndex = 9;
            this.label_trainCount.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Motor Cycles (3 units)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trucks (11 units)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cars (5 units)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Train Cars (13 units)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "New Ship";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Location = new System.Drawing.Point(108, 153);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(38, 15);
            this.label_shipLabel.TabIndex = 15;
            this.label_shipLabel.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_trainCount);
            this.Controls.Add(this.label_truckCount);
            this.Controls.Add(this.label_carCount);
            this.Controls.Add(this.label_cycleCount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_motorCycles);
            this.Controls.Add(this.track_cars);
            this.Controls.Add(this.track_trainCars);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Load The Ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar track_trainCars;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_motorCycles;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label_carCount;
        private System.Windows.Forms.Label label_truckCount;
        private System.Windows.Forms.Label label_trainCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_shipLabel;
    }
}

