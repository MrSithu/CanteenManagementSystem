using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Shared
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }

        public Shop()
        {

        }
        public Shop(int id, string name, string photo)
        {
            this.Id = id;
            this.Name = name;
            this.Photo = photo;
        }
    }
}
