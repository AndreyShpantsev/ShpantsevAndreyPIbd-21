using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTipper
{
    public class Truck : Vehicle, IComparable<Truck>, IEquatable<Truck>
    {
        protected const int carWidth = 195;

        protected const int carHeight = 60;

        public Truck(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Truck(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
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

            g.FillRectangle(trailer, _startPosX + 230, _startPosY + 55, 70, 20);
            g.DrawRectangle(main, _startPosX + 230, _startPosY + 55, 70, 20);
            g.FillRectangle(wheels, _startPosX + 240, _startPosY + 45, 20, 10);
            g.DrawRectangle(pen, _startPosX + 240, _startPosY + 45, 20, 10);
            g.FillRectangle(wheels, _startPosX + 262, _startPosY + 45, 20, 10);
            g.DrawRectangle(pen, _startPosX + 262, _startPosY + 45, 20, 10);
            g.FillRectangle(wheels, _startPosX + 240, _startPosY + 75, 20, 10);
            g.DrawRectangle(pen, _startPosX + 240, _startPosY + 75, 20, 10);
            g.FillRectangle(wheels, _startPosX + 262, _startPosY + 75, 20, 10);
            g.DrawRectangle(pen, _startPosX + 262, _startPosY + 75, 20, 10);
            g.FillRectangle(wheels, _startPosX + 302, _startPosY + 40, 15, 10);
            g.DrawRectangle(pen, _startPosX + 302, _startPosY + 40, 15, 10);
            g.FillRectangle(wheels, _startPosX + 302, _startPosY + 80, 15, 10);
            g.DrawRectangle(pen, _startPosX + 302, _startPosY + 80, 15, 10);
            g.FillRectangle(trailer, _startPosX + 290, _startPosY + 50, 10, 30);
            g.DrawRectangle(main, _startPosX + 290, _startPosY + 50, 10, 30);
            g.FillRectangle(trailer, _startPosX + 300, _startPosY + 43, 20, 44);
            g.DrawRectangle(pen, _startPosX + 300, _startPosY + 43, 20, 44);
            g.FillRectangle(trailer, _startPosX + 320, _startPosY + 53, 15, 24);
            g.DrawRectangle(pen, _startPosX + 320, _startPosY + 53, 15, 24);


        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(Truck other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(Truck other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Truck carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }


    }
}
