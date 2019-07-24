namespace Depths
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerHealthLbl = new System.Windows.Forms.Label();
            this.PlayerDefenceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerMentalPowerLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerAttackLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PlayerLevelLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PlayerEnergyLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP";
            // 
            // PlayerHealthLbl
            // 
            this.PlayerHealthLbl.AutoSize = true;
            this.PlayerHealthLbl.Location = new System.Drawing.Point(77, 11);
            this.PlayerHealthLbl.Name = "PlayerHealthLbl";
            this.PlayerHealthLbl.Size = new System.Drawing.Size(13, 13);
            this.PlayerHealthLbl.TabIndex = 1;
            this.PlayerHealthLbl.Text = "0";
            this.PlayerHealthLbl.Click += new System.EventHandler(this.PlayerHealthLbl_Click);
            // 
            // PlayerDefenceLbl
            // 
            this.PlayerDefenceLbl.AutoSize = true;
            this.PlayerDefenceLbl.Location = new System.Drawing.Point(77, 34);
            this.PlayerDefenceLbl.Name = "PlayerDefenceLbl";
            this.PlayerDefenceLbl.Size = new System.Drawing.Size(13, 13);
            this.PlayerDefenceLbl.TabIndex = 3;
            this.PlayerDefenceLbl.Text = "0";
            this.PlayerDefenceLbl.Click += new System.EventHandler(this.PlayerDefenceLbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Defence";
            // 
            // PlayerMentalPowerLbl
            // 
            this.PlayerMentalPowerLbl.AutoSize = true;
            this.PlayerMentalPowerLbl.Location = new System.Drawing.Point(77, 100);
            this.PlayerMentalPowerLbl.Name = "PlayerMentalPowerLbl";
            this.PlayerMentalPowerLbl.Size = new System.Drawing.Size(13, 13);
            this.PlayerMentalPowerLbl.TabIndex = 7;
            this.PlayerMentalPowerLbl.Text = "0";
            this.PlayerMentalPowerLbl.Click += new System.EventHandler(this.PlayerMentalPowerLbl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Energy";
            // 
            // PlayerAttackLbl
            // 
            this.PlayerAttackLbl.AutoSize = true;
            this.PlayerAttackLbl.Location = new System.Drawing.Point(77, 56);
            this.PlayerAttackLbl.Name = "PlayerAttackLbl";
            this.PlayerAttackLbl.Size = new System.Drawing.Size(13, 13);
            this.PlayerAttackLbl.TabIndex = 5;
            this.PlayerAttackLbl.Text = "0";
            this.PlayerAttackLbl.Click += new System.EventHandler(this.PlayerAttackLbl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Attack";
            // 
            // PlayerLevelLbl
            // 
            this.PlayerLevelLbl.AutoSize = true;
            this.PlayerLevelLbl.Location = new System.Drawing.Point(77, 136);
            this.PlayerLevelLbl.Name = "PlayerLevelLbl";
            this.PlayerLevelLbl.Size = new System.Drawing.Size(13, 13);
            this.PlayerLevelLbl.TabIndex = 11;
            this.PlayerLevelLbl.Text = "0";
            this.PlayerLevelLbl.Click += new System.EventHandler(this.PlayerLevelLbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Level";
            // 
            // PlayerEnergyLbl
            // 
            this.PlayerEnergyLbl.AutoSize = true;
            this.PlayerEnergyLbl.Location = new System.Drawing.Point(77, 78);
            this.PlayerEnergyLbl.Name = "PlayerEnergyLbl";
            this.PlayerEnergyLbl.Size = new System.Drawing.Size(13, 13);
            this.PlayerEnergyLbl.TabIndex = 9;
            this.PlayerEnergyLbl.Text = "0";
            this.PlayerEnergyLbl.Click += new System.EventHandler(this.PlayerEnergyLbl_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 26);
            this.label12.TabIndex = 8;
            this.label12.Text = "Mental\r\n Power";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 658);
            this.Controls.Add(this.PlayerLevelLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PlayerEnergyLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PlayerMentalPowerLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlayerAttackLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PlayerDefenceLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlayerHealthLbl);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Depths";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerHealthLbl;
        private System.Windows.Forms.Label PlayerDefenceLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlayerMentalPowerLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PlayerAttackLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PlayerLevelLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label PlayerEnergyLbl;
        private System.Windows.Forms.Label label12;
    }
}

