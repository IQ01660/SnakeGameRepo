using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Snake firstSnake = new Snake(30, 30, 6, 150, 70);
            foreach (var piece in SnakePiece.snakePieces)
            {
                Controls.Add(piece);
            }
        }
    }
    public class Snake
    {
        public int HorSpeed { get; set; }
        public int VerSpeed { get; set; }
        public int PiecesCount { get; set; }
        public int HeadX { get; set; }
        public int HeadY { get; set; }
        public Snake(int _horSp, int _verSp, int _piecesCount, int _headX, int _headY)
        {
            HorSpeed = _horSp;
            VerSpeed = _verSp;
            PiecesCount = _piecesCount;
            HeadX = _headX;
            HeadY = _headY;
            // building the initial pieces
            SnakePiece head = new SnakePiece(HeadX, HeadY, true);
            int tempX = HeadX;
            for (int i = 1; i < PiecesCount; i++)
            {
                tempX -= 30;
                new SnakePiece(tempX, HeadY, false);
            }
    }

    }
    public class SnakePiece
    {
        public static List<Button> snakePieces = new List<Button>();
        // to store the coordinates of previous location to make the snake bend
        public static List<SnakePiece> previousCoordinates = new List<SnakePiece>();
        public int LocX { get; set; }
        public int LocY { get; set; }
        public bool isHead { get; set;}
        public SnakePiece(int _x, int _y, bool _isHead)
        {
            this.LocX = _x;
            this.LocY = _y;
            var newPiece = new Button { Left = this.LocX, Top = this.LocY, BackColor = Color.Aquamarine, FlatStyle = FlatStyle.Flat, Width = 30, Height = 30 };
            
            if (_isHead == true)
            {
                newPiece.BackColor = Color.BlueViolet;
            }
            snakePieces.Add(newPiece);

        }
    }
}
