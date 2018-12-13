using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _2048_gridView
{
    [Serializable]
    public partial class Tile : UserControl
    {
        private string _value;

        //private System.Threading.Timer timer;

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                tile_value.Text = _value;
                switch (value)
                {
                    case "2":
                    case "4":
                        tile_value.ForeColor = ColorTranslator.FromHtml("#776e65");
                        tile_value.Font = new System.Drawing.Font(tile_value.Font.FontFamily, 55, System.Drawing.GraphicsUnit.Pixel);
                        tile_value.Location = new System.Drawing.Point(23, 23);
                        break;
                    case "8":
                        tile_value.ForeColor = ColorTranslator.FromHtml("#f9f6f2");
                        tile_value.Font = new System.Drawing.Font(tile_value.Font.FontFamily, 55, System.Drawing.GraphicsUnit.Pixel);
                        tile_value.Location = new System.Drawing.Point(23, 23);
                        break;
                    case "16":
                    case "32":
                    case "64":
                        tile_value.ForeColor = ColorTranslator.FromHtml("#f9f6f2");
                        tile_value.Font = new System.Drawing.Font(tile_value.Font.FontFamily, 55, System.Drawing.GraphicsUnit.Pixel);
                        tile_value.Location = new System.Drawing.Point(6, 23);
                        break;
                    case "128":
                    case "256":
                    case "512":
                        tile_value.ForeColor = ColorTranslator.FromHtml("#f9f6f2");
                        tile_value.Font = new System.Drawing.Font(tile_value.Font.FontFamily, 45, System.Drawing.GraphicsUnit.Pixel);
                        tile_value.Location = new System.Drawing.Point(0, 27);
                        break;
                    case "1024":
                    case "2048":
                        tile_value.ForeColor = ColorTranslator.FromHtml("#f9f6f2");
                        tile_value.Font = new System.Drawing.Font(tile_value.Font.FontFamily, 35, System.Drawing.GraphicsUnit.Pixel);
                        tile_value.Location = new System.Drawing.Point(1, 30);
                        break;
                    case "4096":
                    case "8192":
                    case "16384":
                        tile_value.ForeColor = ColorTranslator.FromHtml("#776e65");
                        tile_value.Font = new System.Drawing.Font(tile_value.Font.FontFamily, 35, System.Drawing.GraphicsUnit.Pixel);
                        tile_value.Location = new System.Drawing.Point(1, 30);
                        break;
                    default:
                        break;
                }
            }
        }
        private TileNumbers _type;
        public TileNumbers Type
        {
            get { return _type; }
            set
            {
                //if (value != TileNumbers.TileEmpty) ChangeTileSize();
                switch (value)
                {
                    case TileNumbers.Tile2:
                        _type = TileNumbers.Tile2;
                        OuterColor = ColorTranslator.FromHtml("#eee4da");
                        InnerColor = ColorTranslator.FromHtml("#eee4da");
                        Value = "2";
                        break;
                    case TileNumbers.Tile4:
                        _type = TileNumbers.Tile4;
                        OuterColor = ColorTranslator.FromHtml("#ede0c8");
                        InnerColor = ColorTranslator.FromHtml("#ede0c8");
                        Value = "4";
                        break;
                    case TileNumbers.Tile8:
                        _type = TileNumbers.Tile8;
                        OuterColor = ColorTranslator.FromHtml("#f2b179");
                        InnerColor = ColorTranslator.FromHtml("#f2b179");
                        Value = "8";
                        break;
                    case TileNumbers.Tile16:
                        _type = TileNumbers.Tile16;
                        OuterColor = ColorTranslator.FromHtml("#f59563");
                        InnerColor = ColorTranslator.FromHtml("#f59563");
                        Value = "16";
                        break;
                    case TileNumbers.Tile32:
                        _type = TileNumbers.Tile32;
                        OuterColor = ColorTranslator.FromHtml("#f67c5f");
                        InnerColor = ColorTranslator.FromHtml("#f67c5f");
                        Value = "32";
                        break;
                    case TileNumbers.Tile64:
                        _type = TileNumbers.Tile64;
                        OuterColor = ColorTranslator.FromHtml("#f65e3b");
                        InnerColor = ColorTranslator.FromHtml("#f65e3b");
                        Value = "64";
                        break;
                    case TileNumbers.Tile128:
                        _type = TileNumbers.Tile128;
                        OuterColor = ColorTranslator.FromHtml("#eed585");
                        InnerColor = ColorTranslator.FromHtml("#edcf72");
                        Value = "128";
                        break;
                    case TileNumbers.Tile256:
                        _type = TileNumbers.Tile256;
                        OuterColor = ColorTranslator.FromHtml("#efd47e");
                        InnerColor = ColorTranslator.FromHtml("#edcc61");
                        Value = "256";
                        break;
                    case TileNumbers.Tile512:
                        _type = TileNumbers.Tile512;
                        OuterColor = ColorTranslator.FromHtml("#f1d577");
                        InnerColor = ColorTranslator.FromHtml("#ecc750");
                        Value = "512";
                        break;
                    case TileNumbers.Tile1024:
                        _type = TileNumbers.Tile1024;
                        OuterColor = ColorTranslator.FromHtml("#f1d575");
                        InnerColor = ColorTranslator.FromHtml("#edc53f");
                        Value = "1024";
                        break;
                    case TileNumbers.Tile2048:
                        _type = TileNumbers.Tile2048;
                        OuterColor = ColorTranslator.FromHtml("#f2d573");
                        InnerColor = ColorTranslator.FromHtml("#edc22e");
                        Value = "2048";
                        break;
                    case TileNumbers.Tile4096:
                        _type = TileNumbers.Tile4096;
                        InnerColor = ColorTranslator.FromHtml("#3c3a32");
                        OuterColor = ColorTranslator.FromHtml("#dfca82");
                        Value = "4096";
                        break;
                    case TileNumbers.Tile8192:
                        _type = TileNumbers.Tile8192;
                        InnerColor = ColorTranslator.FromHtml("#3c3a32");
                        OuterColor = ColorTranslator.FromHtml("#dfca82");
                        Value = "8192";
                        break;
                    case TileNumbers.Tile16384:
                        _type = TileNumbers.Tile16384;
                        InnerColor = ColorTranslator.FromHtml("#3c3a32");
                        OuterColor = ColorTranslator.FromHtml("#dfca82");
                        Value = "16384";
                        break;
                    default:
                        _type = TileNumbers.TileEmpty;
                        OuterColor = ColorTranslator.FromHtml("#ccc0b3");
                        InnerColor = ColorTranslator.FromHtml("#ccc0b3");
                        Value = "";
                        break;
                }
            }
        }

        private System.Drawing.Color _outerColor;

        public System.Drawing.Color OuterColor
        {
            get { return _outerColor; }
            set
            {
                _outerColor = value;
                toolStripContainer1.TopToolStripPanel.BackColor =
                    toolStripContainer1.LeftToolStripPanel.BackColor =
                    toolStripContainer1.BottomToolStripPanel.BackColor =
                    toolStripContainer1.RightToolStripPanel.BackColor =
                    _outerColor;
            }
        }
        private System.Drawing.Color _innerColor;

        public System.Drawing.Color InnerColor
        {
            get { return _innerColor; }
            set
            {
                _innerColor = value;
                toolStripContainer1.ContentPanel.BackColor = _innerColor;
            }
        }
        private Font _font;

        public Font TextFont
        {
            get { return _font; }
            set { _font = value; }
        }

        public Tile()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Type = TileNumbers.TileEmpty;
        }

        private void tile_value_Click(object sender, EventArgs e)
        {

        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Right || keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left)
                return true;
            else return base.IsInputKey(keyData);
        }
    }
}
