using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace _2048_gridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grid1.UpdateScore += grid1_UpdateScore;
            grid1.Reached2048 += grid1_Reached2048;
            grid1.UpdateMoves += grid1_UpdateMoves;
            score_lbl.Text = "Очки: " + grid1.Score;
            move_lbl.Text = "Ходы: " + grid1.CurrentMoves;
            if (!Directory.Exists("Save")) Directory.CreateDirectory("Save");
        }

        void grid1_UpdateMoves(object sender, UpdateMovesEventArgs e)
        {
            int moves = e.Moves;
            this.move_lbl.Text = "Ходы: " + moves.ToString();
        }

        public Grid MainGrid { get { return grid1; } }

        void grid1_Reached2048(object sender, EventArgs e)
        {
            try
            {
                Reach2048 panel = new Reach2048(this);
                panel.Continue += panel_Continue;
                panel.Reset += panel_Reset;
                panel.Name = "ReachPanel";
                MaskedDialog.ShowDialog(this, panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void removePanel()
        {

        }

        public event EventHandler ClosePopup;

        void panel_Reset(object sender, EventArgs e)
        {
            if (ClosePopup != null) ClosePopup(this, EventArgs.Empty);
            grid1.ResetGame();
        }

        void panel_Continue(object sender, EventArgs e)
        {
            if (ClosePopup != null) ClosePopup(this, EventArgs.Empty);
        }

        void grid1_UpdateGrid(object sender, EventArgs e)
        {
            grid1.Refresh();
        }

        void grid1_UpdateScore(object sender, EventArgs e)
        {
            score_lbl.Text = "Очки: " + (sender as Grid).Score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void KeyMove(Moves move)
        {
            grid1.KeyMove(move);
        }

        void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                KeyMove(Moves.Up);
            else if (e.KeyCode == Keys.Down)
                KeyMove(Moves.Down);
            else if (e.KeyCode == Keys.Left)
                KeyMove(Moves.Left);
            else if (e.KeyCode == Keys.Right)
                KeyMove(Moves.Right);
            else if (e.KeyCode == Keys.F2)
                grid1.ResetGame();
        }
        private void grid1_KeyDown(object sender, KeyEventArgs e)
        {
            Grid_KeyDown(sender, e);
        }

        private void grid1_MouseHover(object sender, EventArgs e)
        {
            grid1.Focus();
        }

        private void toolStripContainer1_ContentPanel_MouseHover(object sender, EventArgs e)
        {
            grid1.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                KeyMove(Moves.Left);
                return true;
            }
            else if (keyData == Keys.Right)
            {
                KeyMove(Moves.Right);
                return true;
            }
            else if (keyData == Keys.Up)
            {
                KeyMove(Moves.Up);
                return true;
            }
            else if (keyData == Keys.Down)
            {
                KeyMove(Moves.Down);
                return true;
            }
            else if (keyData == Keys.R)
            {
                grid1.ResetGame();
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid1.ResetGame();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            grid1.ResetGame();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
        {
            try
            {
                var fdialog = new OpenFileDialog();
                fdialog.Filter = "sin files (*.sin)|*.sin|All files (*.*)|*.*";
                var dialog = fdialog.ShowDialog();
                fdialog.InitialDirectory = "Save";
                fdialog.RestoreDirectory = true;
                if (dialog == System.Windows.Forms.DialogResult.OK)
                {
                    string fullPath = fdialog.FileName;
                    grid1.LoadGame(fdialog.FileName);
                    Application.DoEvents();
                    this.Refresh();
                }
            }
            catch
                (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            try
            {
                var fdialog = new SaveFileDialog();
                fdialog.Filter = "sin files (*.sin)|*.sin|All files (*.*)|*.*";
                fdialog.InitialDirectory = "Save";
                fdialog.RestoreDirectory = true;
                var dialog = fdialog.ShowDialog();
                if (dialog == System.Windows.Forms.DialogResult.OK)
                {
                    string file = Path.GetFileNameWithoutExtension(fdialog.FileName) + ".sin";
                    string fullPath = fdialog.FileName;
                    string path = fullPath.Replace(file, "");
                    grid1.SaveGame(path + "\\" + file);
                    Application.DoEvents();
                    this.Refresh();
                }
            }
            catch
                (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string text = "\r\nИгра '2048'\r\nбыла разработана \r\nG-NighT в 2017 году\r\n\r\nВ рамках курсового \r\nпроекта по ООП";
            string vk = "https://vk.com/g_night";
            var panel = new Popup(text, vk);
            MaskedDialog.ShowDialog(this, panel);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                grid1.ResetGame();
            if (e.Control && e.KeyCode == Keys.S)
                saveFile();
            if (e.Control && e.KeyCode == Keys.O)
                openFile();
        }
    }
}
