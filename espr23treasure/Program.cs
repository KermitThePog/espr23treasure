using espr23treasure;

var lck = new treasureLock();
lck.Randomise();
Console.WriteLine(lck.ToString());
lck.Press(0b11010000);
Console.WriteLine(lck.ToString());