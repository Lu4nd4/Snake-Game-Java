using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luanda_Nuredini_SnakeGame
{
    public static class BoardSetting
    {
        private static int _width = 16;
        private static int _height = 16;
        private static string _directions = "left";

        public static int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public static int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public static string directions
        {
            get { return _directions; }
            set { _directions = value; }
        }
    }
}
