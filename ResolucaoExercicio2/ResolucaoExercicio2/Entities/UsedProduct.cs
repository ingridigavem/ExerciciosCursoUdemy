using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExercicio2.Entities {
    class UsedProduct : Product {
        
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            return base.PriceTag() + $" (used) - Date: {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}
