﻿using System;

namespace DesktopApp.main.factories.address
{
    class AddressFactory
    {
        public static Address getAddress(String streetNumber, String streetName, String suburb, String city, String postCode)
        {
            Address address = new Address();
            address.StreetNumber = streetNumber;
            address.StreetNumber = streetNumber;
            address.Suburb = suburb;
            address.City = city;
            address.PostCode = postCode;
            return address; 
        }
    }
}
