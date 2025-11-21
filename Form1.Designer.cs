namespace simpleTEST
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
            label1 = new Label();
            label2 = new Label();
            Amountbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Pricebox = new TextBox();
            label5 = new Label();
            perkilocheck = new CheckBox();
            Outputbox = new TextBox();
            Run = new Button();
            Solidcheck = new CheckBox();
            Liquidcheck = new CheckBox();
            kgcheck = new CheckBox();
            lbscheck = new CheckBox();
            ozcheck = new CheckBox();
            copycheck = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            checkBox1 = new CheckBox();
            templaterun = new Button();
            textBox1 = new TextBox();
            outputtextbox = new TextBox();
            label6 = new Label();
            moqbox = new Label();
            pricesbox = new TextBox();
            moxinput = new TextBox();
            Prices = new Label();
            outputlabel = new Label();
            UnitKgInput = new TextBox();
            kgPerUnit = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Amount:";
            // 
            // Amountbox
            // 
            Amountbox.Location = new Point(68, 37);
            Amountbox.Name = "Amountbox";
            Amountbox.Size = new Size(89, 23);
            Amountbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 19);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Landing as:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 114);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Output";
            // 
            // Pricebox
            // 
            Pricebox.Location = new Point(172, 37);
            Pricebox.Name = "Pricebox";
            Pricebox.Size = new Size(95, 23);
            Pricebox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 19);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // perkilocheck
            // 
            perkilocheck.AutoSize = true;
            perkilocheck.Location = new Point(172, 66);
            perkilocheck.Name = "perkilocheck";
            perkilocheck.Size = new Size(116, 19);
            perkilocheck.TabIndex = 10;
            perkilocheck.Text = "(as price per kilo)";
            perkilocheck.UseVisualStyleBackColor = true;
            // 
            // Outputbox
            // 
            Outputbox.Location = new Point(20, 139);
            Outputbox.Multiline = true;
            Outputbox.Name = "Outputbox";
            Outputbox.ScrollBars = ScrollBars.Both;
            Outputbox.Size = new Size(369, 50);
            Outputbox.TabIndex = 11;
            // 
            // Run
            // 
            Run.Location = new Point(68, 66);
            Run.Name = "Run";
            Run.Size = new Size(89, 43);
            Run.TabIndex = 12;
            Run.Text = "Run";
            Run.UseVisualStyleBackColor = true;
            Run.Click += Run_Click_1;
            // 
            // Solidcheck
            // 
            Solidcheck.AutoSize = true;
            Solidcheck.Location = new Point(294, 37);
            Solidcheck.Name = "Solidcheck";
            Solidcheck.Size = new Size(83, 19);
            Solidcheck.TabIndex = 13;
            Solidcheck.Text = "Solid (+$3)";
            Solidcheck.UseVisualStyleBackColor = true;
            Solidcheck.CheckedChanged += Solidcheck_CheckedChanged;
            // 
            // Liquidcheck
            // 
            Liquidcheck.AutoSize = true;
            Liquidcheck.Location = new Point(294, 62);
            Liquidcheck.Name = "Liquidcheck";
            Liquidcheck.Size = new Size(90, 19);
            Liquidcheck.TabIndex = 14;
            Liquidcheck.Text = "Liquid (+$4)";
            Liquidcheck.UseVisualStyleBackColor = true;
            Liquidcheck.CheckedChanged += Liquidcheck_CheckedChanged;
            // 
            // kgcheck
            // 
            kgcheck.AutoSize = true;
            kgcheck.Location = new Point(16, 37);
            kgcheck.Name = "kgcheck";
            kgcheck.Size = new Size(44, 19);
            kgcheck.TabIndex = 15;
            kgcheck.Text = "kgs";
            kgcheck.UseVisualStyleBackColor = true;
            kgcheck.CheckedChanged += kgcheck_CheckedChanged;
            // 
            // lbscheck
            // 
            lbscheck.AutoSize = true;
            lbscheck.Location = new Point(16, 62);
            lbscheck.Name = "lbscheck";
            lbscheck.Size = new Size(41, 19);
            lbscheck.TabIndex = 16;
            lbscheck.Text = "lbs";
            lbscheck.UseVisualStyleBackColor = true;
            lbscheck.CheckedChanged += lbscheck_CheckedChanged;
            // 
            // ozcheck
            // 
            ozcheck.AutoSize = true;
            ozcheck.Location = new Point(16, 87);
            ozcheck.Name = "ozcheck";
            ozcheck.Size = new Size(38, 19);
            ozcheck.TabIndex = 17;
            ozcheck.Text = "oz";
            ozcheck.UseVisualStyleBackColor = true;
            ozcheck.CheckedChanged += ozcheck_CheckedChanged;
            // 
            // copycheck
            // 
            copycheck.AutoSize = true;
            copycheck.Font = new Font("Segoe UI", 8F);
            copycheck.Location = new Point(68, 116);
            copycheck.Name = "copycheck";
            copycheck.Size = new Size(210, 17);
            copycheck.TabIndex = 18;
            copycheck.Text = "Copy output to clipboard when run";
            copycheck.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(9, 17);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(413, 249);
            tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Outputbox);
            tabPage1.Controls.Add(copycheck);
            tabPage1.Controls.Add(Liquidcheck);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Pricebox);
            tabPage1.Controls.Add(kgcheck);
            tabPage1.Controls.Add(ozcheck);
            tabPage1.Controls.Add(Solidcheck);
            tabPage1.Controls.Add(perkilocheck);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Amountbox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(Run);
            tabPage1.Controls.Add(lbscheck);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(405, 221);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "JC Note Generator";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(templaterun);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(outputtextbox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(moqbox);
            tabPage2.Controls.Add(pricesbox);
            tabPage2.Controls.Add(moxinput);
            tabPage2.Controls.Add(Prices);
            tabPage2.Controls.Add(outputlabel);
            tabPage2.Controls.Add(UnitKgInput);
            tabPage2.Controls.Add(kgPerUnit);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(405, 221);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Surplus Template";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8F);
            checkBox1.Location = new Point(60, 185);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(210, 17);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Copy output to clipboard when run";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // templaterun
            // 
            templaterun.Location = new Point(286, 110);
            templaterun.Name = "templaterun";
            templaterun.Size = new Size(96, 61);
            templaterun.TabIndex = 10;
            templaterun.Text = "Generate";
            templaterun.UseVisualStyleBackColor = true;
            templaterun.Click += templaterun_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 8;
            // 
            // outputtextbox
            // 
            outputtextbox.Location = new Point(19, 204);
            outputtextbox.Multiline = true;
            outputtextbox.Name = "outputtextbox";
            outputtextbox.Size = new Size(345, 97);
            outputtextbox.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(6, 66);
            label6.Name = "label6";
            label6.Size = new Size(279, 41);
            label6.TabIndex = 7;
            label6.Text = "Landed $/kg (if multiple, enter as comma separated list. S/L can be used for solid/liquid pricing)";
            // 
            // moqbox
            // 
            moqbox.AutoSize = true;
            moqbox.Location = new Point(6, 136);
            moqbox.Name = "moqbox";
            moqbox.Size = new Size(261, 15);
            moqbox.TabIndex = 4;
            moqbox.Text = "MOQ (if multiple enter as comma separated list)";
            // 
            // pricesbox
            // 
            pricesbox.Location = new Point(19, 50);
            pricesbox.Name = "pricesbox";
            pricesbox.Size = new Size(246, 23);
            pricesbox.TabIndex = 3;
            // 
            // moxinput
            // 
            moxinput.Location = new Point(19, 154);
            moxinput.Name = "moxinput";
            moxinput.Size = new Size(246, 23);
            moxinput.TabIndex = 5;
            // 
            // Prices
            // 
            Prices.AutoSize = true;
            Prices.Location = new Point(6, 32);
            Prices.Name = "Prices";
            Prices.Size = new Size(259, 15);
            Prices.TabIndex = 2;
            Prices.Text = "$/kg (if multiple, enter as comma separated list)";
            // 
            // outputlabel
            // 
            outputlabel.AutoSize = true;
            outputlabel.Location = new Point(6, 185);
            outputlabel.Name = "outputlabel";
            outputlabel.Size = new Size(48, 15);
            outputlabel.TabIndex = 6;
            outputlabel.Text = "Output:";
            // 
            // UnitKgInput
            // 
            UnitKgInput.Location = new Point(89, 6);
            UnitKgInput.Name = "UnitKgInput";
            UnitKgInput.Size = new Size(62, 23);
            UnitKgInput.TabIndex = 1;
            // 
            // kgPerUnit
            // 
            kgPerUnit.AutoSize = true;
            kgPerUnit.Location = new Point(7, 9);
            kgPerUnit.Name = "kgPerUnit";
            kgPerUnit.Size = new Size(76, 15);
            kgPerUnit.TabIndex = 0;
            kgPerUnit.Text = "Enter kg/unit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 289);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "JC Note generator";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox Amountbox;
        private Label label3;
        private Label label4;
        private TextBox Pricebox;
        private Label label5;
        private CheckBox perkilocheck;
        private TextBox Outputbox;
        private Button Run;
        private CheckBox Solidcheck;
        private CheckBox Liquidcheck;
        private CheckBox kgcheck;
        private CheckBox lbscheck;
        private CheckBox ozcheck;
        private CheckBox copycheck;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label kgPerUnit;
        private TextBox UnitKgInput;
        private Label Prices;
        private TextBox pricesbox;
        private Label moqbox;
        private TextBox moxinput;
        private TextBox textBox1;
        private Label label6;
        private Label outputlabel;
        private TextBox outputtextbox;
        private Button templaterun;
        private CheckBox checkBox1;
    }
}
