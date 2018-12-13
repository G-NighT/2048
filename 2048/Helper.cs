using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_gridView
{
    [Serializable]
    public enum TileNumbers
    {
        Tile2, Tile4, Tile8, Tile16, Tile32, Tile64, Tile128, Tile256, Tile512, Tile1024, Tile2048, TileEmpty, TileOther, Tile4096, Tile8192, Tile16384
    }

    [Serializable]
    public enum Moves
    {
        Up, Down, Right, Left
    }
    [Serializable]
    public class Helper
    {
        public static TileNumbers ValueToTile(string val)
        {
            switch (val)
            {
                case "": 
                    return TileNumbers.TileEmpty;
                case "2":
                    return TileNumbers.Tile2;
                case "4":
                    return TileNumbers.Tile4;
                case "8":
                    return TileNumbers.Tile8;
                case "16":
                    return TileNumbers.Tile16;
                case "32":
                    return TileNumbers.Tile32;
                case "64":
                    return TileNumbers.Tile64;
                case "128":
                    return TileNumbers.Tile128;
                case "256":
                    return TileNumbers.Tile256;
                case "512":
                    return TileNumbers.Tile512;
                case "1024":
                    return TileNumbers.Tile1024;
                case "2048":
                    return TileNumbers.Tile2048;
                case "4096":
                    return TileNumbers.Tile4096;
                case "8192":
                    return TileNumbers.Tile8192;
                case "16384":
                    return TileNumbers.Tile16384;
                default: 
                    return TileNumbers.TileOther;
            }
        }

        public static int[] FlattenTiles(int[,] Tiles)
        {
            int[] res = new int[4 * 4 + 4];
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    res[k++] = Tiles[i, j];
                    if (j == 3) res[k++] = -1;
                }
            }
            return res;
        }


        public static int[,] UnflattenTiles(int[] flattenTiles)
        {
            int[,] Tiles = new int[4, 4];
            int i = 0, j = 0;
            foreach (var k in flattenTiles)
            {
                if (k == -1)
                {
                    i++;
                    j = 0;
                    continue;
                }
                Tiles[i, j++] = k;
            }
            return Tiles;
        }
    }
}
