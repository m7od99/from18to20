n log n answer for greetest sequnence . 



input : list of numbers 


output : index of greetest sequnence . 



part 1 : splits 



base case : if input == 1 return (0,0)



0- Initialize pivot that take midle value of input .


0- Initialize two list :

        -left take every elemnte from start of input to before pivot .

        -right that takes elemnte after pivot to end .


-divide left and right to bace case . 


-merge left , right , pivot .





part 2 : merge :




0- Initialize 2 counter x , y set it at 0 . 


0-Initialize list of tupls W to save the index and the value .



step 1: 

    -if left[y] and pivot are positve increase counter y . save the sum in W(x,y).

    -if left[y] is negative and pivot is positve incresase x and y . else return x,y . save the sum in W(x,y).



step 2: 

    -if right have elementes for each elemente in right : 

        1-if the elemente is positve incresase y and seve the sum in W(x,y).

        2-if the elemente is negative incresase x and y and seve the sum in W(x,y).


step 3 : 

    - return index of biggest value in w .