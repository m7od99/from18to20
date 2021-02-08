using System;
using System.Collections.Generic;
using System.Linq;

namespace from18to20
{
    public class MaxSubSequence : BiggestSequence
    {
        public MaxSubSequence(int start, int end, int value)
        {
            this.Start = start;
            this.End = end;
            this.Value = value;

        }


        public int Start { get; set; }
        public int End { get; set; }
        public int Value { get; set; }


        public MaxSubSequence()
        {

        }

        public static (int, int, int) GetMAxSubSeq(List<int> numbers, int start, int end)
        {
            // base case 
            if (start == end)
            {
                return (start, end, numbers[start]);
            }
            int mid = (start + end) / 2;

            //split to two part 
            var left = GetMAxSubSeq(numbers, start, mid);
            var right = GetMAxSubSeq(numbers, mid + 1, end);

            //m3 : 3rd answer ,with midle . 
            var m3 = WithMid(numbers, start, end, mid);


            //Combine 3 answer .
            if (left.Item3 > right.Item3 && left.Item3 > m3.Item3)
            {
                return left;
            }
            else if (left.Item3 < right.Item3 && right.Item3 > m3.Item3)
            {
                return right;
            }
            return m3;
        }
        public static (int, int, int) WithMid(List<int> numbers, int start, int end, int mid)
        {
            //  the left with mid value >.
            var temp = 0;
            var leftsum = int.MinValue;
            var lStart = start;
            var s =start;
            var lEnd =0;

            for (var i = start; i <= mid; i++)
            {
                temp+=numbers[i];
                if (leftsum < temp)
                {
                    leftsum = temp;
                    lStart = s;
                    lEnd =i;
                }
                if (numbers[i] <0)
                {
                    temp =0;
                    s = i+1;
                }
            }

            // the right with mid value .
            var rightsum =int.MinValue;
            var rStart = mid+1;
            var s2= mid+1;
            var rEnd = 0;

            for (var i = mid+1; i <= end; i++)
            {
                
                temp+=numbers[i];
                if (rightsum < temp)
                {
                    rightsum = temp;
                    rStart = s2;
                    rEnd =i;
                }
                if (numbers[i] <0)
                {
                    temp =0;
                    s2 = i+1;
                }
            }

            // return the bigger .
            if (leftsum > rightsum)
            {
               return (lStart , lEnd ,leftsum);
            } 
            return (rStart , rEnd , rightsum);
        }

        public static (int, int, int) MaxSumON(List<int> numbers)
        {
            var start = 0;
            var end = 0;
            var s2 = 0;
            var tempMax = 0;
            var maxValueLeft = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                tempMax = tempMax + numbers[i];
                if (tempMax > maxValueLeft)
                {
                    maxValueLeft = tempMax;
                    start = s2;
                    end = i;
                }
                if (numbers[i] < 0)
                {
                    s2 = i + 1;
                    tempMax = 0;
                }
            }
            return (start, end, maxValueLeft);
        }

    }
}
