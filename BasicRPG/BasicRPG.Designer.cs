namespace BasicRPG
{
    partial class BasicRPG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelHitPoints = new System.Windows.Forms.Label();
            this.LabelGold = new System.Windows.Forms.Label();
            this.LabelExp = new System.Windows.Forms.Label();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.ButtonTest = new System.Windows.Forms.Button();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moolah:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // LabelHitPoints
            // 
            this.LabelHitPoints.AutoSize = true;
            this.LabelHitPoints.Location = new System.Drawing.Point(85, 20);
            this.LabelHitPoints.Name = "LabelHitPoints";
            this.LabelHitPoints.Size = new System.Drawing.Size(0, 15);
            this.LabelHitPoints.TabIndex = 4;
            // 
            // LabelGold
            // 
            this.LabelGold.AutoSize = true;
            this.LabelGold.Location = new System.Drawing.Point(175, 20);
            this.LabelGold.Name = "LabelGold";
            this.LabelGold.Size = new System.Drawing.Size(0, 15);
            this.LabelGold.TabIndex = 5;
            // 
            // LabelExp
            // 
            this.LabelExp.AutoSize = true;
            this.LabelExp.Location = new System.Drawing.Point(255, 20);
            this.LabelExp.Name = "LabelExp";
            this.LabelExp.Size = new System.Drawing.Size(0, 15);
            this.LabelExp.TabIndex = 6;
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Location = new System.Drawing.Point(365, 20);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(0, 15);
            this.LabelLevel.TabIndex = 7;
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(220, 206);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(75, 23);
            this.ButtonTest.TabIndex = 8;
            this.ButtonTest.Text = "TEST";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // BasicRPG
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.LabelExp);
            this.Controls.Add(this.LabelGold);
            this.Controls.Add(this.LabelHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BasicRPG";
            this.Text = "DA GAME";

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelHitPoints;
        private System.Windows.Forms.Label LabelGold;
        private System.Windows.Forms.Label LabelExp;
        private System.Windows.Forms.Label IbILevel;
        private System.Windows.Forms.Label LabelLevel;
        private System.Windows.Forms.Button ButtonTest;
    }
}

