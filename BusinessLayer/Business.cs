using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    
    public class Business
    {
        private DataLayer.DataLayer dataLayer;
        public Business() {
            dataLayer = new DataLayer.DataLayer();
        }

        public void CreateBook(string title, string publishedYear, int idAuthor, string genre, int avalableAmount)
        {
            if (title != "" && publishedYear != "" && idAuthor > -1 && genre != "" && avalableAmount > -1)
            {
                Console.WriteLine("Create");
            }
        }

       
    }

}
