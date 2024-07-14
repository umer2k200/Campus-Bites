namespace Cmpusbites_2
{
    partial class CafeMhiringremovecashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CafeMhiringremovecashier));
            textBox1 = new TextBox();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(685, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 22);
            textBox1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("PhrasticMedium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(592, 253);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 21;
            label3.Text = "USERNAME";
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("PhrasticMedium", 20.2499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(680, 167);
            label8.Name = "label8";
            label8.Size = new Size(209, 30);
            label8.TabIndex = 20;
            label8.Text = "Remove Cashier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("PhrasticMedium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(135, 152);
            label2.Name = "label2";
            label2.Size = new Size(82, 26);
            label2.TabIndex = 24;
            label2.Text = "HIRING";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("PhrasticMedium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(755, 13);
            label1.Name = "label1";
            label1.Size = new Size(161, 26);
            label1.TabIndex = 23;
            label1.Text = "CAMPUSBITES";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(737, 290);
            button2.Name = "button2";
            button2.Size = new Size(89, 29);
            button2.TabIndex = 26;
            button2.Text = "REMOVE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "<- Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CafeMhiringremovecashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(920, 494);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label8);
            Name = "CafeMhiringremovecashier";
            Text = "CAMPUSBITES | CAFE MANAGER | REMOVING CASHIER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label3;
        private Label label8;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}