﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_gridView
{
    public class MaskedDialog : Form
    {
        private Form dialog;
        private MaskedDialog(Form parent, Form dialog)
        {
            this.dialog = dialog;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Opacity = 0.50;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = parent.ClientSize;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            parent.Move += AdjustPosition;
            parent.SizeChanged += AdjustPosition;
        }
        private void AdjustPosition(object sender, EventArgs e)
        {
            Form parent = sender as Form;
            this.Location = parent.PointToScreen(System.Drawing.Point.Empty);
            this.ClientSize = parent.ClientSize;
        }
        public static DialogResult ShowDialog(Form parent, Form dialog)
        {
            var mask = new MaskedDialog(parent, dialog);
            (parent as Form1).ClosePopup += MaskedDialog_ClosePopup;
            dialog.StartPosition = FormStartPosition.CenterParent;
            mask.Show();
            var result = dialog.ShowDialog(mask);
            mask.Close();
            return result;
        }

        static void MaskedDialog_ClosePopup(object sender, EventArgs e)
        {
            
        }
    } 
}
