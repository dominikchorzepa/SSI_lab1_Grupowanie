namespace SSI___lab1___Grupowanie
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
            txtProbki = new TextBox();
            btnUruchom = new Button();
            numK = new NumericUpDown();
            numIteracje = new NumericUpDown();
            comboBoxMetryka = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIteracje).BeginInit();
            SuspendLayout();
            // 
            // txtProbki
            // 
            txtProbki.Location = new Point(356, 59);
            txtProbki.Multiline = true;
            txtProbki.Name = "txtProbki";
            txtProbki.ScrollBars = ScrollBars.Vertical;
            txtProbki.Size = new Size(386, 334);
            txtProbki.TabIndex = 0;
            // 
            // btnUruchom
            // 
            btnUruchom.Location = new Point(140, 305);
            btnUruchom.Name = "btnUruchom";
            btnUruchom.Size = new Size(171, 23);
            btnUruchom.TabIndex = 1;
            btnUruchom.Text = "Uruchom K-means";
            btnUruchom.UseVisualStyleBackColor = true;
            btnUruchom.Click += btnUruchom_Click;
            // 
            // numK
            // 
            numK.Location = new Point(140, 77);
            numK.Maximum = new decimal(new int[] { 101, 0, 0, 0 });
            numK.Name = "numK";
            numK.Size = new Size(120, 23);
            numK.TabIndex = 2;
            numK.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // numIteracje
            // 
            numIteracje.Location = new Point(140, 142);
            numIteracje.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numIteracje.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIteracje.Name = "numIteracje";
            numIteracje.Size = new Size(120, 23);
            numIteracje.TabIndex = 3;
            numIteracje.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // comboBoxMetryka
            // 
            comboBoxMetryka.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMetryka.FormattingEnabled = true;
            comboBoxMetryka.Location = new Point(140, 211);
            comboBoxMetryka.Name = "comboBoxMetryka";
            comboBoxMetryka.Size = new Size(121, 23);
            comboBoxMetryka.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 59);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 5;
            label1.Text = "Liczba grup (k)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 124);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Liczba iteracji";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 193);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Metryka odległości";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMetryka);
            Controls.Add(numIteracje);
            Controls.Add(numK);
            Controls.Add(btnUruchom);
            Controls.Add(txtProbki);
            Name = "Form1";
            Text = "Algorytm K-means";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numK).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIteracje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProbki;
        private Button btnUruchom;
        private NumericUpDown numK;
        private NumericUpDown numIteracje;
        private ComboBox comboBoxMetryka;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
