using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyIcsZero
{
    public partial class MainForm : Form
    {
        int currentPlayer;
        Label[,] board = new Label[Constants.boardSize, Constants.boardSize];
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            if (FirstGame())
                CreateBoard();
            else
                ResetBoard();
            currentPlayer = Constants.firstPlayer;
        }

        private void CreateBoard()
        {
            for (int i = 0; i < Constants.boardSize; i++)
            {
                for (int j = 0; j < Constants.boardSize; j++)
                {

                    board[i, j] = new Label();

                    this.board[i, j].BackColor = System.Drawing.Color.Aquamarine;
                    this.board[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", (Constants.cellSize - 10) / 2, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.board[i, j].Left = Constants.leftBoardPosition + j * (Constants.cellSize + Constants.cellPadding);
                    this.board[i, j].Top = Constants.topBoardPosition + i * (Constants.cellSize + Constants.cellPadding);
                    this.board[i, j].Size = new System.Drawing.Size(Constants.cellSize, Constants.cellSize);
                    this.board[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    // this.board[i, j].Click += Play;
                    this.board[i, j].MouseEnter += OnMouseEnter;
                    this.board[i, j].MouseLeave += OnMouseLeave;


                    Controls.Add(board[i, j]);

                }
            }


        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Constants.boardColor;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Constants.hoverColor;
        }
        private void ResetBoard()
        {
            for (int i = 0; i < Constants.boardSize; i++)
            {
                for (int j = 0; j < Constants.boardSize; j++)
                {

                    board[i, j].Text = "";

                }
            }
        }

        private bool FirstGame()
        {
            return board[0, 0] == null;
        }

    }
}
