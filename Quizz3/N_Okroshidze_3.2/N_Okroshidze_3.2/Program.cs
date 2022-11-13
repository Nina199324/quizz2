using System.Collections;

Queue myQueue = new Queue();
myQueue.Enqueue(100);
myQueue.Enqueue(null);
myQueue.Enqueue(24);
myQueue.Enqueue(11);
myQueue.Enqueue(1993);
myQueue.Enqueue(29);
myQueue.Enqueue(0);
myQueue.Enqueue(2023); 
myQueue.Enqueue(null);
Console.WriteLine(myQueue.Count);
Console.WriteLine(myQueue.Dequeue());
Console.WriteLine(myQueue.GetType());
Console.WriteLine("Var elementebi myQueue-shi: ");
Console.WriteLine(myQueue.Count); 
foreach (var element in myQueue)
    Console.WriteLine(element);
