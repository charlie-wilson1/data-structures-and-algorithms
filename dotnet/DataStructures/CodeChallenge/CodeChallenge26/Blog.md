# Insertion Sort - A step by step guide by Jona Brown and Chaz Bofferding

![Whiteboard](./CodeChallenge26Whiteboard.PNG)

## Problem Domain: Given an array of integers, sort each int within the array from smallest to largest.
Here is our pseudo code -
``` cs
InsertionSort(int[] arr)

    // For every variable in 
    For i = 1 to arr.length{ 
        //setting j to 1 behind i.
        int j = i - 1

        int temp = arr[i]

        // While our backwards counting j is not negative in the index and the temp variable is lesser than 
        // the current value of j, keep moving the values forward in the line.
        while j >= 0 and temp < arr[j]
        {
            arr[j + 1] = arr[j]
            j--
        }
        // Finally, set the value of temp to the value of j + 1 and repeat the loop.
    }

``` 
Follow along with the images from top to bottom to understand how the code operates.

## Implementation:
The top number above the array signals the index numbers.  
![Part1img](./Part1img.PNG)![Part1](./Part1.PNG)![Part2](./Part1.5img.PNG) 
## =============================
![Part2](./Part2.PNG) ![Part2img](./Part2img.PNG)
## =============================
![Part3](./Part3.PNG) ![part3img](./Part3img.PNG)
## =============================
![Part4](./Part4.PNG) ![Part4img](./Part4img.PNG)
## =============================
![Part5](./Part5.PNG) ![Part5img](./Part5img.PNG)
## =============================
![Part6](./Part6.PNG) ![Part6img](./Part6img.PNG)
## =============================
![Part7](./Part7.PNG) ![Part7img](./Part7img.PNG)
## =============================
![Part8](./Part8.PNG) ![Part8img](./Part8img.PNG)
## =============================
![Part9](./Part9.PNG) ![Part9img](./Part9img.PNG)
## =============================
![Part10](./Part10.PNG) ![Part10img](./Part10img.PNG)
