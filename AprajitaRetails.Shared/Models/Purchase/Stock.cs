﻿using AprajitaRetails.Shared.Models.Stores;
using System.ComponentModel.DataAnnotations;

namespace AprajitaRetails.Shared.Models.Purchase.Models
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    //Store Based Class
    public class Stock
    {
        public int StockID { set; get; }
        [Display(Name = "Store")]
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
        [Display(Name = "Product")]
        public int ProductItemId { set; get; }
        public virtual ProductItem ProductItem { get; set; }
        public double Quantity { set; get; }
        [Display(Name = "Sale Qty")]
        public double SaleQty { get; set; }
        [Display(Name = "Purchase Qty")]
        public double PurchaseQty { get; set; }
        public Unit Units { get; set; }
    }
}