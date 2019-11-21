using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTipper
{
    public interface ITipper
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTipper(Direction direction);
        void DrawTipper(Graphics g);
        void SetMainColor(Color color);
    }
}
