﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommitsOfFury
{
    public class Class1 : IAmAClass
    {
        public string TheThingToSay()
        {
            var james = "James";
            var theName = $"{james}";

            return $"{theName}";
        }
    }
}
