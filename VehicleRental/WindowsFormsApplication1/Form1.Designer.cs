namespace namespace VehicleRental
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.gbJourney = new System.Windows.Forms.GroupBox();
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKMT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbJourney.SuspendLayout();
            this.gbFuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Vehicle:";
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(451, 12);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(121, 21);
            this.cbVehicle.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(312, 58);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(260, 162);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "Select vehicle and click \'Go\'";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Report:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(497, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(416, 226);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // gbJourney
            // 
            this.gbJourney.Controls.Add(this.label3);
            this.gbJourney.Controls.Add(this.txtKMT);
            this.gbJourney.Location = new System.Drawing.Point(12, 12);
            this.gbJourney.Name = "gbJourney";
            this.gbJourney.Size = new System.Drawing.Size(260, 100);
            this.gbJourney.TabIndex = 6;
            this.gbJourney.TabStop = false;
            this.gbJourney.Text = "Journey";
            // 
            // gbFuel
            // 
            this.gbFuel.Controls.Add(this.label5);
            this.gbFuel.Controls.Add(this.textBox3);
            this.gbFuel.Controls.Add(this.label4);
            this.gbFuel.Controls.Add(this.txtLP);
            this.gbFuel.Location = new System.Drawing.Point(12, 120);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Size = new System.Drawing.Size(260, 100);
            this.gbFuel.TabIndex = 7;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "Fuel Purchased";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtKMT
            // 
            this.txtKMT.Location = new System.Drawing.Point(117, 24);
            this.txtKMT.Name = "txtKMT";
            this.txtKMT.Size = new System.Drawing.Size(137, 20);
            this.txtKMT.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kilometres Travelled:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Litres Purchased:";
            // 
            // txtLP
            // 
            this.txtLP.Location = new System.Drawing.Point(117, 22);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(137, 20);
            this.txtLP.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cost:";
            this.label5.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(117, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbFuel);
            this.Controls.Add(this.gbJourney);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rental Vehicles";
            this.gbJourney.ResumeLayout(false);
            this.gbJourney.PerformLayout();
            this.gbFuel.ResumeLayout(false);
            this.gbFuel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox gbJourney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKMT;
        private System.Windows.Forms.GroupBox gbFuel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLP;
        private System.Windows.Forms.Button btnAdd;
    }
}

