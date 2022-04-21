using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Book.Model
{
    partial class Book
    {
        public string StringGenres
        {
            get
            {
                string result = "";
                foreach (var item in GenreBook)
                {
                    result += item.Genre.Genre1 + ", ";
                }
                result = result.Remove(result.Length - 2);
                return result;
            }
        }
    }
}
