using System;
using System.Collections.Generic;
using System.Text;

namespace Practice

{
   public class Car
    {
        private string _cartype;

        private int _noofSeats;

        private string _CarName;
         
        public string CarType
        {
            get
            {
                return _cartype;
            }
            set
            {
                _cartype = value;
            }
        }

        public int NoofSeats
        {
            get
            {
                return _noofSeats;
             }
            set
            { 
                _noofSeats = value;
            }
        }

        public string CarName
        {
            get
            {
                return _CarName;

            }
            set
            {
                _CarName = value;
            }
        }

        public string _MobileName;
        public string _MobileColour;
        public int _MobileNo = 9873;
         
        public string MobileName
        {
            get
            {
                return _MobileName;
            }
            set
            {
                _MobileName = value;

            }
        }

        public string MobileColour
        {
            get
            {
                return _MobileColour;

            }
            set
            {
                _MobileColour = value;

            }

        }

    }
}
