﻿
using System;
using System.Collections.Generic;
using System.Linq;

namespace from18to20 {
    class Program {
        static void Main (string[] args) {
            List<int> numbers = new List<int> () { 1, 2, 3, -4, 5, -6, 7};
            Console.WriteLine (BiggestSequence.GetBiggeestSequence (numbers));

            var m = MaxSubSequence.GetMAxSubSeq(numbers , 0 ,numbers.Count -1);
            Console.WriteLine(m);
            
        }

    }
}
