namespace Cmpusbites_2
{
    partial class InvMviewinventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvMviewinventory));
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            hIRINGToolStripMenuItem = new ToolStripMenuItem();
            mENUMANAGEToolStripMenuItem = new ToolStripMenuItem();
            rEMOVEITEMToolStripMenuItem = new ToolStripMenuItem();
            vIEWSALESToolStripMenuItem = new ToolStripMenuItem();
            vIEWINVENTORYToolStripMenuItem = new ToolStripMenuItem();
            sETCOUPONSToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("PhrasticMedium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(186, 96);
            label2.Name = "label2";
            label2.Size = new Size(203, 26);
            label2.TabIndex = 45;
            label2.Text = "INVENTORY ITEMS";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hIRINGToolStripMenuItem, mENUMANAGEToolStripMenuItem, rEMOVEITEMToolStripMenuItem, vIEWSALESToolStripMenuItem, vIEWINVENTORYToolStripMenuItem, sETCOUPONSToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 12, 0, 2);
            menuStrip1.Size = new Size(920, 32);
            menuStrip1.TabIndex = 44;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hIRINGToolStripMenuItem
            // 
            hIRINGToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            hIRINGToolStripMenuItem.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            hIRINGToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
            hIRINGToolStripMenuItem.Name = "hIRINGToolStripMenuItem";
            hIRINGToolStripMenuItem.Padding = new Padding(20, 0, 35, 0);
            hIRINGToolStripMenuItem.Size = new Size(114, 18);
            hIRINGToolStripMenuItem.Text = "ADD ITEM";
            hIRINGToolStripMenuItem.Click += hIRINGToolStripMenuItem_Click;
            // 
            // mENUMANAGEToolStripMenuItem
            // 
            mENUMANAGEToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            mENUMANAGEToolStripMenuItem.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            mENUMANAGEToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
            mENUMANAGEToolStripMenuItem.Name = "mENUMANAGEToolStripMenuItem";
            mENUMANAGEToolStripMenuItem.Padding = new Padding(20, 0, 35, 0);
            mENUMANAGEToolStripMenuItem.Size = new Size(133, 18);
            mENUMANAGEToolStripMenuItem.Text = "UPDATE ITEM";
            mENUMANAGEToolStripMenuItem.Click += mENUMANAGEToolStripMenuItem_Click;
            // 
            // rEMOVEITEMToolStripMenuItem
            // 
            rEMOVEITEMToolStripMenuItem.BackColor = Color.Black;
            rEMOVEITEMToolStripMenuItem.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            rEMOVEITEMToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
            rEMOVEITEMToolStripMenuItem.Name = "rEMOVEITEMToolStripMenuItem";
            rEMOVEITEMToolStripMenuItem.Padding = new Padding(20, 0, 35, 0);
            rEMOVEITEMToolStripMenuItem.Size = new Size(137, 18);
            rEMOVEITEMToolStripMenuItem.Text = "REMOVE ITEM";
            rEMOVEITEMToolStripMenuItem.Click += rEMOVEITEMToolStripMenuItem_Click;
            // 
            // vIEWSALESToolStripMenuItem
            // 
            vIEWSALESToolStripMenuItem.BackColor = Color.White;
            vIEWSALESToolStripMenuItem.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            vIEWSALESToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
            vIEWSALESToolStripMenuItem.Name = "vIEWSALESToolStripMenuItem";
            vIEWSALESToolStripMenuItem.Padding = new Padding(20, 0, 40, 0);
            vIEWSALESToolStripMenuItem.Size = new Size(155, 18);
            vIEWSALESToolStripMenuItem.Text = "VIEW INVENTORY";
            vIEWSALESToolStripMenuItem.Click += vIEWSALESToolStripMenuItem_Click;
            // 
            // vIEWINVENTORYToolStripMenuItem
            // 
            vIEWINVENTORYToolStripMenuItem.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            vIEWINVENTORYToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
            vIEWINVENTORYToolStripMenuItem.Name = "vIEWINVENTORYToolStripMenuItem";
            vIEWINVENTORYToolStripMenuItem.Padding = new Padding(20, 0, 35, 0);
            vIEWINVENTORYToolStripMenuItem.Size = new Size(120, 18);
            vIEWINVENTORYToolStripMenuItem.Text = "SUPPLIERS";
            vIEWINVENTORYToolStripMenuItem.Click += vIEWINVENTORYToolStripMenuItem_Click;
            // 
            // sETCOUPONSToolStripMenuItem
            // 
            sETCOUPONSToolStripMenuItem.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            sETCOUPONSToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
            sETCOUPONSToolStripMenuItem.Name = "sETCOUPONSToolStripMenuItem";
            sETCOUPONSToolStripMenuItem.Padding = new Padding(20, 0, 35, 0);
            sETCOUPONSToolStripMenuItem.Size = new Size(135, 18);
            sETCOUPONSToolStripMenuItem.Text = "ORDER ITEMS";
            sETCOUPONSToolStripMenuItem.Click += sETCOUPONSToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lOGOUTToolStripMenuItem.ForeColor = SystemColors.ControlDarkDark;
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Padding = new Padding(20, 0, 35, 0);
            lOGOUTToolStripMenuItem.Size = new Size(106, 18);
            lOGOUTToolStripMenuItem.Text = "LOGOUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("PhrasticMedium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(161, 26);
            label1.TabIndex = 43;
            label1.Text = "CAMPUSBITES";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("PhrasticMedium", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuText;
            dataGridViewCellStyle3.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(18, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("PhrasticMedium", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("PhrasticMedium", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 314);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // InvMviewinventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(920, 494);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "InvMviewinventory";
            Text = "CAMPUSBITES | INVENTORY MANAGER | VIEW INVENTORY";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hIRINGToolStripMenuItem;
        private ToolStripMenuItem mENUMANAGEToolStripMenuItem;
        private ToolStripMenuItem rEMOVEITEMToolStripMenuItem;
        private ToolStripMenuItem vIEWSALESToolStripMenuItem;
        private ToolStripMenuItem vIEWINVENTORYToolStripMenuItem;
        private ToolStripMenuItem sETCOUPONSToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private Label label1;
        private DataGridView dataGridView1;
    }
}