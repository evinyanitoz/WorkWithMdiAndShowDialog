namespace WorkWithMdiAndShowDialog
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rENGİNİDEĞİŞTİRToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ContextMenuStrip = contextMenuStrip1;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(182, 176);
            label1.Name = "label1";
            label1.Size = new Size(327, 31);
            label1.TabIndex = 0;
            label1.Text = "SHOWDIALOG İLE ÇALIŞMAK";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { rENGİNİDEĞİŞTİRToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            // 
            // rENGİNİDEĞİŞTİRToolStripMenuItem
            // 
            rENGİNİDEĞİŞTİRToolStripMenuItem.Name = "rENGİNİDEĞİŞTİRToolStripMenuItem";
            rENGİNİDEĞİŞTİRToolStripMenuItem.Size = new Size(210, 24);
            rENGİNİDEĞİŞTİRToolStripMenuItem.Text = "RENGİNİ DEĞİŞTİR";
            rENGİNİDEĞİŞTİRToolStripMenuItem.Click += rENGİNİDEĞİŞTİRToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem rENGİNİDEĞİŞTİRToolStripMenuItem;
        private ColorDialog colorDialog1;
    }
}
