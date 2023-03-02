>Find a triplet that sum to a given value

```c#


namespace hello
{
    public class Program
    {
        static void findTriplets (int[] array, int sum) 
        {

            for (int i = 0; i < array.Length; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    for (int k = j + 1; k < array.Length; k++) {
                        if (array[i] + array[j] + array [k] == sum) {
                            Console.WriteLine($"{array[i]}, {array[j]}, {array[k]}");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[] {12, 3, 4, 1, 6, 9};
            int sum = 24; // output: 12, 3, 9

            findTriplets(array, sum);
        }
    }
}


```
