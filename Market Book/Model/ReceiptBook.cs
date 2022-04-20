namespace Market_Book.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiptBook")]
    public partial class ReceiptBook
    {
        public int Id { get; set; }

        public int MarketBookId { get; set; }

        public int Quantity { get; set; }

        public int ReceiptId { get; set; }

        public virtual MarketBook MarketBook { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
