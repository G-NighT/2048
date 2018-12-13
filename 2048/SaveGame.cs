using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _2048_gridView
{
    [Serializable]
    public class SaveGame
    {
        private int _score;
        private int _moves;

        public int Moves
        {
            get { return _moves; }
            set { _moves = value; }
        }
        private int[,] tiles;

        public SaveGame()
        {
            Tiles = new int[4, 4];
            Score = 0;
        }
        public SaveGame(Tile[,] Tiles, int Score, int Moves)
        {
            this.Score = Score;
            this.Moves = Moves;
            this.Tiles = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    try
                    {
                        this.Tiles[i, j] = Convert.ToInt32(Tiles[i, j].Value);
                    }
                    catch (Exception)
                    {
                        this.Tiles[i, j] = 0;
                    }
                }
            }
        }
        

        public Tile[,] GetTiles()
        {
            Tile[,] Tiles = new Tile[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Tiles[i, j] = new Tile();
                    Tiles[i, j].Type = (this.Tiles[i, j] == 0) ? TileNumbers.TileEmpty : Helper.ValueToTile(this.Tiles[i, j].ToString());
                }
            }
            return Tiles;
        }

        public int[,] Tiles
        {
            get { return tiles; }
            set { tiles = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public void SaveGameToFile(string filename)
        {
            try
            {
                var flattenTiles = Helper.FlattenTiles(this.Tiles);
                Array.Resize(ref flattenTiles, flattenTiles.Length + 2);
                flattenTiles[flattenTiles.Length - 1] = this.Moves;
                flattenTiles[flattenTiles.Length - 2] = this.Score;
                var bf = new BinaryFormatter();
                var ms = new MemoryStream();
                bf.Serialize(ms, flattenTiles);
                File.WriteAllBytes(filename, ms.ToArray());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void LoadGameFromFile(string filename)
        {
            try
            {
                var bf = new BinaryFormatter();
                var ms = File.Open(filename, FileMode.Open);
                var flattenTiles = (int[])bf.Deserialize(ms);
                var len = flattenTiles.Length;
                switch (len)
                {
                    case 22:
                        this.Moves = flattenTiles[flattenTiles.Length - 1];
                        this.Score = flattenTiles[flattenTiles.Length - 2];
                        Array.Resize(ref flattenTiles, flattenTiles.Length - 2);
                        Console.WriteLine(len);
                        break;
                    case 21:
                        this.Score = flattenTiles[flattenTiles.Length - 1];
                        Array.Resize(ref flattenTiles, flattenTiles.Length - 1);
                        //Console.WriteLine(len);
                        break;
                    default:
                        break;
                }
                this.Tiles = Helper.UnflattenTiles(flattenTiles);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
