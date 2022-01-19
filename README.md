# MaxMin

You will be given a list of integers, **arr**, and a single integer **k**. You must create an array of length  from elements of  such that its unfairness is minimized. Call that array . Unfairness of an array is calculated as:

**max(arr1) - min(arr1)**

Where:
- max denotes the largest integer in **arr1**
- min denotes the smallest integer in **arr1**

## Example
```
arr = [1, 4, 7, 2]
```

Pick any two elements, say **arr1 = [4, 7]**.

**unfairness = max(4, 7) - min(4, 7) = 7 - 4 = 3;**

Testing for all pairs, the solution **[1, 2]** provides the minimum unfairness.

**Note:**  Integers in **arr** may not be unique.

## Function Description

Complete the maxMin function.
maxMin has the following parameter(s):

* int k: the number of elements to select
* int arr[n]:: an array of integers

## Returns
* int: the minimum possible unfairness

## Input Format

* The first line contains an integer k, the number of elements to select .
* The next  line contains the array **arr** .

## Constraints

```
2 <= n <= 10^5
2 <= k <= n
0 <= arr[i] <= 10^9
```

## Sample Input 0

```
3
[10,100,300,200,1000,20,30]
```

## Sample Output 0

```
20
```

Explanation 0

Here **k=3**; selecting the **3** integers ,**10,20,30** unfairness equals

```
max(10,20,30) - min(10,20,30) = 30 - 10 = 20
```

## Sample Input 1

```
4
[1,2,3,4,10,20,30,40,100,200]
```

## Sample Output 1

```
3
```

## Explanation 1
Here **k = 4**; selecting the **4** integers **1,2,3,4**, unfairness equals

```
max(1,2,3,4) - min(1,2,3,4) = 4 - 1 = 3
```

## Sample Input 2

```
2
[1,2,1,2,1]
```

## Sample Output 2
```
0
```
## Explanation 2

Here **k=2**. **arr1 = [2,2]**  or **arr1 = [1,1]** give the minimum unfairness of **0**.

