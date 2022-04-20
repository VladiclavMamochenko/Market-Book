namespace Market_Book.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketBook")]
    public partial class MarketBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarketBook()
        {
            ReceiptBook = new HashSet<ReceiptBook>();
        }

        public int Id { get; set; }

        public int BookId { get; set; }

        public int MarketId { get; set; }

        public int Quantity { get; set; }

        public virtual Book Book { get; set; }

        public virtual Market Market { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptBook> ReceiptBook { get; set; }
    }
}
