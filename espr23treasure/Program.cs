using espr23treasure;

var lck = new TreasureLock();
lck.Randomise();
lck.Press(0b1111, false);
lck.Press(0b1010);
lck.Press(0b0011);
lck.Press(0b1010);
lck.Press(0b0001);
lck.Press(0b1010);
lck.Press(0b0011);
lck.Press(0b1010);