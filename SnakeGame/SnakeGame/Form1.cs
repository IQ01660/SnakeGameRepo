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
        public Snake firstSnake = new Snake(30, 30, 5, 150, 70);// NOTE!: the speeds should be the same as the dimensions of buttons(You can check them in SnakePiece Constructor)
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (var piece in SnakePiece.snakePieces)
            {
                Controls.Add(piece);
            }

        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            firstSnake.MoveUp();
            //setting restrictions
            foreach (var piece in SnakePiece.snakePieces)
            {
                if (piece.BackColor == Color.BlueViolet)// if the piece is head
                {
                    if (piece.Left >= this.Width || piece.Left <= 0 || piece.Top <= 0 || piece.Top >= this.Height)
                    {
                        MessageBox.Show("LOSER!!!");
                        this.Hide();
                    }
                    foreach (var bodyPiece in SnakePiece.snakePieces)
                    {
                        if (bodyPiece.BackColor != piece.BackColor && bodyPiece.Left == piece.Left && bodyPiece.Top == piece.Top)
                        {
                            MessageBox.Show("LOSER!!!");
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            firstSnake.MoveDown();
            foreach (var piece in SnakePiece.snakePieces)
            {
                if (piece.BackColor == Color.BlueViolet)// if the piece is head
                {
                    if (piece.Left >= this.Width || piece.Left <= 0 || piece.Top <= 0 || piece.Top >= this.Height)
                    {
                        MessageBox.Show("LOSER!!!");
                        this.Hide();
                    }
                    foreach (var bodyPiece in SnakePiece.snakePieces)
                    {
                        if (bodyPiece.BackColor != piece.BackColor && bodyPiece.Left == piece.Left && bodyPiece.Top == piece.Top)
                        {
                            MessageBox.Show("LOSER!!!");
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            firstSnake.MoveLeft();
            foreach (var piece in SnakePiece.snakePieces)
            {
                if (piece.BackColor == Color.BlueViolet)// if the piece is head
                {
                    if (piece.Left >= this.Width || piece.Left <= 0 || piece.Top <= 0 || piece.Top >= this.Height)
                    {
                        MessageBox.Show("LOSER!!!");
                        this.Hide();
                    }
                    foreach (var bodyPiece in SnakePiece.snakePieces)
                    {
                        if (bodyPiece.BackColor != piece.BackColor && bodyPiece.Left == piece.Left && bodyPiece.Top == piece.Top)
                        {
                            MessageBox.Show("LOSER!!!");
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            firstSnake.MoveRight();
            foreach (var piece in SnakePiece.snakePieces)
            {
                if (piece.BackColor == Color.BlueViolet)// if the piece is head
                {
                    if (piece.Left >= this.Width || piece.Left <= 0 || piece.Top <= 0 || piece.Top >= this.Height)
                    {
                        MessageBox.Show("LOSER!!!");
                        this.Hide();
                    }
                    foreach (var bodyPiece in SnakePiece.snakePieces)
                    {
                        if (bodyPiece.BackColor != piece.BackColor && bodyPiece.Left == piece.Left && bodyPiece.Top == piece.Top)
                        {
                            MessageBox.Show("LOSER!!!");
                            this.Hide();
                        }
                    }
                }
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
                tempX -= HorSpeed;
                new SnakePiece(tempX, HeadY, false);
            }
        }
        public void MoveDown()
        {
            //saving the previous coordinates
            foreach (var piece in SnakePiece.snakePieces)
            {
                XY_Coordinate myCoor = new XY_Coordinate();
                myCoor.X = piece.Left;
                myCoor.Y = piece.Top;
                SnakePiece.previousCoordinates.Add(myCoor);
            }
            //moving the head of the snake downwards by 30
            foreach (var piece in SnakePiece.snakePieces)
            {
                if (piece.BackColor == Color.BlueViolet)
                {
                    piece.Top += VerSpeed;
                }
            }
            for (int i = 1; i < SnakePiece.snakePieces.Count; i++)
            {
                SnakePiece.snakePieces[i].Left = SnakePiece.previousCoordinates[i - 1].X;
                SnakePiece.snakePieces[i].Top = SnakePiece.previousCoordinates[i - 1].Y;
            }
            SnakePiece.previousCoordinates.Clear();
        }
        public void MoveUp()
        {
            //saving the previous coordinates
            foreach (var piece in SnakePiece.snakePieces)
            {
                XY_Coordinate myCoor = new XY_Coordinate();
                myCoor.X = piece.Left;
                myCoor.Y = piece.Top;
                SnakePiece.previousCoordinates.Add(myCoor);
            }
            //moving the head of the snake downwards by 30
            foreach (var piece in SnakePiece.snakePieces)
            {
                if (piece.BackColor == Color.BlueViolet)
                {
                    piece.Top -= VerSpeed;
                }
            }
            for (int i = 1; i < SnakePiece.snakePieces.Count; i++)
            {
                SnakePiece.snakePieces[i].Left = SnakePiece.previousCoordinates[i - 1].X;
                SnakePiece.snakePieces[i].Top = SnakePiece.previousCoordinates[i - 1].Y;
            }
            SnakePiece.previousCoordinates.Clear();
        }
        public void MoveRight()
        {
            //saving the previous coordinates
            foreach (var piece in SnakePiece.snakePieces)
            {
                XY_Coordinate myCoor = new XY_Coordinate();
                myCoor.X = piece.Left;
                myCoor.Y = piece.Top;
                SnakePiece.previousCoordinates.Add(myCoor);
            }
            //moving the head of the snake downwards by 30
            foreach (var piece in SnakePiece.snakePieces)
            {
                if (piece.BackColor == Color.BlueViolet)
                {
                    piece.Left += HorSpeed;
                }
            }
            for (int i = 1; i < SnakePiece.snakePieces.Count; i++)
            {
                SnakePiece.snakePieces[i].Left = SnakePiece.previousCoordinates[i - 1].X;
                SnakePiece.snakePieces[i].Top = SnakePiece.previousCoordinates[i - 1].Y;
            }
            SnakePiece.previousCoordinates.Clear();
        }
        public void MoveLeft()
        {
            //saving the previous coordinates
            foreach (var piece in SnakePiece.snakePieces)
            {
                XY_Coordinate myCoor = new XY_Coordinate();
                myCoor.X = piece.Left;
                myCoor.Y = piece.Top;
                SnakePiece.previousCoordinates.Add(myCoor);
            }
            //moving the head of the snake downwards by 30
            foreach (var piece in SnakePiece.snakePieces)
            {
                if (piece.BackColor == Color.BlueViolet)
                {
                    piece.Left -= HorSpeed;
                }
            }
            for (int i = 1; i < SnakePiece.snakePieces.Count; i++)
            {
                SnakePiece.snakePieces[i].Left = SnakePiece.previousCoordinates[i - 1].X;
                SnakePiece.snakePieces[i].Top = SnakePiece.previousCoordinates[i - 1].Y;
            }
            SnakePiece.previousCoordinates.Clear();
        }

    }
    public class SnakePiece
    {
        public static List<Button> snakePieces = new List<Button>();
        // to store the coordinates of previous location to make the snake bend
        public static List<XY_Coordinate> previousCoordinates = new List<XY_Coordinate>();
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
    public class XY_Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
