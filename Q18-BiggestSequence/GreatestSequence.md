n log n answer for greatest subsequnence . 



input : list of numbers 

output : index of greetest sequnence . 



part 1 : splits 



1-base case : if size of input equels 1 return the indexs of it . 

2-Initialize pivot that take midle value of input .

3-Initialize two list :

a-left take every elemnte from start of input to before pivot .

b-right that takes elemnte after pivot to end .

4-divide left and right to bace case , m1 the maxsubsequence for left , m2  the maxsubsequence for right . 

5-combine left , right , pivot , m1 ,m2 .



part 2 : combine :



6-Initialize list of tupls W to save the index and the value .

7-create new list a3 , the start from m1 start index from left to m2 end index from right . 

8-get m3 ,the  max subsequnence for a3 : 

a- create 3 integer x equels m1 start index , y equels m1 end index +1 , value equels m1 value .

b-from y index to end of a3 , if the element is positve will add to value and well increment y and add them to w . 

c-otherwise start new subsequnence by make value equels the elemnte and y , x equels the index of it .

d-the max value in w is m3 . 

9-return the max value from m1, m2, m3 . 




/////////////////////////////////////////////////////////////////////////////////////
*************************************************************************************


2-why this will work ? : 

-at base level we will have one number with his index in list , the left is sloved in m1 so we need to solve the sub list after m1 ,
that will lead us to a3 the sublist include the right with pivot the elemnte we slove a3 iterate to get max subsequance , at the end we will compere the 3 max subsequence and return the biggest from them . 


3-T(n) = 2T(n/2) + O(n) // n log n .
