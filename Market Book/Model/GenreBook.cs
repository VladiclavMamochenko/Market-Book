namespace Market_Book.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenreBook")]
    public partial class GenreBook
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int GenreId { get; set; }

        public virtual Book Book { get; set; }

        public virtual Book Book1 { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
