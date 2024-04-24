Introduction

Shortly, this is a work of two students’ collaboration – Yana and Sasha. The main point for creating this repository was testing GitHub as our first platform for IT projects. Below you will find the detailed description of our lab.


Title:

Dynamic Arrays (One-dimensional and Jagged) 

Objective:

To familiarize oneself with methods for processing dynamic arrays, particularly jagged arrays.



Yana (var 9) :

Block 1

Destroy all elements between the first maximum value and the last minimum value; also, remove the first maximum and the last minimum elements themselves; consider that it's unknown which one of them is written in the array first.

Block 2

2a) Read a single natural number n, initially form in memory a jagged array with rows of different lengths, then output the following lists: for each i from 0 to n–1, the sequence number i contains, in ascending order, those and only those numbers from 1 to n that are multiples of the sum of the digits of the number I.

2b) The output should be exactly the same as in the previous point, but there should be significantly fewer different "nested" one-dimensional arrays in memory, because different numbers may have the same sum of digits, in these cases the sequence is the same, and it can be kept in memory only once.

Block 3

Delete all rows containing the minimum elements of the jagged array.

Block 4

Transpose the rectangular matrix X filled with random natural numbers from the interval [a; b]. In the resulting matrix Y, swap the first row with the last, the second with the penultimate, and so on until the center of the matrix. Set to zero those rows of matrix Y where the first zero occurs in the first half of the row, and sort the other rows in decreasing order.



Sasha (var 5):

Block 1

Delete T elements starting from index K (if there are fewer than T elements starting from index K, delete as many as there are; however, if K is negative, do nothing).

Block 2

2a) Read a single natural number n, initially form in memory a jagged array with rows of different lengths, then output the following lists: for each i from 0 to n–1, the sequence number i contains, in ascending order, those and only those numbers from 1 to n that are multiples of the sum of the digits of the number I.

2b) The output should be exactly the same as in the previous point, but there should be significantly fewer different "nested" one-dimensional arrays in memory, because different numbers may have the same sum of digits, in these cases the sequence is the same, and it can be kept in memory only once.

Block 3

Delete all even rows (i.e., rows with even indices).

Block 4

Here's a suggestion: In matrix C, the number of columns in each row is a random natural number from the interval [a; b]. Rewrite all elements from matrix C into a one-dimensional array F, sort it in ascending order, then rewrite its elements into a square matrix Q row by row; if the total number of elements in all rows is not a perfect square (its square root is not an integer), round down (for example, if the total number of elements across all rows is from 9 to 15, form a 33 array and rewrite only the first nine elements; if the total number is from 16 to 24, form a 44 array and rewrite only the first sixteen elements, and so on).

