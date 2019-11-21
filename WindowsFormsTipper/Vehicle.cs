using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTipper
{
    public abstract class Vehicle : ITipper
    {
        protected float _startPosX;

        protected float _startPosY;

        protected int _pictureWidth;

        protected int _pictureHeight;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void SetMainColor(Color color)
        {
            MainColor = color;
        }

        public abstract void DrawTipper(Graphics g);

        public abstract void MoveTipper(Direction direction);
    }
}
