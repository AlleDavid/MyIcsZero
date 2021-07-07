using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIcsZero
{
    static class Constants
    {
        public static int boardSize = 3;

        public static int firstPlayer = 1;
        public static string firstPlayerName = "Mike";
        public static string firstPlayerText = "X";
        public static int secondPlayer = 2;
        public static string secondPlayerName = "Luke";
        public static string secondPlayerText = "0";

        public static Color boardColor = Color.Aquamarine;
        public static Color hoverColor = Color.Yellow;

        public static int cellSize = 80;
        public static int cellPadding = 5;
        public static int leftBoardPosition = 50;
        public static int topBoardPosition = 30;


    }
}