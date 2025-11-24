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
            TemplateCopyCheck = new CheckBox();
            templaterun = new Button();
            TemplateLandingBox = new TextBox();
            TemplateOutputBox = new TextBox();
            label6 = new Label();
            moqbox = new Label();
            TemplatePricesBox = new TextBox();
            TemplateMoqInput = new TextBox();
            Prices = new Label();
            outputlabel = new Label();
            TemplateUnitKgInput = new TextBox();
            kgPerUnit = new Label();
            label7 = new Label();
            NumberOfUnitsBox = new TextBox();
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
            tabControl1.Size = new Size(424, 380);
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
            tabPage1.Size = new Size(416, 352);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "JC Note Generator";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(NumberOfUnitsBox);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(TemplateCopyCheck);
            tabPage2.Controls.Add(templaterun);
            tabPage2.Controls.Add(TemplateLandingBox);
            tabPage2.Controls.Add(TemplateOutputBox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(moqbox);
            tabPage2.Controls.Add(TemplatePricesBox);
            tabPage2.Controls.Add(TemplateMoqInput);
            tabPage2.Controls.Add(Prices);
            tabPage2.Controls.Add(outputlabel);
            tabPage2.Controls.Add(TemplateUnitKgInput);
            tabPage2.Controls.Add(kgPerUnit);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(416, 352);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Surplus Template";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TemplateCopyCheck
            // 
            TemplateCopyCheck.AutoSize = true;
            TemplateCopyCheck.Font = new Font("Segoe UI", 8F);
            TemplateCopyCheck.Location = new Point(56, 227);
            TemplateCopyCheck.Name = "TemplateCopyCheck";
            TemplateCopyCheck.Size = new Size(210, 17);
            TemplateCopyCheck.TabIndex = 19;
            TemplateCopyCheck.Text = "Copy output to clipboard when run";
            TemplateCopyCheck.UseVisualStyleBackColor = true;
            // 
            // templaterun
            // 
            templaterun.Location = new Point(285, 154);
            templaterun.Name = "templaterun";
            templaterun.Size = new Size(96, 61);
            templaterun.TabIndex = 10;
            templaterun.Text = "Generate";
            templaterun.UseVisualStyleBackColor = true;
            templaterun.Click += templaterun_Click;
            // 
            // TemplateLandingBox
            // 
            TemplateLandingBox.Location = new Point(18, 154);
            TemplateLandingBox.Name = "TemplateLandingBox";
            TemplateLandingBox.Size = new Size(246, 23);
            TemplateLandingBox.TabIndex = 8;
            // 
            // TemplateOutputBox
            // 
            TemplateOutputBox.Location = new Point(15, 246);
            TemplateOutputBox.Multiline = true;
            TemplateOutputBox.Name = "TemplateOutputBox";
            TemplateOutputBox.Size = new Size(345, 97);
            TemplateOutputBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(6, 120);
            label6.Name = "label6";
            label6.Size = new Size(279, 41);
            label6.TabIndex = 7;
            label6.Text = "Landed $/kg (if multiple, enter as comma separated list. S/L can be used for solid/liquid pricing)";
            // 
            // moqbox
            // 
            moqbox.AutoSize = true;
            moqbox.Location = new Point(5, 180);
            moqbox.Name = "moqbox";
            moqbox.Size = new Size(261, 15);
            moqbox.TabIndex = 4;
            moqbox.Text = "MOQ (if multiple enter as comma separated list)";
            // 
            // TemplatePricesBox
            // 
            TemplatePricesBox.Location = new Point(18, 50);
            TemplatePricesBox.Name = "TemplatePricesBox";
            TemplatePricesBox.Size = new Size(246, 23);
            TemplatePricesBox.TabIndex = 3;
            // 
            // TemplateMoqInput
            // 
            TemplateMoqInput.Location = new Point(18, 198);
            TemplateMoqInput.Name = "TemplateMoqInput";
            TemplateMoqInput.Size = new Size(246, 23);
            TemplateMoqInput.TabIndex = 5;
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
            outputlabel.Location = new Point(2, 227);
            outputlabel.Name = "outputlabel";
            outputlabel.Size = new Size(48, 15);
            outputlabel.TabIndex = 6;
            outputlabel.Text = "Output:";
            // 
            // TemplateUnitKgInput
            // 
            TemplateUnitKgInput.Location = new Point(89, 6);
            TemplateUnitKgInput.Name = "TemplateUnitKgInput";
            TemplateUnitKgInput.Size = new Size(62, 23);
            TemplateUnitKgInput.TabIndex = 1;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 76);
            label7.Name = "label7";
            label7.Size = new Size(232, 15);
            label7.TabIndex = 20;
            label7.Text = "Number of units (as comma separated list)";
            // 
            // NumberOfUnitsBox
            // 
            NumberOfUnitsBox.Location = new Point(18, 94);
            NumberOfUnitsBox.Name = "NumberOfUnitsBox";
            NumberOfUnitsBox.Size = new Size(246, 23);
            NumberOfUnitsBox.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 409);
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
        private TextBox TemplateUnitKgInput;
        private Label Prices;
        private TextBox TemplatePricesBox;
        private Label moqbox;
        private TextBox TemplateMoqInput;
        private TextBox TemplateLandingBox;
        private Label label6;
        private Label outputlabel;
        private TextBox TemplateOutputBox;
        private Button templaterun;
        private CheckBox TemplateCopyCheck;
        private Label label7;
        private TextBox NumberOfUnitsBox;
    }
}
