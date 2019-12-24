using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsTipper
{
    public class MultiLevelParking
    {
        List<Parking<ITipper>> parkingStages;
        private const int countPlaces = 20;

        private int width;
        private int height;

        public MultiLevelParking(int countStages, int width, int height)
        {
            this.width = width;
            this.height = height;
            parkingStages = new List<Parking<ITipper>>();
            for (int i = 0; i < countStages; i++)
            {
                parkingStages.Add(new Parking<ITipper>(countPlaces, width, height));
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var car = level[i];
                        if (car != null)
                        {
                            if (car.GetType().Name == "Truck")
                            {
                                sw.Write(i + ":Truck:");
                            }
                            if (car.GetType().Name == "Tipper")
                            {
                                sw.Write(i + ":Tipper:");
                            }
                            sw.WriteLine(car);
                        }
                    }
                }
                return true;
            }
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITipper>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                ITipper car = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITipper>(countPlaces, width, height));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "Truck")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        car = new Truck(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "Tipper")
                    {
                        car = new Tipper(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = car;
                }
            }
            return true;
        }
    }
}
