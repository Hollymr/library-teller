using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Media
    {
        public virtual string Title { get;  set; }
        public virtual string Length { get;  set; }
        public abstract int RentalLength { get; set; }
        protected DateTime RentedDate { get;  set; }
    
        
        public Media()
        {
            RentedDate = DateTime.Today;// DateTime.Today = just the date 12am
            // DateTime.Now = pulls todays date and time!
        }
        
        public abstract void PrintMediaDetails();

        public abstract DateTime ReturnDueDate();

        public virtual void  SetRentedDate()
        {
            RentedDate = DateTime.Today;
        }
    }
}
