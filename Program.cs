using LinkedList;

Console.WriteLine("Test 1: Positive Number List");
CustomLinkedList positiveList = new CustomLinkedList();
positiveList.Append(5);
positiveList.Append(10);
positiveList.Append(15);
positiveList.Prepend(1);
Console.Write("Initial list: ");
positiveList.PrintList();

positiveList.Remove(10);
Console.Write("\nAfter removing 10: ");
positiveList.PrintList();

Console.WriteLine($"\nContains 5? {positiveList.Contains(5)}");
Console.WriteLine($"Contains 10? {positiveList.Contains(10)}");
Console.WriteLine();

Console.WriteLine("Test 2: Negative Number List");
CustomLinkedList negativeList = new CustomLinkedList();
negativeList.Prepend(-3);
negativeList.Prepend(-7);
negativeList.Append(-1);
Console.Write("Initial list: ");
negativeList.PrintList();

negativeList.Remove(-3);
Console.Write("\nAfter removing -3: ");
negativeList.PrintList();

Console.WriteLine($"\nContains -1? {negativeList.Contains(-1)}");
Console.WriteLine($"Contains -3? {negativeList.Contains(-3)}");
Console.WriteLine();

Console.WriteLine("Test 3: Mixed List with Duplicates");
CustomLinkedList mixedList = new CustomLinkedList();
mixedList.Append(4);
mixedList.Append(2);
mixedList.Append(4);
mixedList.Prepend(0);
mixedList.Append(2);
Console.Write("Initial list: ");
mixedList.PrintList();

mixedList.Remove(4);
Console.Write("\nAfter removing first 4: ");
mixedList.PrintList();

Console.WriteLine($"\nContains 2? {mixedList.Contains(2)}");
Console.WriteLine($"Contains 4? {mixedList.Contains(4)}");
