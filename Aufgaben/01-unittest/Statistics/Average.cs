﻿using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {

            if (numbers.Count == 0)
            {
                throw new ArgumentException();
            }
            
            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            mean = (double)sum / numbers.Count;
            return mean;
        }

        double Median(List<int> numbers)
        {
            throw new NotImplementedException();
        }
    }
}
