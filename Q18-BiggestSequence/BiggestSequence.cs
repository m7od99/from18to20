using System;
using System.Collections.Generic;
using System.Linq;
namespace from18to20 {
    public class BiggestSequence {

        public static string GetBiggeestSequence (List<int> numbers) {
            //list of tuples w(i ,j). where i and j >= 0 , i and j < inputs.size .
            var w = new Dictionary < (int i, int j),
                int > ();

            //-if all numbers are nagtive, look for biggest number and retrun the index of it .
            if (IsAllNagtives (numbers) == true) {
                return GetNageivesIndex (numbers);
            }
            //- else ,for each constant i , j value will move when inputs[j] >= 0 will add the number to x .
            var x = 0;
            var i = 0;
            var j = 0;
            while (numbers.Count > i) {
                while (numbers.Count > j)
                {
                    if (numbers[j] >=0)
                    {
                        x = x + numbers[j];
                        w.Add((i,j), x);
                        j++;
                    }
                    //-if inputs[j] < 0 , we will start a new sequance for j (i = j) , x = 0 , j++ .
                    else {
                        j++;
                        i=j;
                        x =0;
                        continue;
                    }
                }
                x=0;
                i++;
            }
            // -at the end we will see biggest number in w and return W(i,j) for it .
            var max = w.Values.Max ();
            var index = w.Where (o => o.Value == max).Select (o => o.Key).FirstOrDefault();


            return $"{index}, {max}";
        }
        public static bool IsAllNagtives (List<int> input) {
            foreach (var num in input) {
                if (num >= 0) {
                    return false;
                }
            }
            return true;
        }

        public static string GetNageivesIndex (List<int> input) {
            for (int i = 0; i < input.Count; i++) {
                input[i] = input[i] * -1;
            }
            var x = input.Min ();
            var dd = 0;
            for (int i = 0; i < input.Count; i++) {
                if (x == input[i]) {
                    dd = i;
                }
            }
            return dd.ToString ();
        }

    }
}