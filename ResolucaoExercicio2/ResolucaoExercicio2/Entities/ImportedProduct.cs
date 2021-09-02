using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExercicio2.Entities {
    class ImportedProduct : Product {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
            TotalPrice();
        }

        public double TotalPrice() {
            return Price += CustomsFee;
        }

        public override string PriceTag() {
            return base.PriceTag() + $"(Customs fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

    }
}
