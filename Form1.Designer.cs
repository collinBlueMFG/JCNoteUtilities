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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Amount:";
            // 
            // Amountbox
            // 
            Amountbox.Location = new Point(64, 27);
            Amountbox.Name = "Amountbox";
            Amountbox.Size = new Size(89, 23);
            Amountbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 9);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Landing as:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 104);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Output";
            // 
            // Pricebox
            // 
            Pricebox.Location = new Point(168, 27);
            Pricebox.Name = "Pricebox";
            Pricebox.Size = new Size(95, 23);
            Pricebox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 9);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // perkilocheck
            // 
            perkilocheck.AutoSize = true;
            perkilocheck.Location = new Point(168, 56);
            perkilocheck.Name = "perkilocheck";
            perkilocheck.Size = new Size(116, 19);
            perkilocheck.TabIndex = 10;
            perkilocheck.Text = "(as price per kilo)";
            perkilocheck.UseVisualStyleBackColor = true;
            // 
            // Outputbox
            // 
            Outputbox.Location = new Point(16, 129);
            Outputbox.Multiline = true;
            Outputbox.Name = "Outputbox";
            Outputbox.ScrollBars = ScrollBars.Both;
            Outputbox.Size = new Size(369, 50);
            Outputbox.TabIndex = 11;
            // 
            // Run
            // 
            Run.Location = new Point(64, 56);
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
            Solidcheck.Location = new Point(290, 27);
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
            Liquidcheck.Location = new Point(290, 52);
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
            kgcheck.Location = new Point(12, 27);
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
            lbscheck.Location = new Point(12, 52);
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
            ozcheck.Location = new Point(12, 77);
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
            copycheck.Location = new Point(64, 106);
            copycheck.Name = "copycheck";
            copycheck.Size = new Size(210, 17);
            copycheck.TabIndex = 18;
            copycheck.Text = "Copy output to clipboard when run";
            copycheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 197);
            Controls.Add(copycheck);
            Controls.Add(ozcheck);
            Controls.Add(lbscheck);
            Controls.Add(kgcheck);
            Controls.Add(Liquidcheck);
            Controls.Add(Solidcheck);
            Controls.Add(Run);
            Controls.Add(Outputbox);
            Controls.Add(perkilocheck);
            Controls.Add(label5);
            Controls.Add(Pricebox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Amountbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "JC Note generator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}
