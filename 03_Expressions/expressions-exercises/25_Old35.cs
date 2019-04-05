﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return true if the given non-negative number is a multiple of 3 or 5, but not both.
         (Hint: Think "mod".)
         Old35(3) → true
         Old35(10) → true
         Old35(15) → false
         */
        public bool Old35(int n)
        {
            bool isMultipleOf3 = n % 3 == 0;
            bool isMultipleOf5 = n % 5 == 0;

            if (isMultipleOf3 ^ isMultipleOf5)
            {
                return true;
            }
            return false;
        }

    }
}
