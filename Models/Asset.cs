﻿using System;
using System.Text.Json.Serialization;

namespace Invest_Application
{
    public abstract class Asset
    {
        public string Name { get; }
        public int Quantity { get; }
        public decimal PurchasePrice { get; }
        public DateTime PurchaseDate { get; }
        public string Id { get; set; }

        [JsonConstructor]
        protected Asset(
            string name,
            int quantity,
            decimal purchasePrice,
            DateTime purchaseDate,
            string? id = null)
        {
            Name = name;
            Quantity = quantity;
            PurchasePrice = purchasePrice;
            PurchaseDate = purchaseDate;
            Id = id ?? DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }

        public abstract decimal CurrentPrice();

        public virtual decimal TotalPurchasePrice()
            => PurchasePrice * Quantity;

        public virtual decimal CalculateROI()
            => (CurrentPrice() - TotalPurchasePrice()) / TotalPurchasePrice();
    }
}
