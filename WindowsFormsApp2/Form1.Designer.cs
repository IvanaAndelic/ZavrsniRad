namespace ZavrsniRad
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
            this.label2 = new System.Windows.Forms.Label();
            this.FunkcijaTxt = new System.Windows.Forms.TextBox();
            this.IntervalOdTxt = new System.Windows.Forms.TextBox();
            this.IntervalDoTxt = new System.Windows.Forms.TextBox();
            this.NacrtajButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BrojTocakaTxt = new System.Windows.Forms.TextBox();
            this.grid1 = new DiagramGrid.Controls.Grid();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "funkcija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "interval";
            // 
            // FunkcijaTxt
            // 
            this.FunkcijaTxt.Location = new System.Drawing.Point(151, 22);
            this.FunkcijaTxt.Name = "FunkcijaTxt";
            this.FunkcijaTxt.Size = new System.Drawing.Size(100, 20);
            this.FunkcijaTxt.TabIndex = 3;
            // 
            // IntervalOdTxt
            // 
            this.IntervalOdTxt.Location = new System.Drawing.Point(151, 52);
            this.IntervalOdTxt.Name = "IntervalOdTxt";
            this.IntervalOdTxt.Size = new System.Drawing.Size(41, 20);
            this.IntervalOdTxt.TabIndex = 4;
            // 
            // IntervalDoTxt
            // 
            this.IntervalDoTxt.Location = new System.Drawing.Point(209, 52);
            this.IntervalDoTxt.Name = "IntervalDoTxt";
            this.IntervalDoTxt.Size = new System.Drawing.Size(42, 20);
            this.IntervalDoTxt.TabIndex = 5;
            // 
            // NacrtajButton
            // 
            this.NacrtajButton.Location = new System.Drawing.Point(286, 22);
            this.NacrtajButton.Name = "NacrtajButton";
            this.NacrtajButton.Size = new System.Drawing.Size(75, 23);
            this.NacrtajButton.TabIndex = 6;
            this.NacrtajButton.Text = "nacrtaj";
            this.NacrtajButton.UseVisualStyleBackColor = true;
            this.NacrtajButton.Click += new System.EventHandler(this.NacrtajButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "broj točaka";
            // 
            // BrojTocakaTxt
            // 
            this.BrojTocakaTxt.Location = new System.Drawing.Point(465, 24);
            this.BrojTocakaTxt.Name = "BrojTocakaTxt";
            this.BrojTocakaTxt.Size = new System.Drawing.Size(52, 20);
            this.BrojTocakaTxt.TabIndex = 8;
            // 
            // grid1
            // 
            this.grid1.Location = new System.Drawing.Point(98, 78);
            this.grid1.MajorTicColor = System.Drawing.Color.LightSlateGray;
            this.grid1.MajorXTicsCount = 6;
            this.grid1.MajorYTicsCount = 2;
            this.grid1.MinDelta = 10;
            this.grid1.MinorTicColor = System.Drawing.Color.LightGray;
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(562, 240);
            this.grid1.TabIndex = 9;
            this.grid1.Text = "grid1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.BrojTocakaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NacrtajButton);
            this.Controls.Add(this.IntervalDoTxt);
            this.Controls.Add(this.IntervalOdTxt);
            this.Controls.Add(this.FunkcijaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FunkcijaTxt;
        private System.Windows.Forms.TextBox IntervalOdTxt;
        private System.Windows.Forms.TextBox IntervalDoTxt;
        private System.Windows.Forms.Button NacrtajButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BrojTocakaTxt;
        private DiagramGrid.Controls.Grid grid1;
    }
}

