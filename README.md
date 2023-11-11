# Codility-Triangle
An array A consisting of N integers is given.</br>
A triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and:</br>
A[P] + A[Q] > A[R],</br>
A[Q] + A[R] > A[P],</br>
A[R] + A[P] > A[Q].</br>
For example, consider array A such that:</br>
A[0] = 10    A[1] = 2    A[2] = 5</br>
A[3] = 1     A[4] = 8    A[5] = 20</br>
Triplet (0, 2, 4) is triangular.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given an array A consisting of N integers,</br> 
returns 1 if there exists a triangular triplet for this array and returns 0 otherwise.

For example, given array A such that:</br>
A[0] = 10    A[1] = 2    A[2] = 5</br>
A[3] = 1     A[4] = 8    A[5] = 20</br>
the function should return 1, as explained above.</br> 
Given array A such that:</br>
A[0] = 10    A[1] = 50    A[2] = 5</br>
A[3] = 1</br>
the function should return 0.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [0..100,000];</br>
each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
