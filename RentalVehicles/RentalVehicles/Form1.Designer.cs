namespace RentalVehicles
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtKMtravelled = new System.Windows.Forms.TextBox();
            this.txtFuelCost = new System.Windows.Forms.TextBox();
            this.lblKMtravelled = new System.Windows.Forms.Label();
            this.lblFuelCost = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMakeYear = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTKMT = new System.Windows.Forms.Label();
            this.txtTFP = new System.Windows.Forms.TextBox();
            this.txtTKMT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(66, 270);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtKMtravelled
            // 
            this.txtKMtravelled.Location = new System.Drawing.Point(122, 206);
            this.txtKMtravelled.Name = "txtKMtravelled";
            this.txtKMtravelled.Size = new System.Drawing.Size(100, 20);
            this.txtKMtravelled.TabIndex = 1;
            this.txtKMtravelled.Text = "100";
            // 
            // txtFuelCost
            // 
            this.txtFuelCost.Location = new System.Drawing.Point(122, 232);
            this.txtFuelCost.Name = "txtFuelCost";
            this.txtFuelCost.Size = new System.Drawing.Size(100, 20);
            this.txtFuelCost.TabIndex = 2;
            this.txtFuelCost.Text = "10";
            // 
            // lblKMtravelled
            // 
            this.lblKMtravelled.AutoSize = true;
            this.lblKMtravelled.Location = new System.Drawing.Point(18, 206);
            this.lblKMtravelled.Name = "lblKMtravelled";
            this.lblKMtravelled.Size = new System.Drawing.Size(73, 13);
            this.lblKMtravelled.TabIndex = 3;
            this.lblKMtravelled.Text = "KM Travelled:";
            // 
            // lblFuelCost
            // 
            this.lblFuelCost.AutoSize = true;
            this.lblFuelCost.Location = new System.Drawing.Point(18, 232);
            this.lblFuelCost.Name = "lblFuelCost";
            this.lblFuelCost.Size = new System.Drawing.Size(84, 13);
            this.lblFuelCost.TabIndex = 4;
            this.lblFuelCost.Text = "Fuel Purchased:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(18, 38);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(18, 12);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 7;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(122, 38);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 6;
            this.txtModel.Text = "T812";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Enabled = false;
            this.txtManufacturer.Location = new System.Drawing.Point(122, 12);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturer.TabIndex = 5;
            this.txtManufacturer.Text = "Ford";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reg. Number :";
            // 
            // lblMakeYear
            // 
            this.lblMakeYear.AutoSize = true;
            this.lblMakeYear.Location = new System.Drawing.Point(19, 64);
            this.lblMakeYear.Name = "lblMakeYear";
            this.lblMakeYear.Size = new System.Drawing.Size(62, 13);
            this.lblMakeYear.TabIndex = 11;
            this.lblMakeYear.Text = "Make Year:";
            // 
            // txtReg
            // 
            this.txtReg.Enabled = false;
            this.txtReg.Location = new System.Drawing.Point(123, 90);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(100, 20);
            this.txtReg.TabIndex = 10;
            this.txtReg.Text = "1 ABD 760";
            // 
            // txtMake
            // 
            this.txtMake.Enabled = false;
            this.txtMake.Location = new System.Drawing.Point(123, 64);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 9;
            this.txtMake.Text = "2014";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(147, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total FP:";
            // 
            // lblTKMT
            // 
            this.lblTKMT.AutoSize = true;
            this.lblTKMT.Location = new System.Drawing.Point(19, 116);
            this.lblTKMT.Name = "lblTKMT";
            this.lblTKMT.Size = new System.Drawing.Size(60, 13);
            this.lblTKMT.TabIndex = 17;
            this.lblTKMT.Text = "Total KMT:";
            // 
            // txtTFP
            // 
            this.txtTFP.Enabled = false;
            this.txtTFP.Location = new System.Drawing.Point(123, 142);
            this.txtTFP.Name = "txtTFP";
            this.txtTFP.Size = new System.Drawing.Size(100, 20);
            this.txtTFP.TabIndex = 16;
            this.txtTFP.Text = "1";
            // 
            // txtTKMT
            // 
            this.txtTKMT.Enabled = false;
            this.txtTKMT.Location = new System.Drawing.Point(123, 116);
            this.txtTKMT.Name = "txtTKMT";
            this.txtTKMT.Size = new System.Drawing.Size(100, 20);
            this.txtTKMT.TabIndex = 15;
            this.txtTKMT.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTKMT);
            this.Controls.Add(this.txtTFP);
            this.Controls.Add(this.txtTKMT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMakeYear);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblFuelCost);
            this.Controls.Add(this.lblKMtravelled);
            this.Controls.Add(this.txtFuelCost);
            this.Controls.Add(this.txtKMtravelled);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtKMtravelled;
        private System.Windows.Forms.TextBox txtFuelCost;
        private System.Windows.Forms.Label lblKMtravelled;
        private System.Windows.Forms.Label lblFuelCost;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMakeYear;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTKMT;
        private System.Windows.Forms.TextBox txtTFP;
        private System.Windows.Forms.TextBox txtTKMT;
    }
}

