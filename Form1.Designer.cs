namespace Práctica_11
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
            button1 = new Button();
            label5 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.NavajoWhite;
            button1.Location = new Point(423, 193);
            button1.Name = "button1";
            button1.Size = new Size(226, 60);
            button1.TabIndex = 0;
            button1.Text = "For";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.BlanchedAlmond;
            label5.Location = new Point(394, 86);
            label5.Name = "label5";
            label5.Size = new Size(208, 35);
            label5.TabIndex = 14;
            label5.Text = "f(X)=X/(1 + X^2)";
            label5.Click += label5_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PaleGoldenrod;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 34;
            listBox1.Location = new Point(43, 247);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(169, 306);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.BlanchedAlmond;
            label1.Location = new Point(443, 24);
            label1.Name = "label1";
            label1.Size = new Size(118, 35);
            label1.TabIndex = 16;
            label1.Text = "Ecuación";
            label1.Click += label1_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.PaleGoldenrod;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 34;
            listBox2.Location = new Point(239, 247);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(169, 306);
            listBox2.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.NavajoWhite;
            button2.Location = new Point(423, 259);
            button2.Name = "button2";
            button2.Size = new Size(226, 60);
            button2.TabIndex = 19;
            button2.Text = "While";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.NavajoWhite;
            button3.Location = new Point(423, 325);
            button3.Name = "button3";
            button3.Size = new Size(226, 60);
            button3.TabIndex = 20;
            button3.Text = "do..while";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.NavajoWhite;
            button4.Location = new Point(423, 391);
            button4.Name = "button4";
            button4.Size = new Size(226, 60);
            button4.TabIndex = 21;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.BlanchedAlmond;
            label2.Location = new Point(115, 193);
            label2.Name = "label2";
            label2.Size = new Size(34, 35);
            label2.TabIndex = 22;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.BlanchedAlmond;
            label3.Location = new Point(295, 193);
            label3.Name = "label3";
            label3.Size = new Size(56, 35);
            label3.TabIndex = 23;
            label3.Text = "f(X)";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1120, 663);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
    }
}