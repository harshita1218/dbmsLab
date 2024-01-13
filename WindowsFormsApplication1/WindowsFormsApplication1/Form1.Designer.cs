namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWWINDIWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zOOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wORDWRAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pASTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINDNEXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINDPREVIOUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPLACEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gOTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELECTALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIMEDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem1,
            this.vIEWToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.cOLORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fILEToolStripMenuItem1
            // 
            this.fILEToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem1,
            this.nEWWINDIWToolStripMenuItem,
            this.oPENToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.sAVEASToolStripMenuItem,
            this.pRINTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem1.Name = "fILEToolStripMenuItem1";
            this.fILEToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem1.Text = "FILE";
            this.fILEToolStripMenuItem1.Click += new System.EventHandler(this.fILEToolStripMenuItem1_Click);
            // 
            // nEWToolStripMenuItem1
            // 
            this.nEWToolStripMenuItem1.Name = "nEWToolStripMenuItem1";
            this.nEWToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.nEWToolStripMenuItem1.Text = "NEW ";
            // 
            // nEWWINDIWToolStripMenuItem
            // 
            this.nEWWINDIWToolStripMenuItem.Name = "nEWWINDIWToolStripMenuItem";
            this.nEWWINDIWToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nEWWINDIWToolStripMenuItem.Text = "NEW WINDOW";
            this.nEWWINDIWToolStripMenuItem.Click += new System.EventHandler(this.nEWWINDIWToolStripMenuItem_Click);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.oPENToolStripMenuItem.Text = "OPEN ";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // sAVEASToolStripMenuItem
            // 
            this.sAVEASToolStripMenuItem.Name = "sAVEASToolStripMenuItem";
            this.sAVEASToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sAVEASToolStripMenuItem.Text = "SAVE AS";
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zOOMToolStripMenuItem,
            this.wORDWRAPToolStripMenuItem});
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            this.vIEWToolStripMenuItem.Click += new System.EventHandler(this.vIEWToolStripMenuItem_Click);
            // 
            // zOOMToolStripMenuItem
            // 
            this.zOOMToolStripMenuItem.Name = "zOOMToolStripMenuItem";
            this.zOOMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zOOMToolStripMenuItem.Text = "ZOOM";
            // 
            // wORDWRAPToolStripMenuItem
            // 
            this.wORDWRAPToolStripMenuItem.Name = "wORDWRAPToolStripMenuItem";
            this.wORDWRAPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wORDWRAPToolStripMenuItem.Text = "WORD WRAP";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNDOToolStripMenuItem,
            this.cUTToolStripMenuItem,
            this.cOPYToolStripMenuItem,
            this.pASTEToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.fINDToolStripMenuItem,
            this.fINDNEXTToolStripMenuItem,
            this.fINDPREVIOUSToolStripMenuItem,
            this.rEPLACEToolStripMenuItem,
            this.gOTOToolStripMenuItem,
            this.sELECTALLToolStripMenuItem,
            this.tIMEDATEToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // uNDOToolStripMenuItem
            // 
            this.uNDOToolStripMenuItem.Name = "uNDOToolStripMenuItem";
            this.uNDOToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.uNDOToolStripMenuItem.Text = "UNDO";
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cUTToolStripMenuItem.Text = "CUT";
            // 
            // cOPYToolStripMenuItem
            // 
            this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
            this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cOPYToolStripMenuItem.Text = "COPY";
            // 
            // pASTEToolStripMenuItem
            // 
            this.pASTEToolStripMenuItem.Name = "pASTEToolStripMenuItem";
            this.pASTEToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pASTEToolStripMenuItem.Text = "PASTE";
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            // 
            // fINDToolStripMenuItem
            // 
            this.fINDToolStripMenuItem.Name = "fINDToolStripMenuItem";
            this.fINDToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fINDToolStripMenuItem.Text = "FIND";
            // 
            // fINDNEXTToolStripMenuItem
            // 
            this.fINDNEXTToolStripMenuItem.Name = "fINDNEXTToolStripMenuItem";
            this.fINDNEXTToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fINDNEXTToolStripMenuItem.Text = "FIND NEXT";
            // 
            // fINDPREVIOUSToolStripMenuItem
            // 
            this.fINDPREVIOUSToolStripMenuItem.Name = "fINDPREVIOUSToolStripMenuItem";
            this.fINDPREVIOUSToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fINDPREVIOUSToolStripMenuItem.Text = "FIND PREVIOUS";
            // 
            // rEPLACEToolStripMenuItem
            // 
            this.rEPLACEToolStripMenuItem.Name = "rEPLACEToolStripMenuItem";
            this.rEPLACEToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rEPLACEToolStripMenuItem.Text = "REPLACE";
            // 
            // gOTOToolStripMenuItem
            // 
            this.gOTOToolStripMenuItem.Name = "gOTOToolStripMenuItem";
            this.gOTOToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gOTOToolStripMenuItem.Text = "GO TO";
            // 
            // sELECTALLToolStripMenuItem
            // 
            this.sELECTALLToolStripMenuItem.Name = "sELECTALLToolStripMenuItem";
            this.sELECTALLToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sELECTALLToolStripMenuItem.Text = "SELECT ALL";
            // 
            // tIMEDATEToolStripMenuItem
            // 
            this.tIMEDATEToolStripMenuItem.Name = "tIMEDATEToolStripMenuItem";
            this.tIMEDATEToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tIMEDATEToolStripMenuItem.Text = "TIME DATE";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(979, 493);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // cOLORToolStripMenuItem
            // 
            this.cOLORToolStripMenuItem.Name = "cOLORToolStripMenuItem";
            this.cOLORToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.cOLORToolStripMenuItem.Text = "COLOR";
            this.cOLORToolStripMenuItem.Click += new System.EventHandler(this.cOLORToolStripMenuItem_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.DarkSlateBlue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 510);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nEWWINDIWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zOOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wORDWRAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pASTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINDNEXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINDPREVIOUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPLACEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gOTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELECTALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIMEDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLORToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ColorDialog colorDialog1;

    }
}

