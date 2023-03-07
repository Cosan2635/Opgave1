using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string LicensePlate { get; set; }

        public void ValidateId()
        {
            if (Id == 0)
            {
                throw new ArgumentNullException("Id is 1 letter");
            }

        }
        public void ValidateModel()
        {
            if (Model == null)
            {
                throw new ArgumentNullException();
            }
            if (Model.Length <= 4)
            {
                throw new ArgumentOutOfRangeException(" Længden er minimum 4");
            }
        }
        public void ValidatePrice()
        {
            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("Prisen Skal være Positiv");
            }
        }
        public void ValidateLicensePlate()
        {
            if (LicensePlate == null)
            {
                throw new ArgumentNullException();
            }
            if (LicensePlate.Length < 1 && LicensePlate.Length > 8)
            {
                throw new ArgumentOutOfRangeException("Talet skal være mellem 2 og 7");
            }

        }
        public void Validate()
        {
            ValidateId();
            ValidateModel();
            ValidatePrice();
            ValidateLicensePlate();


        }
    }
}