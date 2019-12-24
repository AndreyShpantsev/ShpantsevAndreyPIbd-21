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
                        var vehicle = level[i];
                        if (vehicle != null)
                        {
                            if (vehicle.GetType().Name == "Truck")
                            {
                                sw.Write(i + ":Truck:");
                            }
                            if (vehicle.GetType().Name == "Tipper")
                            {
                                sw.Write(i + ":Tipper:");
                            }
                            sw.WriteLine(vehicle);
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
                throw new FileNotFoundException();
            }
            string buff = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buff = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buff.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITipper>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITipper vehicle = null;
                while ((buff = sr.ReadLine()) != null)
                {
                    if (buff == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Parking<ITipper>(countPlaces, width, height));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buff))
                    {
                        continue;
                    }
                    if (buff.Split(':')[1] == "Truck")
                    {
                        vehicle = new Truck(buff.Split(':')[2]);
                    }
                    else if (buff.Split(':')[1] == "Tipper")
                    {
                        vehicle = new Tipper(buff.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buff.Split(':')[0])] = vehicle;
                }
            }
            return true;
        }
    }
}
