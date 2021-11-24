namespace TicTacToe_WinApp
{
    partial class NameScreen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelEnterName1 = new System.Windows.Forms.Label();
            this.LabelEnterName2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(186, 273);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 153);
            this.textBox2.MaxLength = 9;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LabelEnterName1
            // 
            this.LabelEnterName1.AutoSize = true;
            this.LabelEnterName1.Location = new System.Drawing.Point(194, 121);
            this.LabelEnterName1.Name = "LabelEnterName1";
            this.LabelEnterName1.Size = new System.Drawing.Size(192, 20);
            this.LabelEnterName1.TabIndex = 2;
            this.LabelEnterName1.Text = "Enter the first player\'s name";
            // 
            // LabelEnterName2
            // 
            this.LabelEnterName2.AutoSize = true;
            this.LabelEnterName2.Location = new System.Drawing.Point(186, 233);
            this.LabelEnterName2.Name = "LabelEnterName2";
            this.LabelEnterName2.Size = new System.Drawing.Size(214, 20);
            this.LabelEnterName2.TabIndex = 3;
            this.LabelEnterName2.Text = "Enter the second player\'s name";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(186, 328);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(211, 57);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // NameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 533);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.LabelEnterName2);
            this.Controls.Add(this.LabelEnterName1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameScreen";
            this.Load += new System.EventHandler(this.NameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label LabelEnterName1;
        private Label LabelEnterName2;
        private Button buttonStart;
    }
}