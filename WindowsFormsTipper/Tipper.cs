﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTipper
{
    public class Tipper : Truck, IComparable<Tipper>, IEquatable<Tipper>
    {
        public Color DopColor { private set; get; }

        public bool TipperCase { private set; get; }

        public bool BigWheels { private set; get; }

        public bool CaseIsEmpty { private set; get; }

        public Tipper(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool tipperCase, bool caseIsEmpty, bool bigWheels) : 
            base (maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            TipperCase = tipperCase;
            CaseIsEmpty = caseIsEmpty;
            BigWheels = bigWheels;
        }

        public Tipper(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                TipperCase = Convert.ToBoolean(strs[4]);
                BigWheels = Convert.ToBoolean(strs[5]);
                CaseIsEmpty = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawTipper(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Pen main = new Pen(DopColor);
            Brush trailer = new SolidBrush(MainColor);
            Brush sand = new SolidBrush(Color.LightGoldenrodYellow);
            Brush wheels = new SolidBrush(Color.DarkGray);

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
                g.FillRectangle(wheels, _startPosX + 302, _startPosY + 35, 15, 20);
                g.DrawRectangle(pen, _startPosX + 302, _startPosY + 35, 15, 20);
                g.FillRectangle(wheels, _startPosX + 302, _startPosY + 75, 15, 20);
                g.DrawRectangle(pen, _startPosX + 302, _startPosY + 75, 15, 20);

            }
            base.DrawTipper(g);

            if (TipperCase)
            {
                g.FillRectangle(trailer, _startPosX + 230, _startPosY + 40, 70, 50);
                g.DrawRectangle(main, _startPosX + 230, _startPosY + 40, 70, 50);

                g.DrawLine(main, _startPosX + 230, _startPosY + 40, _startPosX + 240, _startPosY + 50);
                g.DrawLine(main, _startPosX + 230, _startPosY + 90, _startPosX + 240, _startPosY + 80);
                g.DrawLine(main, _startPosX + 290, _startPosY + 50, _startPosX + 300, _startPosY + 40);
                g.DrawLine(main, _startPosX + 290, _startPosY + 80, _startPosX + 300, _startPosY + 90);
                if (CaseIsEmpty)
                {
                    g.FillRectangle(trailer, _startPosX + 240, _startPosY + 50, 50, 30);
                    g.DrawRectangle(main, _startPosX + 240, _startPosY + 50, 50, 30);
                }
                else
                {
                    g.FillRectangle(sand, _startPosX + 240, _startPosY + 50, 50, 30);
                    g.DrawRectangle(main, _startPosX + 240, _startPosY + 50, 50, 30);
                }
            }

            
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + TipperCase + ";" +
           BigWheels + ";" + CaseIsEmpty;
        }

        public int CompareTo(Tipper other)
        {
            var res = (this is Tipper).CompareTo(other is Tipper);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (TipperCase != other.TipperCase)
            {
                return TipperCase.CompareTo(other.TipperCase);
            }
            if (BigWheels != other.BigWheels)
            {
                return BigWheels.CompareTo(other.BigWheels);
            }
            if (CaseIsEmpty != other.CaseIsEmpty)
            {
                return CaseIsEmpty.CompareTo(other.CaseIsEmpty);
            }
            return 0;
        }

        public bool Equals(Tipper other)
        {
            var res = (this as Truck).Equals(other as Truck);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (TipperCase != other.TipperCase)
            {
                return false;
            }
            if (BigWheels != other.BigWheels)
            {
                return false;
            }
            if (CaseIsEmpty != other.CaseIsEmpty)
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
            if (!(obj is Tipper carObj))
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