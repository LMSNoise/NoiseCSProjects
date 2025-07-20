int eggAmount;
eggAmount = Convert.ToInt32(Console.ReadLine());

int sisterAmount = eggAmount / 4;
int bearAmount = eggAmount % 4;

Console.WriteLine("Sister egg count: " + sisterAmount + "\nBear egg count: " + bearAmount);

//For the bear to have more than the sister, you'd need to have a larger remainder than the number you'd get from division
// that would be, then:
//Any number below 4 (probably doesn't count here) or 6 (1 each, bear gets 2), 7 (1 each, bear gets 3), 11 (2 each, bear gets 3)