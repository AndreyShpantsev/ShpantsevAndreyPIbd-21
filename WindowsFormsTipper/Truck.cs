using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTipper
{
    public class Truck : Vehicle
    {
        protected const int carWidth = 195;

        protected const int carHeight = 60;

        public Truck(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public override void MoveTipper(Direction direction)
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
                    if (_startPosX - step > -1.15 * carWidth)
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

        public override void DrawTipper(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Pen main = new Pen(Color.Orange);
            Pen lines = new Pen(Color.LightGoldenrodYellow);
            Brush trailer = new SolidBrush(MainColor);
            Brush sand = new SolidBrush(Color.LightGoldenrodYellow);
            Brush wheels = new SolidBrush(Color.DarkGray);

            g.FillRectangle(trailer, _startPosX + 220, _startPosY + 55, 150, 20);
            g.DrawRectangle(main, _startPosX + 220, _startPosY + 55, 150, 20);
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
            g.FillRectangle(trailer, _startPosX + 370, _startPosY + 50, 10, 30);
            g.DrawRectangle(main, _startPosX + 370, _startPosY + 50, 10, 30);
            g.FillRectangle(trailer, _startPosX + 380, _startPosY + 43, 20, 44);
            g.DrawRectangle(pen, _startPosX + 380, _startPosY + 43, 20, 44);
            g.FillRectangle(trailer, _startPosX + 400, _startPosY + 53, 15, 24);
            g.DrawRectangle(pen, _startPosX + 400, _startPosY + 53, 15, 24);


        }


        }
    }
