using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTipper
{
    public class Tipper
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int carWidth = 195;
        private const int carHeight = 60;
        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool TipperCase { private set; get; }

        public bool CaseIsEmpty { private set; get; }

        public bool BigWheels { private set; get; }



        public Tipper(int maxSpeed, float weight, Color mainColor, Color dopColor, bool tipperCase, bool caseIsEmpty, bool bigWheels)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            TipperCase = tipperCase;
            CaseIsEmpty = caseIsEmpty;
            BigWheels = bigWheels;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTipper(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - 2.1 * carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > -1.1 * carWidth)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > -0.7 * carHeight)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - 1.5 * carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Pen main = new Pen(DopColor);
            Pen lines = new Pen(Color.LightGoldenrodYellow);
            Brush trailer = new SolidBrush(MainColor);
            Brush sand = new SolidBrush(Color.LightGoldenrodYellow);
            Brush wheels = new SolidBrush(Color.DarkGray);
            g.FillRectangle(trailer, _startPosX + 220, _startPosY + 55, 150, 20);
            g.DrawRectangle(main, _startPosX + 220, _startPosY + 55, 150, 20);

            if (BigWheels)
            {
                g.FillRectangle(wheels, _startPosX + 240, _startPosY + 35, 15, 20);
                g.DrawRectangle(pen, _startPosX + 240, _startPosY + 35, 15, 20);
                g.FillRectangle(wheels, _startPosX + 258, _startPosY + 35, 15, 20);
                g.DrawRectangle(pen, _startPosX + 258, _startPosY + 35, 15, 20);
                g.FillRectangle(wheels, _startPosX + 240, _startPosY + 75, 15, 20);
                g.DrawRectangle(pen, _startPosX + 240, _startPosY + 75, 15, 20);
                g.FillRectangle(wheels, _startPosX + 258, _startPosY + 75, 15, 20);
                g.DrawRectangle(pen, _startPosX + 258, _startPosY + 75, 15, 20);
                g.FillRectangle(wheels, _startPosX + 382, _startPosY + 35, 15, 20);
                g.DrawRectangle(pen, _startPosX + 382, _startPosY + 35, 15, 20);
                g.FillRectangle(wheels, _startPosX + 382, _startPosY + 75, 15, 20);
                g.DrawRectangle(pen, _startPosX + 382, _startPosY + 75, 15, 20);

            }
            else
            {
                g.FillRectangle(wheels, _startPosX + 240, _startPosY + 45, 20, 10);
                g.DrawRectangle(pen, _startPosX + 240, _startPosY + 45, 20, 10);
                g.FillRectangle(wheels, _startPosX + 262, _startPosY + 45, 20, 10);
                g.DrawRectangle(pen, _startPosX + 262, _startPosY + 45, 20, 10);
                g.FillRectangle(wheels, _startPosX + 240, _startPosY + 75, 20, 10);
                g.DrawRectangle(pen, _startPosX + 240, _startPosY + 75, 20, 10);
                g.FillRectangle(wheels, _startPosX + 262, _startPosY + 75, 20, 10);
                g.DrawRectangle(pen, _startPosX + 262, _startPosY + 75, 20, 10);
                g.FillRectangle(wheels, _startPosX + 382, _startPosY + 40, 15, 10);
                g.DrawRectangle(pen, _startPosX + 382, _startPosY + 40, 15, 10);
                g.FillRectangle(wheels, _startPosX + 382, _startPosY + 80, 15, 10);
                g.DrawRectangle(pen, _startPosX + 382, _startPosY + 80, 15, 10);
            }
            if (TipperCase)
            {
                g.FillRectangle(trailer, _startPosX + 220, _startPosY + 40, 150, 50);
                g.DrawRectangle(main, _startPosX + 220, _startPosY + 40, 150, 50);
                
                g.DrawLine(main, _startPosX + 220, _startPosY + 40, _startPosX + 240, _startPosY + 50);
                g.DrawLine(main, _startPosX + 220, _startPosY + 90, _startPosX + 240, _startPosY + 80);
                g.DrawLine(main, _startPosX + 350, _startPosY + 50, _startPosX + 370, _startPosY + 40);
                g.DrawLine(main, _startPosX + 350, _startPosY + 80, _startPosX + 370, _startPosY + 90);
                if (CaseIsEmpty)
                {
                    g.FillRectangle(trailer, _startPosX + 240, _startPosY + 50, 110, 30);
                    g.DrawRectangle(main, _startPosX + 240, _startPosY + 50, 110, 30);
                }
                else
                {
                    g.FillRectangle(sand, _startPosX + 240, _startPosY + 50, 110, 30);
                    g.DrawRectangle(main, _startPosX + 240, _startPosY + 50, 110, 30);
                }
            }
            g.FillRectangle(trailer, _startPosX + 370, _startPosY + 50, 10, 30);
            g.DrawRectangle(main, _startPosX + 370, _startPosY + 50, 10, 30);
            g.FillRectangle(trailer, _startPosX + 380, _startPosY + 43, 20, 44);
            g.DrawRectangle(pen, _startPosX + 380, _startPosY + 43, 20, 44);
            g.FillRectangle(trailer, _startPosX + 400, _startPosY + 53, 15, 24);
            g.DrawRectangle(pen, _startPosX + 400, _startPosY + 53, 15, 24);
        }
    }
}

