namespace week6
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
            txtsum = new Button();
            menha = new Button();
            taghsim = new Button();
            zarb = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // txtsum
            // 
            txtsum.Location = new Point(468, 143);
            txtsum.Name = "txtsum";
            txtsum.Size = new Size(75, 23);
            txtsum.TabIndex = 0;
            txtsum.Text = "+";
            txtsum.UseVisualStyleBackColor = true;
            txtsum.Click += txtsum_Click;
            // 
            // menha
            // 
            menha.Location = new Point(387, 143);
            menha.Name = "menha";
            menha.Size = new Size(75, 23);
            menha.TabIndex = 1;
            menha.Text = "-";
            menha.UseVisualStyleBackColor = true;
            menha.Click += menha_Click;
            // 
            // taghsim
            // 
            taghsim.Location = new Point(306, 143);
            taghsim.Name = "taghsim";
            taghsim.Size = new Size(75, 23);
            taghsim.TabIndex = 2;
            taghsim.Text = "/";
            taghsim.UseVisualStyleBackColor = true;
            taghsim.Click += taghsim_Click;
            // 
            // zarb
            // 
            zarb.Location = new Point(225, 143);
            zarb.Name = "zarb";
            zarb.Size = new Size(75, 23);
            zarb.TabIndex = 3;
            zarb.Text = "*";
            zarb.UseVisualStyleBackColor = true;
            zarb.Click += zarb_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Location = new Point(314, 263);
            label1.Name = "label1";
            label1.Size = new Size(157, 43);
            label1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(314, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(zarb);
            Controls.Add(taghsim);
            Controls.Add(menha);
            Controls.Add(txtsum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtsum;
        private Button menha;
        private Button taghsim;
        private Button zarb;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
