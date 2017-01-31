using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesPerson
{
    class SalesPerson
    {
        #region FIELDS

        private string lastName;
        private string firstName;



        #endregion

        #region PROPERTIES
        public string Lasyname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public SalesPerson()
        {

        }
        #endregion

        #region METHODS

        #endregion
    }
}
