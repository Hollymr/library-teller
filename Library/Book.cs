using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : Media
    {
        public override string Title { get; set; }
        public override string Length { get; set; }
        public override int RentalLength { get; set; }
        protected DateTime RentedDate { get; set; }


        public override void PrintMediaDetails()
        {
            throw new NotImplementedException();
        //Print media details() should print:
        //The Type followed by the title
        //The length
        //The rented date
        //The return date() rented date

            
        }

        public override DateTime ReturnDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
