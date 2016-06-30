using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : Media
    {
        public override int RentalLength
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void PrintMediaDetails()
        {
            throw new NotImplementedException();
        }

        public override DateTime ReturnDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
