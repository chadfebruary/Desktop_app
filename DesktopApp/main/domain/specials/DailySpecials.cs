﻿/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: DailySpecials.cs
    Subject: Technical Programming 2
*/
using System;
using System.Runtime.Serialization;

namespace DesktopApp.main.domain.specials
{
    [Serializable]
    class DailySpecials :ISerializable
    {
        private String name, price, DayOfSpecial;

        public string DayOfSpecial1
        {
            get
            {
                return DayOfSpecial;
            }

            set
            {
                DayOfSpecial = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}