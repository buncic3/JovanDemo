namespace WinFormsApp1
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
            korisnickoIme_txt = new TextBox();
            lozinka_txt = new TextBox();
            label2 = new Label();
            login_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Korisnicko Ime";
            // 
            // korisnickoIme_txt
            // 
            korisnickoIme_txt.Location = new Point(103, 12);
            korisnickoIme_txt.Name = "korisnickoIme_txt";
            korisnickoIme_txt.Size = new Size(188, 23);
            korisnickoIme_txt.TabIndex = 1;
            // 
            // lozinka_txt
            // 
            lozinka_txt.Location = new Point(103, 41);
            lozinka_txt.Name = "lozinka_txt";
            lozinka_txt.Size = new Size(188, 23);
            lozinka_txt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Lozinka";
            // 
            // login_btn
            // 
            login_btn.Location = new Point(297, 15);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(132, 49);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 78);
            button1.Name = "button1";
            button1.Size = new Size(132, 49);
            button1.TabIndex = 5;
            button1.Text = "Registracija";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 139);
            Controls.Add(button1);
            Controls.Add(login_btn);
            Controls.Add(lozinka_txt);
            Controls.Add(label2);
            Controls.Add(korisnickoIme_txt);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logovanje";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox korisnickoIme_txt;
        private TextBox lozinka_txt;
        private Label label2;
        private Button login_btn;
        private Button button1;
    }
}