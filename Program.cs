// See https://aka.ms/new-console-template for more information

/*using AlgoReview.Search;
using AlgoReview.Sort;

Random random = new Random();
int[] array = Enumerable.Range(0, 10).Select(_ => random.Next(0, 100)).ToArray();
int target = random.Next(0, 100); 



Console.WriteLine($"Linear Searching for {target} in [{string.Join(", ", array)}]");
int index = LinearSearch.Search(array, target);
Console.WriteLine($"Found {target} at index {index}");

Console.WriteLine($"Binary Searching for {target} in [{string.Join(", ", array)}]");
int index2 = BinarySearch.Search(array, target);
Console.WriteLine($"Found {target} at index {index}");
     


/*array = Enumerable.Range(0, 10).Select(_ => random.Next(0, 100)).ToArray();
SelectionSort.Sort(array);
Console.WriteLine($"Selection Sorted :: [{string.Join(", ", array)}]");

array = Enumerable.Range(0, 10).Select(_ => random.Next(0, 100)).ToArray();
BubbleSort.Sort(array);
Console.WriteLine($"Bubble Sorted :: [{string.Join(", ", array)}]");

array = Enumerable.Range(0, 10).Select(_ => random.Next(0, 100)).ToArray();
MergeSort.Sort(array);
Console.WriteLine($"Merge Sorted :: [{string.Join(", ", array)}]");

array = Enumerable.Range(0, 10).Select(_ => random.Next(0, 100)).ToArray();
QuickSort.Sort(array);
Console.WriteLine($"Quick Sorted :: [{string.Join(", ", array)}]");*/


// LinkedList
/*Console.WriteLine("Hello, World!");
AlgoReview.List.LinkedList<int> list = new AlgoReview.List.LinkedList<int>();
list.Add(5);
list.Add(10);
list.Add(15);
list.Add(20);
list.Add(25);

Console.WriteLine($"List :: {list}");
var (previous, current) = list.FindFirst(15);
Console.WriteLine($"Find first :: {current?.Value.ToString()}");
Console.WriteLine($"Next :: {current?.Next?.Value.ToString()}");*/


AlgoReview.Stack.Stack<int> stack = new AlgoReview.Stack.Stack<int>();
stack.Push(5);
stack.Push(10);
stack.Push(15);
stack.Push(20);
stack.Push(25);

Console.WriteLine($"Stack :: {stack}");
Console.WriteLine($"Peek :: {stack.Peek()}");
Console.WriteLine($"Pop :: {stack.Pop()}");

HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 5, 4, 6 };
Console.WriteLine($"Set :: {set.Count}");
Console.WriteLine($"Set :: {set.Contains(10)}");


