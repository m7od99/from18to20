program that take list of inputs and find the biggest sequence and return the indexes for it (i,j).







input : list of numbres 


output : indexes of biggest sequence . 







0- list of tuples w(i ,j). where i and j >= 0 , i and j < inputs.size .

0- x = inputs[i].




-we will check at first if all inputs are nagtive, if yes we will multiplay them by -1 and look for samllest number and retrun the index of it .


- else ,for each constant i , j value will move when inputs[j] >= 0 will add the number to x  (x = x + inputs[j]) , seq = x . 


-if inputs[j] < 0 , we will start a new sequance for j (i = j) , x = 0 , j++ .


-at the end we will see biggest number in w and return W(i,j) for it .


*****************************************************************************************************************


nlogn answer :





part 1 : split




1-pase case : when size of list = 1 return (0,0)


2-splits the input to tow list left and right . 


3-recursion left and right . 


4-return merge left and right.(x,y) .



part 2 : merge 



(x,y)

x= the start inedx .

y= ending index .


1- when left(x) = right(x):
                   -if left[x] and right[x] >= 0 and left[y] and right [y] >=0 ,
                    y = y+size of left then return (x,y). 

                   -else return (x++,y++).




2- when (right(x) + left.count-1) - left(y) =1: 
                -count the value (x,y) for left and right .

                -if right value is bigger , x= x + left.count , y = y+ left.count .

                -else return left index .


3- when (right(x) + left.count-1) - left(y) > 1 : 
                -make another list that take after left(y) and before right(x).

                -count the value for each list and return the index of bigger value like step 2 . 



***************************************************************************************************






