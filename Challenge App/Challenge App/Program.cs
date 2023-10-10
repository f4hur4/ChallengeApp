using System.ComponentModel.Design;

var number = 44523801;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
string result = (" Wynik dla liczby " + number + " to: ");
Console.WriteLine(result);

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
        
    }
   
    else if(letter =='1')
    {
        counter1++;
    }
    else if (letter =='2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter =='4')
    {
        counter4++;
    }
    else if (letter =='5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter =='7')
    {
       counter7++;
    }
    else if (letter =='8')
    {
       counter8++;
    }
   else  if (letter=='9')
    {
        counter9++;
    }
}


List<string> numbers = new List<string>();

numbers.Add("cyfra 0 występuje razy " + counter0);
numbers.Add("cyfra 1 występuje razy " + counter1);
numbers.Add("cyfra 2 wsytępuje razy " + counter2);
numbers.Add("cyfra 3 występuje razy " + counter3);
numbers.Add("cyfra 4 występuje razy " + counter4);
numbers.Add("cyfra 5 wsytępuje razy " + counter5);
numbers.Add("cyfra 6 występuje razy " + counter6);
numbers.Add("cyfra 7 wsytępuje razy " + counter7);
numbers.Add("cyfra 8 występuje razy " + counter8);
numbers.Add("cyfra 9 wystepuje razy " + counter9);

foreach ( var digit in numbers)
{
    Console.WriteLine(digit);
}