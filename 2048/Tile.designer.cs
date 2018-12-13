namespace _2048_gridView
{
    partial class Tile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tile_value = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.MaximumSize = new System.Drawing.Size(0, 2);
            this.toolStripContainer1.BottomToolStripPanel.MinimumSize = new System.Drawing.Size(0, 2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(106, 106);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.MaximumSize = new System.Drawing.Size(2, 0);
            this.toolStripContainer1.LeftToolStripPanel.MinimumSize = new System.Drawing.Size(2, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.MaximumSize = new System.Drawing.Size(2, 0);
            this.toolStripContainer1.RightToolStripPanel.MinimumSize = new System.Drawing.Size(2, 0);
            this.toolStripContainer1.Size = new System.Drawing.Size(110, 110);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.MaximumSize = new System.Drawing.Size(0, 2);
            this.toolStripContainer1.TopToolStripPanel.MinimumSize = new System.Drawing.Size(0, 2);
            // 
            // tile_value
            // 
            this.tile_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile_value.AutoSize = true;
            this.tile_value.Font = new System.Drawing.Font("Bookman Old Style", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tile_value.Location = new System.Drawing.Point(-2, 28);
            this.tile_value.Name = "tile_value";
            this.tile_value.Size = new System.Drawing.Size(106, 42);
            this.tile_value.TabIndex = 0;
            this.tile_value.Text = "1024";
            this.tile_value.Click += new System.EventHandler(this.tile_value_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.tile_value);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 107);
            this.panel1.TabIndex = 1;
            // 
            // Tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.MaximumSize = new System.Drawing.Size(110, 110);
            this.MinimumSize = new System.Drawing.Size(110, 110);
            this.Name = "Tile";
            this.Size = new System.Drawing.Size(110, 110);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label tile_value;
        private System.Windows.Forms.Panel panel1;
        //private OrientedTextLabel tile_value;
    }
}
