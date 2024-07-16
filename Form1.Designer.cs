namespace stajornek2
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
            label3 = new Label();
            label4 = new Label();
            txtad = new TextBox();
            txtsoyad = new TextBox();
            txttelefon = new TextBox();
            txteposta = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbladsoyad = new Label();
            lbltelefon = new Label();
            lbleposta = new Label();
            btnkayit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 102);
            label1.Name = "label1";
            label1.Size = new Size(42, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 149);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 198);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 251);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 3;
            label4.Text = "E-posta:";
            // 
            // txtad
            // 
            txtad.Location = new Point(170, 110);
            txtad.Name = "txtad";
            txtad.Size = new Size(260, 23);
            txtad.TabIndex = 4;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(170, 157);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(260, 23);
            txtsoyad.TabIndex = 5;
            // 
            // txttelefon
            // 
            txttelefon.Location = new Point(170, 206);
            txttelefon.Name = "txttelefon";
            txttelefon.Size = new Size(260, 23);
            txttelefon.TabIndex = 6;
            // 
            // txteposta
            // 
            txteposta.Location = new Point(170, 259);
            txteposta.Name = "txteposta";
            txteposta.Size = new Size(260, 23);
            txteposta.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(657, 133);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 8;
            label5.Text = "Ad-Soyad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(657, 180);
            label6.Name = "label6";
            label6.Size = new Size(59, 19);
            label6.TabIndex = 9;
            label6.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(657, 229);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 10;
            label7.Text = "E-posta:";
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbladsoyad.Location = new Point(750, 133);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(13, 19);
            lbladsoyad.TabIndex = 11;
            lbladsoyad.Text = " ";
            // 
            // lbltelefon
            // 
            lbltelefon.AutoSize = true;
            lbltelefon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbltelefon.Location = new Point(750, 182);
            lbltelefon.Name = "lbltelefon";
            lbltelefon.Size = new Size(13, 19);
            lbltelefon.TabIndex = 12;
            lbltelefon.Text = " ";
            // 
            // lbleposta
            // 
            lbleposta.AutoSize = true;
            lbleposta.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbleposta.Location = new Point(750, 229);
            lbleposta.Name = "lbleposta";
            lbleposta.Size = new Size(13, 19);
            lbleposta.TabIndex = 13;
            lbleposta.Text = " ";
            // 
            // btnkayit
            // 
            btnkayit.BackColor = Color.DarkGray;
            btnkayit.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnkayit.ForeColor = SystemColors.ActiveCaptionText;
            btnkayit.Location = new Point(170, 310);
            btnkayit.Name = "btnkayit";
            btnkayit.Size = new Size(129, 36);
            btnkayit.TabIndex = 14;
            btnkayit.Text = "Kaydet";
            btnkayit.UseVisualStyleBackColor = false;
            btnkayit.Click += btnkayit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(301, 310);
            button1.Name = "button1";
            button1.Size = new Size(129, 36);
            button1.TabIndex = 15;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1043, 478);
            Controls.Add(button1);
            Controls.Add(btnkayit);
            Controls.Add(lbleposta);
            Controls.Add(lbltelefon);
            Controls.Add(lbladsoyad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txteposta);
            Controls.Add(txttelefon);
            Controls.Add(txtsoyad);
            Controls.Add(txtad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtad;
        private TextBox txtsoyad;
        private TextBox txttelefon;
        private TextBox txteposta;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbladsoyad;
        private Label lbltelefon;
        private Label lbleposta;
        private Button btnkayit;
        private Button button1;
    }
}