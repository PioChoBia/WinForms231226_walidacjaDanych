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
            this.components = new System.ComponentModel.Container();
            this.textBoxKod1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKod2 = new System.Windows.Forms.TextBox();
            this.richTextBoxKod1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxKod2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMaska = new System.Windows.Forms.RichTextBox();
            this.maskedTextBoxValidating = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBoxValidating = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValidating = new System.Windows.Forms.TextBox();
            this.richTextBoxValidated = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxValidated = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxKod1
            // 
            this.textBoxKod1.Location = new System.Drawing.Point(157, 66);
            this.textBoxKod1.Name = "textBoxKod1";
            this.textBoxKod1.Size = new System.Drawing.Size(100, 23);
            this.textBoxKod1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "walidacja  danych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "kod, wersja 1\r\nbutton waliduj\r\npisz tylko liczby";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "maska danych\r\npisz tylko liczby";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(277, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "waliduj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "kod, wersja 2\r\ndziała na zmianę TextBox\r\npisz tylko liczby";
            // 
            // textBoxKod2
            // 
            this.textBoxKod2.Location = new System.Drawing.Point(157, 189);
            this.textBoxKod2.Name = "textBoxKod2";
            this.textBoxKod2.Size = new System.Drawing.Size(100, 23);
            this.textBoxKod2.TabIndex = 7;
            this.textBoxKod2.TextChanged += new System.EventHandler(this.textBoxKod2_TextChanged);
            // 
            // richTextBoxKod1
            // 
            this.richTextBoxKod1.Location = new System.Drawing.Point(358, 40);
            this.richTextBoxKod1.Name = "richTextBoxKod1";
            this.richTextBoxKod1.Size = new System.Drawing.Size(143, 96);
            this.richTextBoxKod1.TabIndex = 9;
            this.richTextBoxKod1.Text = "";
            // 
            // richTextBoxKod2
            // 
            this.richTextBoxKod2.Location = new System.Drawing.Point(358, 162);
            this.richTextBoxKod2.Name = "richTextBoxKod2";
            this.richTextBoxKod2.Size = new System.Drawing.Size(143, 96);
            this.richTextBoxKod2.TabIndex = 10;
            this.richTextBoxKod2.Text = "";
            // 
            // richTextBoxMaska
            // 
            this.richTextBoxMaska.Location = new System.Drawing.Point(358, 285);
            this.richTextBoxMaska.Name = "richTextBoxMaska";
            this.richTextBoxMaska.Size = new System.Drawing.Size(143, 96);
            this.richTextBoxMaska.TabIndex = 11;
            this.richTextBoxMaska.Text = "";
            // 
            // maskedTextBoxValidating
            // 
            this.maskedTextBoxValidating.BeepOnError = true;
            this.maskedTextBoxValidating.Location = new System.Drawing.Point(157, 315);
            this.maskedTextBoxValidating.Mask = "## - ## - ####";
            this.maskedTextBoxValidating.Name = "maskedTextBoxValidating";
            this.maskedTextBoxValidating.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxValidating.TabIndex = 12;
            this.maskedTextBoxValidating.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            // 
            // richTextBoxValidating
            // 
            this.richTextBoxValidating.Location = new System.Drawing.Point(358, 408);
            this.richTextBoxValidating.Name = "richTextBoxValidating";
            this.richTextBoxValidating.Size = new System.Drawing.Size(143, 96);
            this.richTextBoxValidating.TabIndex = 15;
            this.richTextBoxValidating.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "właściwość Validating\r\npisz tylko liczby";
            // 
            // textBoxValidating
            // 
            this.textBoxValidating.Location = new System.Drawing.Point(157, 435);
            this.textBoxValidating.Name = "textBoxValidating";
            this.textBoxValidating.Size = new System.Drawing.Size(100, 23);
            this.textBoxValidating.TabIndex = 13;
            this.textBoxValidating.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxValidating_Validating);
            // 
            // richTextBoxValidated
            // 
            this.richTextBoxValidated.Location = new System.Drawing.Point(358, 529);
            this.richTextBoxValidated.Name = "richTextBoxValidated";
            this.richTextBoxValidated.Size = new System.Drawing.Size(143, 96);
            this.richTextBoxValidated.TabIndex = 18;
            this.richTextBoxValidated.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "właściwość Validated\r\npisz tylko liczby";
            // 
            // textBoxValidated
            // 
            this.textBoxValidated.Location = new System.Drawing.Point(157, 556);
            this.textBoxValidated.Name = "textBoxValidated";
            this.textBoxValidated.Size = new System.Drawing.Size(100, 23);
            this.textBoxValidated.TabIndex = 16;
            this.textBoxValidated.Validated += new System.EventHandler(this.textBoxValidated_Validated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 637);
            this.Controls.Add(this.richTextBoxValidated);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxValidated);
            this.Controls.Add(this.richTextBoxValidating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxValidating);
            this.Controls.Add(this.maskedTextBoxValidating);
            this.Controls.Add(this.richTextBoxMaska);
            this.Controls.Add(this.richTextBoxKod2);
            this.Controls.Add(this.richTextBoxKod1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKod2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
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
        private Button button1;
        private Label label4;
        private TextBox textBoxKod2;
        private RichTextBox richTextBoxKod1;
        private RichTextBox richTextBoxKod2;
        private RichTextBox richTextBoxMaska;
        private MaskedTextBox maskedTextBoxValidating;
        private ToolTip toolTip1;
        private RichTextBox richTextBoxValidating;
        private Label label5;
        private TextBox textBoxValidating;
        private RichTextBox richTextBoxValidated;
        private Label label6;
        private TextBox textBoxValidated;
    }
}