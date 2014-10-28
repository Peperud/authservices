﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentor.AuthServices.Internal
{
    static class DateTimeExtensions
    {
        public static string ToSaml2DateTimeString(this DateTime dateTime)
        {
            return dateTime.ToUniversalTime().ToString("s", CultureInfo.InvariantCulture) + "Z";
        }
    }
}
