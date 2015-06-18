using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace superBits
{
    class Engine
    {
        //
        // Keys
        //
        private Keys[] __upKeys = { Keys.Up, Keys.W, Keys.NumPad8 };
        public Keys[] upKeys { get { return __upKeys; } }
        private Keys[] __downKeys = { Keys.Down, Keys.S, Keys.NumPad5 };
        public Keys[] downKeys { get { return __downKeys; } }
        private Keys[] __leftKeys = { Keys.Left, Keys.A, Keys.NumPad4 };
        public Keys[] leftKeys { get { return __leftKeys; } }
        private Keys[] __rightKeys = { Keys.Right, Keys.D, Keys.NumPad6 };
        public Keys[] rightKeys { get { return __rightKeys; } }
        private Keys[] __closeKeys = { Keys.Escape };
        public Keys[] closeKeys { get { return __closeKeys; } }

        //
        // Character/ Player
        //
        private string __cName = "Piper"; // Character name
        public string name 
        {
            get { return __cName; }
            set { __cName = value; }
        }
        private uint __cHeight = 2; // Character height  
        private uint __cWidth = 2; // Character width  
        private ulong __cPos = 0; // Horizontal character position (walk)
        private const ulong __cPosMin = 0; // Left border
        private const ulong __cPosMax = long.MaxValue; // Right border
        private uint __cAir = 0; // Vertical character position (jump)
        private const uint __cAirMin = 0; // Floor
        private const uint __cAirMax = 6; // Max jump hight

        public void moveUp()
        {
            if (__cAir < __cAirMax)
            {
                ++__cAir;
                Console.WriteLine("up");
                SystemSounds.Asterisk.Play();
            }
        }

        public void moveDown()
        {
            if (__cAir > __cAirMin)
            {
                --__cAir;
                Console.WriteLine("down");
            }
        }

        public void moveLeft()
        {
            if (__cPos > __cPosMin)
            {
                --__cPos;
                Console.WriteLine("left");
            }
        }

        public void moveRight()
        {
            if (__cPos < __cPosMax)
            {
                ++__cPos;
                Console.WriteLine("right");
            }
        }
    }
}
