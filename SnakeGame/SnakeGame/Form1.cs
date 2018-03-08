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
        //**************************
        //INITIAL SNAKE
        //**************************
        public Snake firstSnake = new Snake(30, 30, 9, 300, 90);// NOTE!: the speeds should be the same as the dimensions of buttons(You can check them in SnakePiece Constructor)
        public Form1()
        {
            InitializeComponent();

        }
        //****************************
        //ADDITIONAL METHODS
        //****************************
        public void createApple()
        {
            Random rnd = new Random();
            int xRan = rnd.Next(3, (this.Width - 90) / 30);
            int yRan = rnd.Next(3, (this.Height - 90) / 30);
            Apple snakeFood = new Apple(xRan * 30, yRan * 30);
            Button appleBtn = new Button();
            appleBtn.Left = snakeFood.X;
            appleBtn.Top = snakeFood.Y;
            appleBtn.Width = 30;
            appleBtn.Height = 30;
            appleBtn.FlatStyle = FlatStyle.Flat;
            appleBtn.BackColor = Color.Red;
            Controls.Add(appleBtn);
        }
        public void addPiece()
        {
            //MessageBox.Show(""+ (SnakePiece.snakePieces.Count - 1));
            int previousX = SnakePiece.snakePieces[SnakePiece.snakePieces.Count - 1].Left - 30;
            int previousY = SnakePiece.snakePieces[SnakePiece.snakePieces.Count - 1].Top;
            var additionalPiece = new SnakePiece(previousX, previousY,false);

            Controls.Add(SnakePiece.snakePieces[SnakePiece.snakePieces.Count - 1]);
            //SnakePiece.snakePieces.Add(newPiece);
            //Controls.Add(SnakePiece.snakePieces[SnakePiece.snakePieces.Count - 1]);
        }
        //*************************
        //LOADING FORM
        //*************************
        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (var piece in SnakePiece.snakePieces)
            {
                Controls.Add(piece);
            }
            createApple();
        }
        //****************************
        // setting the button actions
        //****************************
        private void upBtn_Click(object sender, EventArgs e)
        {
            firstSnake.MoveUp();
            //setting restrictions
            for(int p = 0; p < SnakePiece.snakePieces.Count; p++)
            {
                if (SnakePiece.snakePieces[p].BackColor == Color.BlueViolet)// if the piece is head
                {
                    if (SnakePiece.snakePieces[p].Left >= this.Width-90 || SnakePiece.snakePieces[p].Left <= 0 || SnakePiece.snakePieces[p].Top <= 0 || SnakePiece.snakePieces[p].Top >= this.Height-90)
                    {
                        MessageBox.Show("LOSER!!!");
                        //this.Hide();
                    }
                    for (int j = 0; j < SnakePiece.snakePieces.Count; j++)// eating itself
                    {
                        if (SnakePiece.snakePieces[j].BackColor != SnakePiece.snakePieces[p].BackColor && SnakePiece.snakePieces[j].Left == SnakePiece.snakePieces[p].Left && SnakePiece.snakePieces[j].Top == SnakePiece.snakePieces[p].Top)
                        {
                            MessageBox.Show("LOSER!!!");
                            //this.Hide();
                        }
                    }
                }
            }
            //eating apple
            foreach (Button item in Controls)
            {
                if(item.BackColor == Color.Red)// finding the apple
                {
                    for (int bp = 0; bp < SnakePiece.snakePieces.Count; bp++)//finding the head
                    {
                        if(SnakePiece.snakePieces[bp].BackColor == Color.BlueViolet)//finding the head
                        {
                            if(SnakePiece.snakePieces[bp].Left == item.Left && SnakePiece.snakePieces[bp].Top == item.Top)//checking if apple is eaten
                            {
                                Controls.Remove(item);
                                createApple();
                                addPiece();
                            }
                        }
                    }
                }
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            firstSnake.MoveDown();
            //setting restrictions
            for (int p = 0; p < SnakePiece.snakePieces.Count; p++)
            {
                if (SnakePiece.snakePieces[p].BackColor == Color.BlueViolet)// if the piece is head
                {
                    if (SnakePiece.snakePieces[p].Left >= this.Width - 90 || SnakePiece.snakePieces[p].Left <= 0 || SnakePiece.snakePieces[p].Top <= 0 || SnakePiece.snakePieces[p].Top >= this.Height - 90)
                    {
                        MessageBox.Show("LOSER!!!");
                        //this.Hide();
                    }
                    for (int j = 0; j < SnakePiece.snakePieces.Count; j++)
                    {
                        if (SnakePiece.snakePieces[j].BackColor != SnakePiece.snakePieces[p].BackColor && SnakePiece.snakePieces[j].Left == SnakePiece.snakePieces[p].Left && SnakePiece.snakePieces[j].Top == SnakePiece.snakePieces[p].Top)
                        {
                            MessageBox.Show("LOSER!!!");
                            //this.Hide();
                        }
                    }
                }
            }
            //eating apple
            foreach (Button item in Controls)
            {
                if (item.BackColor == Color.Red)// finding the apple
                {
                    for (int bp = 0; bp < SnakePiece.snakePieces.Count; bp++)//finding the head
                    {
                        if (SnakePiece.snakePieces[bp].BackColor == Color.BlueViolet)//finding the head
                        {
                            if (SnakePiece.snakePieces[bp].Left == item.Left && SnakePiece.snakePieces[bp].Top == item.Top)//checking if apple is eaten
                            {
                                Controls.Remove(item);
                                createApple();
                                addPiece();
                            }
                        }
                    }
                }
            }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            firstSnake.MoveLeft();
            //setting restrictions
            for (int p = 0; p < SnakePiece.snakePieces.Count; p++)
            {
                if (SnakePiece.snakePieces[p].BackColor == Color.BlueViolet)// if the piece is head
                {
                    if (SnakePiece.snakePieces[p].Left >= this.Width - 90 || SnakePiece.snakePieces[p].Left <= 0 || SnakePiece.snakePieces[p].Top <= 0 || SnakePiece.snakePieces[p].Top >= this.Height - 90)
                    {
                        MessageBox.Show("LOSER!!!");
                        //this.Hide();
                    }
                    for (int j = 0; j < SnakePiece.snakePieces.Count; j++)
                    {
                        if (SnakePiece.snakePieces[j].BackColor != SnakePiece.snakePieces[p].BackColor && SnakePiece.snakePieces[j].Left == SnakePiece.snakePieces[p].Left && SnakePiece.snakePieces[j].Top == SnakePiece.snakePieces[p].Top)
                        {
                            MessageBox.Show("LOSER!!!");
                            //this.Hide();
                        }
                    }
                }
            }
            //eating apple
            foreach (Button item in Controls)
            {
                if (item.BackColor == Color.Red)// finding the apple
                {
                    for (int bp = 0; bp < SnakePiece.snakePieces.Count; bp++)//finding the head
                    {
                        if (SnakePiece.snakePieces[bp].BackColor == Color.BlueViolet)//finding the head
                        {
                            if (SnakePiece.snakePieces[bp].Left == item.Left && SnakePiece.snakePieces[bp].Top == item.Top)//checking if apple is eaten
                            {
                                Controls.Remove(item);
                                createApple();
                                addPiece();
                            }
                        }
                    }
                }
            }

        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            firstSnake.MoveRight();
            //setting restrictions
            for (int p = 0; p < SnakePiece.snakePieces.Count; p++)
            {
                if (SnakePiece.snakePieces[p].BackColor == Color.BlueViolet)// if the piece is head
                {
                    if (SnakePiece.snakePieces[p].Left >= this.Width - 90 || SnakePiece.snakePieces[p].Left <= 0 || SnakePiece.snakePieces[p].Top <= 0 || SnakePiece.snakePieces[p].Top >= this.Height - 90)
                    {
                        MessageBox.Show("LOSER!!!");
                        //this.Hide();
                    }
                    for (int j = 0; j < SnakePiece.snakePieces.Count; j++)
                    {
                        if (SnakePiece.snakePieces[j].BackColor != SnakePiece.snakePieces[p].BackColor && SnakePiece.snakePieces[j].Left == SnakePiece.snakePieces[p].Left && SnakePiece.snakePieces[j].Top == SnakePiece.snakePieces[p].Top)
                        {
                            MessageBox.Show("LOSER!!!");
                            //this.Hide();
                        }
                    }
                }
            }
            //eating apple
            foreach (Button item in Controls)
            {
                if (item.BackColor == Color.Red)// finding the apple
                {
                    for (int bp = 0; bp < SnakePiece.snakePieces.Count; bp++)//finding the head
                    {
                        if (SnakePiece.snakePieces[bp].BackColor == Color.BlueViolet)//finding the head
                        {
                            if (SnakePiece.snakePieces[bp].Left == item.Left && SnakePiece.snakePieces[bp].Top == item.Top)//checking if apple is eaten
                            {
                                Controls.Remove(item);
                                createApple();
                                addPiece();
                            }
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
            //CREATING A UTTON WITH SIMILAR PROPERTIES TO THE SNAKEPIECE OBJECT
            var newPiece = new Button { Left = this.LocX, Top = this.LocY, BackColor = Color.Aquamarine, FlatStyle = FlatStyle.Flat, Width = 30, Height = 30 };
            
            if (_isHead == true)
            {
                newPiece.BackColor = Color.BlueViolet;
            }
            //ADDING THE NEW BUTTON TO THE LIST
            snakePieces.Add(newPiece);

        }
    }
    public class XY_Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Apple
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Apple(int _x, int _y)
        {
            this.X = _x;
            this.Y = _y;
        }
    }
}
