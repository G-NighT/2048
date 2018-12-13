using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace _2048_gridView
{
    public partial class Reach2048 : Form
    {
        public event EventHandler Continue;
        public event EventHandler Reset;
        public Reach2048(Form1 parent)
        {
            InitializeComponent();
            try
            {
                parent.ClosePopup += Reach2048_ClosePopup;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        void Reach2048_ClosePopup(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reach2048_Paint(object sender, PaintEventArgs e)
        {
            this.Opacity = 0.5;
            //var hb = new HatchBrush(HatchStyle.Percent50, Color.FromArgb(0, 0, 0, 0));
            //e.Graphics.FillRectangle(hb, this.DisplayRectangle);
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT
        //        return cp;
        //    }
        //}

        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(128, 101, 135, 196)), this.ClientRectangle);
        //    pe.Graphics.DrawRectangle(Pens.DarkBlue,
        //      pe.ClipRectangle.Left,
        //      pe.ClipRectangle.Top,
        //      this.Width - 1,
        //      this.Height - 1);
        //}

        //protected override void OnPaintBackground(PaintEventArgs pevent)
        //{
        //    //do not allow the background to be painted 
        //}

        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //}

        private void Reach2048_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Reset != null) Reset(this, EventArgs.Empty);
            //Thread.Sleep(100);
            //this.Close();
            //try
            //{
            //    (this.Parent as Form1).MainGrid.ResetGame();
            //}
            //catch (Exception) { }
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Continue != null) Continue(this, EventArgs.Empty);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
