namespace Cmpusbites_2
{
    partial class CafeMhiringremoveinvmanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CafeMhiringremoveinvmanager));
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(-1, -2);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 34;
            button1.Text = "<- Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(736, 288);
            button2.Name = "button2";
            button2.Size = new Size(89, 29);
            button2.TabIndex = 33;
            button2.Text = "REMOVE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("PhrasticMedium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(134, 150);
            label2.Name = "label2";
            label2.Size = new Size(82, 26);
            label2.TabIndex = 32;
            label2.Text = "HIRING";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("PhrasticMedium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(754, 11);
            label1.Name = "label1";
            label1.Size = new Size(161, 26);
            label1.TabIndex = 31;
            label1.Text = "CAMPUSBITES";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(684, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 22);
            textBox1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("PhrasticMedium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(591, 251);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 29;
            label3.Text = "USERNAME";
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("PhrasticMedium", 20.2499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(570, 161);
            label8.Name = "label8";
            label8.Size = new Size(345, 30);
            label8.TabIndex = 28;
            label8.Text = "Remove Inventory Manager";
            // 
            // CafeMhiringremoveinvmanager
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
            Name = "CafeMhiringremoveinvmanager";
            Text = "CAMPUSBITES | CAFE MANAGER | REMOVIING INVENTORY MANAGER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label8;
    }
}