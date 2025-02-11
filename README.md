<h1>Bike Prices</h1>

<h2>Description</h2>
This program demonstrates the use of variables, boolean functions, and conditional statements to showcase attributes of bikes.
<br />


<h2>Used to create:</h2>

- <b>Visual Studio 2022</b> 


<h2>Screenshot:</h2>
<img src="https://github.com/JrewSimpson/Bike-Prices/blob/08f118876401aa3db27946238f90dbfeec953561/Bike%20Example.JPG" height="80%" width="80%" alt="]"/>

<h2>Code:</h2>

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Bike
    {
    public class Bike
    {
        public const int zero = 0;
        private string _bikeName;
        private int _bikeId;
        private double _bikePrice;
        private string _bikeRenter;
        private string _bikeType;
        private bool _isElectric;
        //#1 - Put needed backing fields here. Remember: Some properties may be
        // auto-implemenetd so only create backing fields for ones needed



        public string BikeName
        {
            get { return _bikeName; }
            set { _bikeName = value; }
        }
        public string BikeRenter
        {
            get { return _bikeRenter;  }
            set { _bikeRenter = value; }
        }
        public string BikeType
        {
            get { return _bikeType; }
            set { _bikeType = value; }
        }
        public int BikeID
        {
            get { return _bikeId; }
            set
            {
                if (value >= 00001 && value <= 99999) _bikeId = value;
                else _bikeId = 00000;
            }


        }
        public double BikePrice
        {
            get { return _bikePrice; }
            set
            {
                if (value >= zero) _bikePrice = value;
                else _bikePrice = zero;
            }


        }

        public Bike(string bikeName, int bikeID, double bikePrice, string bikeRenter, string bikeType)
        {
            // #7 - Put your code here for constructor. Be sure your parameters get validated through properties
            BikeName = bikeName;
            BikeID = bikeID;
            BikePrice = bikePrice;
            BikeRenter = bikeRenter;
            BikeType = bikeType;

            IsElectric();
            
        }
        private bool isElectric;

        public void IsNotElectricBike()
        {   // #8 - Put your code here to determine if the bike is not electric
            _isElectric = false;
        }
        public void IsElectricBike()
        {   // #9 Put your code here to determine if the bike is electric
            _isElectric = true;
        }
        public bool IsElectric()
        {
            // #10 - Put your code here to determine if the bike is electric or not
            return _isElectric;
        }
        public override string ToString()
        {
            return $"Bike Name: {BikeName.ToString()} {Environment.NewLine}" +
                   $"Bike ID: {BikeID.ToString()} {Environment.NewLine}" +
                   $"Bike Price: {BikePrice.ToString("C")} {Environment.NewLine}" +
                   $"Bike Renter: {BikeRenter.ToString()} {Environment.NewLine}" +
                   $"Bike Type: {BikeType.ToString()} {Environment.NewLine}" +
                   $"Electric Bike?: {_isElectric.ToString()} {Environment.NewLine}";
        }
    }
    }
