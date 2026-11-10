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
            btnWyswietl = new Button();
            SuspendLayout();
            // 
            // txtProbki
            // 
            txtProbki.Location = new Point(194, 190);
            txtProbki.Multiline = true;
            txtProbki.Name = "txtProbki";
            txtProbki.ScrollBars = ScrollBars.Vertical;
            txtProbki.Size = new Size(326, 177);
            txtProbki.TabIndex = 0;
            // 
            // btnWyswietl
            // 
            btnWyswietl.Location = new Point(194, 97);
            btnWyswietl.Name = "btnWyswietl";
            btnWyswietl.Size = new Size(171, 23);
            btnWyswietl.TabIndex = 1;
            btnWyswietl.Text = "Wyświetl próbki";
            btnWyswietl.UseVisualStyleBackColor = true;
            btnWyswietl.Click += btnWyswietl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWyswietl);
            Controls.Add(txtProbki);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProbki;
        private Button btnWyswietl;
    }
}
