xam
===

Explanation of the Solution
---------------------------

1.  Initially, we have a given array consisting of 7 elements.

2.  In addition to this, we have several variables:

    -   **"size"** = size of the array
    -   **"maxCharactersAllowed"** = the maximum number of characters that can be in one element of the array, in order for this element to belong to the new array that will be created later.
3.  I created the **"howLongMustBeNewArray"** method, with its help and the **"for"** loop, I will search for the length of the new array in which the elements have symbols less than or equal to three.
1.  This method consists of passing through each element of the primary array and if any of the elements have 3 or fewer symbols, then for this, I created a variable **"count"** inside the method, which we will add +1 each time we encounter one of such elements.

2.  We will use the result of this method when creating the new array **"newArray"**.

3.  In order to fill the new array, I created a new method **"FillArray"** and I also created a variable **"j"**, which corresponds to the index of the new array (newArray).

4.  We also go through each element of the primary array and assign the elements with 3 or fewer symbols to the new array using the **"for"** loop and the **"i"** and **"j"** indices already knowing the size of the new array thanks to the **"howLongMustBeNewArray"** method.
P.S.

During the solution of the problem, the variables **"sizeOfNewArray"** and **"NewArray1"** were created, which served as a call to the aforementioned methods.
