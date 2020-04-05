# Data Structures

This repo will help you implement various operations that can be performed on array

## Getting Started

Just download the code and open it in visual studio 2019 and build

### Prerequisites

Visual Studio 2019
Basic c# skills
Knowledge of basic data strucutre

## Array Sorting

Sorting is nothing but arranging the data in ascending or descending order. The term sorting came into picture, as humans realised the importance of searching quickly.

Sorting arranges data in a sequence which makes searching easier.

The two main criterias to judge which algorithm is better than the other have been:

1. Time taken to sort the given data.
2. Memory Space required to do so.

### Different Sorting Algorithms

* Bubble Sort
* Insertion Sort
* Selection Sort
* Quick Sort
* Merge Sort
* Heap Sort

### Bubble Sort

It is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.

### Implementing Bubble Sort Algorithm

Following are the steps involved in bubble sort(for sorting a given array in ascending order):

* Starting with the first element(index = 0), compare the current element with the next element of the array.
* If the current element is greater than the next element of the array, swap them.
* If the current element is less than the next element, move to the next element. Repeat Step 1.

### Optimized Bubble Sort Algorithm

To optimize our bubble sort algorithm, we can introduce a flag to monitor whether elements are getting swapped inside the inner for loop.

Hence, in the inner for loop, we check whether swapping of elements is taking place or not, everytime.

If for a particular iteration, no swapping took place, it means the array has been sorted and we can jump out of the for loop, instead of executing all the iterations.

### Complexity Analysis of Bubble Sort

In Bubble Sort, n-1 comparisons will be done in the 1st pass, n-2 in 2nd pass, n-3 in 3rd pass and so on. So the total number of comparisons will be,

```
Output:
(n-1) + (n-2) + (n-3) + ..... + 3 + 2 + 1
Sum = n(n-1)/2
i.e O(n2)
```

Hence the time complexity of Bubble Sort is O(n2).

* **Worst and Average Case Time Complexity: O(n*n).** Worst case occurs when array is reverse sorted.

* **Best Case Time Complexity: O(n).** Best case occurs when array is already sorted.

* **Auxiliary Space/ Space Complexity: O(1)** Because only a single additional memory space is required i.e. for temp variable.

* **Boundary Cases: Bubble sort takes minimum time (Order of n) when elements are already sorted.**

* **Sorting In Place: Yes**

* **Stable: Yes**

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Udemy