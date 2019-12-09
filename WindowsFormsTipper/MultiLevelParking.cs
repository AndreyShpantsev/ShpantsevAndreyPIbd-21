using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTipper
{
    public class MultiLevelParking
    {
        List<Parking<ITipper>> parkingStages;
        private const int countPlaces = 20;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITipper>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITipper>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        public Parking<ITipper> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

    }
}
