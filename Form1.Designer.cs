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
            textBox32 = new TextBox();
            textBox16 = new TextBox();
            textBox31 = new TextBox();
            textBox15 = new TextBox();
            textBox30 = new TextBox();
            textBox14 = new TextBox();
            textBox29 = new TextBox();
            textBox13 = new TextBox();
            textBox28 = new TextBox();
            textBox12 = new TextBox();
            textBox27 = new TextBox();
            textBox11 = new TextBox();
            textBox26 = new TextBox();
            textBox25 = new TextBox();
            textBox10 = new TextBox();
            textBox24 = new TextBox();
            textBox9 = new TextBox();
            textBox23 = new TextBox();
            textBox8 = new TextBox();
            textBox22 = new TextBox();
            textBox7 = new TextBox();
            textBox21 = new TextBox();
            textBox6 = new TextBox();
            textBox20 = new TextBox();
            textBox5 = new TextBox();
            textBox19 = new TextBox();
            textBox4 = new TextBox();
            textBox18 = new TextBox();
            textBox3 = new TextBox();
            textBox17 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            splitContainer1.Panel1.Controls.Add(textBox32);
            splitContainer1.Panel1.Controls.Add(textBox16);
            splitContainer1.Panel1.Controls.Add(textBox31);
            splitContainer1.Panel1.Controls.Add(textBox15);
            splitContainer1.Panel1.Controls.Add(textBox30);
            splitContainer1.Panel1.Controls.Add(textBox14);
            splitContainer1.Panel1.Controls.Add(textBox29);
            splitContainer1.Panel1.Controls.Add(textBox13);
            splitContainer1.Panel1.Controls.Add(textBox28);
            splitContainer1.Panel1.Controls.Add(textBox12);
            splitContainer1.Panel1.Controls.Add(textBox27);
            splitContainer1.Panel1.Controls.Add(textBox11);
            splitContainer1.Panel1.Controls.Add(textBox26);
            splitContainer1.Panel1.Controls.Add(textBox25);
            splitContainer1.Panel1.Controls.Add(textBox10);
            splitContainer1.Panel1.Controls.Add(textBox24);
            splitContainer1.Panel1.Controls.Add(textBox9);
            splitContainer1.Panel1.Controls.Add(textBox23);
            splitContainer1.Panel1.Controls.Add(textBox8);
            splitContainer1.Panel1.Controls.Add(textBox22);
            splitContainer1.Panel1.Controls.Add(textBox7);
            splitContainer1.Panel1.Controls.Add(textBox21);
            splitContainer1.Panel1.Controls.Add(textBox6);
            splitContainer1.Panel1.Controls.Add(textBox20);
            splitContainer1.Panel1.Controls.Add(textBox5);
            splitContainer1.Panel1.Controls.Add(textBox19);
            splitContainer1.Panel1.Controls.Add(textBox4);
            splitContainer1.Panel1.Controls.Add(textBox18);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(textBox17);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
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
            button1.Click += validation;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Operation Jejo", "Operation Mahasalama" });
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
            // textBox32
            // 
            textBox32.Location = new Point(361, 112);
            textBox32.Name = "textBox32";
            textBox32.Size = new Size(18, 23);
            textBox32.TabIndex = 1;
            textBox32.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(361, 55);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(18, 23);
            textBox16.TabIndex = 1;
            textBox16.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox31
            // 
            textBox31.Location = new Point(340, 112);
            textBox31.Name = "textBox31";
            textBox31.Size = new Size(17, 23);
            textBox31.TabIndex = 1;
            textBox31.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(340, 55);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(17, 23);
            textBox15.TabIndex = 1;
            textBox15.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox30
            // 
            textBox30.Location = new Point(316, 112);
            textBox30.Name = "textBox30";
            textBox30.Size = new Size(17, 23);
            textBox30.TabIndex = 1;
            textBox30.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(316, 55);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(17, 23);
            textBox14.TabIndex = 1;
            textBox14.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox29
            // 
            textBox29.Location = new Point(292, 112);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(17, 23);
            textBox29.TabIndex = 1;
            textBox29.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(292, 55);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(17, 23);
            textBox13.TabIndex = 1;
            textBox13.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox28
            // 
            textBox28.Location = new Point(268, 112);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(17, 23);
            textBox28.TabIndex = 1;
            textBox28.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(268, 55);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(17, 23);
            textBox12.TabIndex = 1;
            textBox12.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox27
            // 
            textBox27.Location = new Point(244, 112);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(17, 23);
            textBox27.TabIndex = 1;
            textBox27.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(244, 55);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(17, 23);
            textBox11.TabIndex = 1;
            textBox11.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox26
            // 
            textBox26.Location = new Point(220, 112);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(17, 23);
            textBox26.TabIndex = 1;
            textBox26.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox25
            // 
            textBox25.Location = new Point(196, 112);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(17, 23);
            textBox25.TabIndex = 1;
            textBox25.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(220, 55);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(17, 23);
            textBox10.TabIndex = 1;
            textBox10.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(172, 112);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(17, 23);
            textBox24.TabIndex = 1;
            textBox24.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(196, 55);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(17, 23);
            textBox9.TabIndex = 1;
            textBox9.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(148, 112);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(17, 23);
            textBox23.TabIndex = 1;
            textBox23.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(172, 55);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(17, 23);
            textBox8.TabIndex = 1;
            textBox8.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(124, 112);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(17, 23);
            textBox22.TabIndex = 1;
            textBox22.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(148, 55);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(17, 23);
            textBox7.TabIndex = 1;
            textBox7.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(100, 112);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(17, 23);
            textBox21.TabIndex = 1;
            textBox21.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(124, 55);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(17, 23);
            textBox6.TabIndex = 1;
            textBox6.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(76, 112);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(17, 23);
            textBox20.TabIndex = 1;
            textBox20.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(100, 55);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(17, 23);
            textBox5.TabIndex = 1;
            textBox5.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(52, 112);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(17, 23);
            textBox19.TabIndex = 1;
            textBox19.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(76, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(17, 23);
            textBox4.TabIndex = 1;
            textBox4.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(28, 112);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(17, 23);
            textBox18.TabIndex = 1;
            textBox18.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(52, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(17, 23);
            textBox3.TabIndex = 1;
            textBox3.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(4, 112);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(17, 23);
            textBox17.TabIndex = 1;
            textBox17.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(17, 23);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += champFormulaire_KeyPressed;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(17, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += champFormulaire_KeyPressed;
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
        private TextBox textBox1;
        private TextBox textBox32;
        private TextBox textBox16;
        private TextBox textBox31;
        private TextBox textBox15;
        private TextBox textBox30;
        private TextBox textBox14;
        private TextBox textBox29;
        private TextBox textBox13;
        private TextBox textBox28;
        private TextBox textBox12;
        private TextBox textBox27;
        private TextBox textBox11;
        private TextBox textBox26;
        private TextBox textBox25;
        private TextBox textBox10;
        private TextBox textBox24;
        private TextBox textBox9;
        private TextBox textBox23;
        private TextBox textBox8;
        private TextBox textBox22;
        private TextBox textBox7;
        private TextBox textBox21;
        private TextBox textBox6;
        private TextBox textBox20;
        private TextBox textBox5;
        private TextBox textBox19;
        private TextBox textBox4;
        private TextBox textBox18;
        private TextBox textBox3;
        private TextBox textBox17;
        private TextBox textBox2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox33;
    }
}
