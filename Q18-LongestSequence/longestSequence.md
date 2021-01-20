program that take list of inputs and find the biggest sequence and return the indexes for it (i,j).







input : list of numbres 


output : indexes of biggest sequence . 







0- make list of tuples w(i ,j ,seq). where i and j >= 0 , i and j < inputs.size .

0- x = inputs[i].




-we will check at first if all inputs are nagtive, if yes we will multiplay them by -1 and look for samllest number and retrun the index of it .


- else ,for each constant i , j value will move when inputs[j] >= 0 will add the number to x  (x = x + inputs[j]) , seq = x . 


-if inputs[j] < 0 , we will start a new sequance for j (i = j+1) , x = inputs[j+1] , j++ .


-at the end we will see biggest number in w(seq) and return W(i,j) for it .