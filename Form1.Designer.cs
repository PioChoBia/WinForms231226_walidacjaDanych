namespace WinForms231226_walidacjaDanych
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
            this.textBoxKod1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaska = new System.Windows.Forms.TextBox();
            this.labelKomunikat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKod2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxKod1
            // 
            this.textBoxKod1.Location = new System.Drawing.Point(205, 66);
            this.textBoxKod1.Name = "textBoxKod1";
            this.textBoxKod1.Size = new System.Drawing.Size(100, 23);
            this.textBoxKod1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "walidacja  danych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "kod, wersja 1\r\nbutton waliduj\r\npisz tylko liczby";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "maska danych\r\npisz tylko liczby";
            // 
            // textBoxMaska
            // 
            this.textBoxMaska.Location = new System.Drawing.Point(205, 215);
            this.textBoxMaska.Name = "textBoxMaska";
            this.textBoxMaska.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaska.TabIndex = 3;
            // 
            // labelKomunikat
            // 
            this.labelKomunikat.AutoSize = true;
            this.labelKomunikat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKomunikat.Location = new System.Drawing.Point(46, 288);
            this.labelKomunikat.Name = "labelKomunikat";
            this.labelKomunikat.Size = new System.Drawing.Size(122, 25);
            this.labelKomunikat.TabIndex = 5;
            this.labelKomunikat.Text = "nie ma błędu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(354, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "waliduj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "kod, wersja 2\r\ndziała na zmianę TextBox\r\npisz tylko liczby";
            // 
            // textBoxKod2
            // 
            this.textBoxKod2.Location = new System.Drawing.Point(205, 137);
            this.textBoxKod2.Name = "textBoxKod2";
            this.textBoxKod2.Size = new System.Drawing.Size(100, 23);
            this.textBoxKod2.TabIndex = 7;
            this.textBoxKod2.TextChanged += new System.EventHandler(this.textBoxKod2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKod2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelKomunikat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaska);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKod1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxKod1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxMaska;
        private Label labelKomunikat;
        private Button button1;
        private Label label4;
        private TextBox textBoxKod2;
    }
}