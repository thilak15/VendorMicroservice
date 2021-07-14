using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorMicroservice.Models;

namespace VendorMicroservice.Helper
{
    public class Data
    {
        public static List<Vendor> vendors = new List<Vendor>
        {
            new Vendor{VendorId = 111,VendorName="Amit",DeliveryCharge=2150,Rating=4,ExpectedDateOfDelivery=Convert.ToDateTime("2021-5-2")},
            new Vendor{VendorId = 112,VendorName="Aman",DeliveryCharge=2650,Rating=1,ExpectedDateOfDelivery=Convert.ToDateTime("2021-03-12")},
            new Vendor{VendorId = 113,VendorName="Vikas",DeliveryCharge=2950,Rating=3,ExpectedDateOfDelivery=Convert.ToDateTime("2021-09-22")},
            new Vendor{VendorId = 114,VendorName="Manoj",DeliveryCharge=1120,Rating=5,ExpectedDateOfDelivery=Convert.ToDateTime("2021-1-23")},
            new Vendor{VendorId = 115,VendorName="Sahil",DeliveryCharge=1990,Rating=2,ExpectedDateOfDelivery=Convert.ToDateTime("2021-8-3")}
        };

        public static List<VendorStock> stocks = new List<VendorStock>
        {
            new VendorStock{ProductId = 1,VendorId = 111,StockInHand=0,ExpectedStockReplenishmentDate=Convert.ToDateTime("2021-11-22")},
            new VendorStock{ProductId = 2,VendorId = 111,StockInHand=150,ExpectedStockReplenishmentDate=Convert.ToDateTime("2021-01-01")},
            new VendorStock{ProductId = 1,VendorId = 112,StockInHand=76,ExpectedStockReplenishmentDate=Convert.ToDateTime("2021-01-14")},
            new VendorStock{ProductId = 2,VendorId = 112,StockInHand=0,ExpectedStockReplenishmentDate=Convert.ToDateTime("2021-12-08")},
            new VendorStock{ProductId = 3,VendorId = 113,StockInHand=0,ExpectedStockReplenishmentDate=Convert.ToDateTime("2021-12-12")},
            new VendorStock{ProductId = 1,VendorId = 113,StockInHand=202,ExpectedStockReplenishmentDate=Convert.ToDateTime("2021-11-25")},
            new VendorStock{ProductId = 3,VendorId = 114,StockInHand=5,ExpectedStockReplenishmentDate=Convert.ToDateTime("2022-11-27")},
            new VendorStock{ProductId = 4,VendorId = 114,StockInHand=85,ExpectedStockReplenishmentDate=Convert.ToDateTime("2021-11-30")},
            new VendorStock{ProductId = 2,VendorId = 115,StockInHand=185,ExpectedStockReplenishmentDate=Convert.ToDateTime("2020-12-03")},
            new VendorStock{ProductId = 5,VendorId = 115,StockInHand=0,ExpectedStockReplenishmentDate=Convert.ToDateTime("2020-12-08")}

          };
    }
}
