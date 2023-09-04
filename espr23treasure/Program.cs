using espr23treasure;

//Solution for EPSR 2023 application round 1

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