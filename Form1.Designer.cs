namespace Dentiste
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
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox33 = new TextBox();
            DB_16 = new TextBox();
            DH_16 = new TextBox();
            DB_15 = new TextBox();
            DH_15 = new TextBox();
            DB_14 = new TextBox();
            DH_14 = new TextBox();
            DB_13 = new TextBox();
            DH_13 = new TextBox();
            DB_12 = new TextBox();
            DH_12 = new TextBox();
            DB_11 = new TextBox();
            DH_11 = new TextBox();
            DB_10 = new TextBox();
            DB_9 = new TextBox();
            DH_10 = new TextBox();
            DB_8 = new TextBox();
            DH_9 = new TextBox();
            DB_7 = new TextBox();
            DH_8 = new TextBox();
            DB_6 = new TextBox();
            DH_7 = new TextBox();
            DB_5 = new TextBox();
            DH_6 = new TextBox();
            DB_4 = new TextBox();
            DH_5 = new TextBox();
            DB_3 = new TextBox();
            DH_4 = new TextBox();
            DB_2 = new TextBox();
            DH_3 = new TextBox();
            DB_1 = new TextBox();
            DH_2 = new TextBox();
            DH_1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightGray;
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(textBox33);
            splitContainer1.Panel1.Controls.Add(DB_16);
            splitContainer1.Panel1.Controls.Add(DH_16);
            splitContainer1.Panel1.Controls.Add(DB_15);
            splitContainer1.Panel1.Controls.Add(DH_15);
            splitContainer1.Panel1.Controls.Add(DB_14);
            splitContainer1.Panel1.Controls.Add(DH_14);
            splitContainer1.Panel1.Controls.Add(DB_13);
            splitContainer1.Panel1.Controls.Add(DH_13);
            splitContainer1.Panel1.Controls.Add(DB_12);
            splitContainer1.Panel1.Controls.Add(DH_12);
            splitContainer1.Panel1.Controls.Add(DB_11);
            splitContainer1.Panel1.Controls.Add(DH_11);
            splitContainer1.Panel1.Controls.Add(DB_10);
            splitContainer1.Panel1.Controls.Add(DB_9);
            splitContainer1.Panel1.Controls.Add(DH_10);
            splitContainer1.Panel1.Controls.Add(DB_8);
            splitContainer1.Panel1.Controls.Add(DH_9);
            splitContainer1.Panel1.Controls.Add(DB_7);
            splitContainer1.Panel1.Controls.Add(DH_8);
            splitContainer1.Panel1.Controls.Add(DB_6);
            splitContainer1.Panel1.Controls.Add(DH_7);
            splitContainer1.Panel1.Controls.Add(DB_5);
            splitContainer1.Panel1.Controls.Add(DH_6);
            splitContainer1.Panel1.Controls.Add(DB_4);
            splitContainer1.Panel1.Controls.Add(DH_5);
            splitContainer1.Panel1.Controls.Add(DB_3);
            splitContainer1.Panel1.Controls.Add(DH_4);
            splitContainer1.Panel1.Controls.Add(DB_2);
            splitContainer1.Panel1.Controls.Add(DH_3);
            splitContainer1.Panel1.Controls.Add(DB_1);
            splitContainer1.Panel1.Controls.Add(DH_2);
            splitContainer1.Panel1.Controls.Add(DH_1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 382;
            splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(76, 330);
            button1.Name = "button1";
            button1.Size = new Size(186, 49);
            button1.TabIndex = 4;
            button1.Text = "VALIDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Validation;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jejo", "Mahasalama" });
            comboBox1.Location = new Point(80, 259);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox33
            // 
            textBox33.Location = new Point(81, 176);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(180, 23);
            textBox33.TabIndex = 2;
            // 
            // DB_16
            // 
            DB_16.Location = new Point(361, 112);
            DB_16.Name = "DB_16";
            DB_16.Size = new Size(18, 23);
            DB_16.TabIndex = 1;
            DB_16.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_16
            // 
            DH_16.Location = new Point(361, 55);
            DH_16.Name = "DH_16";
            DH_16.Size = new Size(18, 23);
            DH_16.TabIndex = 1;
            DH_16.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_15
            // 
            DB_15.Location = new Point(340, 112);
            DB_15.Name = "DB_15";
            DB_15.Size = new Size(17, 23);
            DB_15.TabIndex = 1;
            DB_15.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_15
            // 
            DH_15.Location = new Point(340, 55);
            DH_15.Name = "DH_15";
            DH_15.Size = new Size(17, 23);
            DH_15.TabIndex = 1;
            DH_15.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_14
            // 
            DB_14.Location = new Point(316, 112);
            DB_14.Name = "DB_14";
            DB_14.Size = new Size(17, 23);
            DB_14.TabIndex = 1;
            DB_14.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_14
            // 
            DH_14.Location = new Point(316, 55);
            DH_14.Name = "DH_14";
            DH_14.Size = new Size(17, 23);
            DH_14.TabIndex = 1;
            DH_14.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_13
            // 
            DB_13.Location = new Point(292, 112);
            DB_13.Name = "DB_13";
            DB_13.Size = new Size(17, 23);
            DB_13.TabIndex = 1;
            DB_13.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_13
            // 
            DH_13.Location = new Point(292, 55);
            DH_13.Name = "DH_13";
            DH_13.Size = new Size(17, 23);
            DH_13.TabIndex = 1;
            DH_13.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_12
            // 
            DB_12.Location = new Point(268, 112);
            DB_12.Name = "DB_12";
            DB_12.Size = new Size(17, 23);
            DB_12.TabIndex = 1;
            DB_12.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_12
            // 
            DH_12.Location = new Point(268, 55);
            DH_12.Name = "DH_12";
            DH_12.Size = new Size(17, 23);
            DH_12.TabIndex = 1;
            DH_12.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_11
            // 
            DB_11.Location = new Point(244, 112);
            DB_11.Name = "DB_11";
            DB_11.Size = new Size(17, 23);
            DB_11.TabIndex = 1;
            DB_11.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_11
            // 
            DH_11.Location = new Point(244, 55);
            DH_11.Name = "DH_11";
            DH_11.Size = new Size(17, 23);
            DH_11.TabIndex = 1;
            DH_11.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_10
            // 
            DB_10.Location = new Point(220, 112);
            DB_10.Name = "DB_10";
            DB_10.Size = new Size(17, 23);
            DB_10.TabIndex = 1;
            DB_10.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_9
            // 
            DB_9.Location = new Point(196, 112);
            DB_9.Name = "DB_9";
            DB_9.Size = new Size(17, 23);
            DB_9.TabIndex = 1;
            DB_9.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_10
            // 
            DH_10.Location = new Point(220, 55);
            DH_10.Name = "DH_10";
            DH_10.Size = new Size(17, 23);
            DH_10.TabIndex = 1;
            DH_10.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_8
            // 
            DB_8.Location = new Point(172, 112);
            DB_8.Name = "DB_8";
            DB_8.Size = new Size(17, 23);
            DB_8.TabIndex = 1;
            DB_8.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_9
            // 
            DH_9.Location = new Point(196, 55);
            DH_9.Name = "DH_9";
            DH_9.Size = new Size(17, 23);
            DH_9.TabIndex = 1;
            DH_9.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_7
            // 
            DB_7.Location = new Point(148, 112);
            DB_7.Name = "DB_7";
            DB_7.Size = new Size(17, 23);
            DB_7.TabIndex = 1;
            DB_7.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_8
            // 
            DH_8.Location = new Point(172, 55);
            DH_8.Name = "DH_8";
            DH_8.Size = new Size(17, 23);
            DH_8.TabIndex = 1;
            DH_8.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_6
            // 
            DB_6.Location = new Point(124, 112);
            DB_6.Name = "DB_6";
            DB_6.Size = new Size(17, 23);
            DB_6.TabIndex = 1;
            DB_6.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_7
            // 
            DH_7.Location = new Point(148, 55);
            DH_7.Name = "DH_7";
            DH_7.Size = new Size(17, 23);
            DH_7.TabIndex = 1;
            DH_7.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_5
            // 
            DB_5.Location = new Point(100, 112);
            DB_5.Name = "DB_5";
            DB_5.Size = new Size(17, 23);
            DB_5.TabIndex = 1;
            DB_5.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_6
            // 
            DH_6.Location = new Point(124, 55);
            DH_6.Name = "DH_6";
            DH_6.Size = new Size(17, 23);
            DH_6.TabIndex = 1;
            DH_6.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_4
            // 
            DB_4.Location = new Point(76, 112);
            DB_4.Name = "DB_4";
            DB_4.Size = new Size(17, 23);
            DB_4.TabIndex = 1;
            DB_4.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_5
            // 
            DH_5.Location = new Point(100, 55);
            DH_5.Name = "DH_5";
            DH_5.Size = new Size(17, 23);
            DH_5.TabIndex = 1;
            DH_5.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_3
            // 
            DB_3.Location = new Point(52, 112);
            DB_3.Name = "DB_3";
            DB_3.Size = new Size(17, 23);
            DB_3.TabIndex = 1;
            DB_3.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_4
            // 
            DH_4.Location = new Point(76, 55);
            DH_4.Name = "DH_4";
            DH_4.Size = new Size(17, 23);
            DH_4.TabIndex = 1;
            DH_4.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_2
            // 
            DB_2.Location = new Point(28, 112);
            DB_2.Name = "DB_2";
            DB_2.Size = new Size(17, 23);
            DB_2.TabIndex = 1;
            DB_2.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_3
            // 
            DH_3.Location = new Point(52, 55);
            DH_3.Name = "DH_3";
            DH_3.Size = new Size(17, 23);
            DH_3.TabIndex = 1;
            DH_3.KeyPress += champFormulaire_KeyPressed;
            // 
            // DB_1
            // 
            DB_1.Location = new Point(4, 112);
            DB_1.Name = "DB_1";
            DB_1.Size = new Size(17, 23);
            DB_1.TabIndex = 1;
            DB_1.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_2
            // 
            DH_2.Location = new Point(28, 55);
            DH_2.Name = "DH_2";
            DH_2.Size = new Size(17, 23);
            DH_2.TabIndex = 1;
            DH_2.KeyPress += champFormulaire_KeyPressed;
            // 
            // DH_1
            // 
            DH_1.Location = new Point(4, 55);
            DH_1.Name = "DH_1";
            DH_1.Size = new Size(17, 23);
            DH_1.TabIndex = 1;
            DH_1.KeyPress += champFormulaire_KeyPressed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox DH_1;
        private TextBox DB_16;
        private TextBox DH_16;
        private TextBox DB_15;
        private TextBox DH_15;
        private TextBox DB_14;
        private TextBox DH_14;
        private TextBox DB_13;
        private TextBox DH_13;
        private TextBox DB_12;
        private TextBox DH_12;
        private TextBox DB_11;
        private TextBox DH_11;
        private TextBox DB_10;
        private TextBox DB_9;
        private TextBox DH_10;
        private TextBox DB_8;
        private TextBox DH_9;
        private TextBox DB_7;
        private TextBox DH_8;
        private TextBox DB_6;
        private TextBox DH_7;
        private TextBox DB_5;
        private TextBox DH_6;
        private TextBox DB_4;
        private TextBox DH_5;
        private TextBox DB_3;
        private TextBox DH_4;
        private TextBox DB_2;
        private TextBox DH_3;
        private TextBox DB_1;
        private TextBox DH_2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox33;
    }
}
