using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockPickManagerApp.Models
{
    public class Action
    {
        public int ID { get; set; }
        public string code { get; set; }
        public int qtd { get; set; }
        public double unitPrice { get; set; }
        public DateTime purchaseDate { get; set; }

        public Action(string code, int qtd, double unitPrice, DateTime purchaseDate)
        {
            this.code = code;
            this.qtd = qtd;
            this.unitPrice = unitPrice;
            this.purchaseDate = purchaseDate;
        }
    }
}
