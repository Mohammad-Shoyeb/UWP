using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Decimal Price { get; set; }
        public string OS { get; set; }
        public string Image { get; set; }
        public string Display { get; set; }
        public string Camera { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string Battery { get; set; }
        public string ReleasedOn { get => this.ReleaseDate.ToString("MMM yyyy"); }

    }
}
