﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyHandler.SaveBlobs();
            EmailHandler.SendEmail();
        }
    }
}
