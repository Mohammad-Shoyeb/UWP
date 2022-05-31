using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Models
{
    public class DeviceCollection
    {
        ObservableCollection<Device> devices;
        public DeviceCollection()
        {
            this.devices = new ObservableCollection<Device>()
            {
                new Device{ Id=1, Name="Huawei P10", Price=30000.00M, ReleaseDate=new DateTime(2017, 10, 12), OS="Android 7",Display="5.1 Inches",Camera="12 Mp Back,5 Mp front",Ram="2GB",Storage="32 GB",Battery="3200 mAh" ,Image="Assets/Huawei P10.jpg"},
                new Device{ Id=2, Name="nokia-g300-5g-r1", Price=65000.00M, ReleaseDate=new DateTime(2021, 10, 19), OS="Android 11",Display="6.52 Inches",Camera="16 Mp Back,5 Mp front",Ram="4GB",Storage="64 GB",Battery="4470 mAh" ,Image="Assets/nokia-g300-5g-r1.jpg"},
                new Device{ Id=3, Name="Philips-PH2", Price=60000.00M, ReleaseDate=new DateTime(2021, 12, 13), OS="Android 10",Display="6.21 Inches",Camera="13 Mp Back,2 Mp front",Ram="4GB",Storage="128 GB",Battery="3900 mAh" ,Image="Assets/Philips-PH2.jpg"},
                new Device{ Id=4, Name="Samsung Galaxy M30", Price=30000.00M, ReleaseDate=new DateTime(2019, 02, 27), OS="Android 8.1",Display="6.4 Inches",Camera="13 Mp Back,5 Mp front",Ram="3GB",Storage="32 GB",Battery="5000 mAh" ,Image="Assets/Samsung Galaxy M30.jpg"},
                new Device{ Id=5, Name="Samsung Galaxy W60", Price=40000.00M, ReleaseDate=new DateTime(2020, 10, 12), OS="Android 10",Display="6.5 Inches",Camera="32 Mp Back,5 Mp front",Ram="6GB",Storage="64 GB",Battery="4000 mAh" ,Image="Assets/Samsung Galaxy W60.jpg"},
                new Device{ Id=6, Name="vivo T3s", Price=65000.00M, ReleaseDate=new DateTime(2020, 09, 12), OS="Android 11",Display="6.51 Inches",Camera="13 Mp Back,5 Mp front",Ram="2GB",Storage="32 GB",Battery="5000 mAh" ,Image="Assets/vivo T3s.jpg"},
                new Device{ Id=7, Name="vivo Y55s", Price=40000.00M, ReleaseDate=new DateTime(2021, 11, 12), OS="Android 11",Display="6.51 Inches",Camera="16 Mp Back,5 Mp front",Ram="4GB",Storage="32 GB",Battery="5000 mAh" ,Image="Assets/vivo Y55s.jpg"},
                new Device{ Id=8, Name="vivo Y70s", Price=45000.00M, ReleaseDate=new DateTime(2021, 10, 12), OS="Android 10",Display="6.44 Inches",Camera="32 Mp Back,5 Mp front",Ram="8GB",Storage="32 GB",Battery="4100 mAh" ,Image="Assets/vivo Y70s.jpg"},
                new Device{ Id=9, Name="Xiaomi-12X", Price=65000.00M, ReleaseDate=new DateTime(2020, 12, 31), OS="Android 11",Display="6.28 Inches",Camera="50 Mp Back,5 Mp front",Ram="2GB",Storage="32 GB",Battery="4500 mAh" ,Image="Assets/Xiaomi-12X.jpg"}
            };
        }
        public ObservableCollection<Device> Get()
        {
            return this.devices;
        }
        public Device Get(int id)
        {
            return this.devices.First(x => x.Id == id);
        }
    }
}
