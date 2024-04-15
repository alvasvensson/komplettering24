Stack<string> cardStack = new Stack<string>() {};
Queue<string> hand = new Queue<string>();

cardStack.Push("spader 2");
cardStack.Push("hjärter 5");
cardStack.Push("ruter kung");

Console.ReadLine();

while(true){
Console.WriteLine($"Kortet du drog som nu läggs till i din hand är {cardStack.Peek()}");
string cardYouGrab = cardStack.Pop();
hand.Enqueue(cardYouGrab);
Console.ReadLine();
}
 
