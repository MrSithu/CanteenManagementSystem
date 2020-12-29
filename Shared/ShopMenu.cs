using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Shared
{
    public class ShopMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public ShopMenu()
        {
        }
        public ShopMenu(int Id, string Name, string Photo)
        {
            this.Id = Id;
            this.Name = Name;
            this.Photo = Photo;
        }
    }
}
