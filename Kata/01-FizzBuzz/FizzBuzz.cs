namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string SayFizz(int number){
        //throw new NotImplementedException("Not implement yet");

        if(number % 3 == 0)
            return "Fizz";
        
        return  number.ToString();
    }

    public string SayBuzz(int number){
        //throw new NotImplementedException("Not implement yet");

        if(number % 5 == 0)
            return "Buzz";

        return number.ToString();
    }

    public string SayFizzBuzz(int number)
    {
        //throw new NotImplementedException("Not implement yet");

        if(number % 15 == 0)
            return "FizzBuzz";
        
        string numberAsText = number.ToString();

        string numberFizzOrBuzz = SayFizz(number);
        if(numberFizzOrBuzz != numberAsText)
            return numberFizzOrBuzz;

        numberFizzOrBuzz = SayBuzz(number);
        if(numberFizzOrBuzz != numberAsText)
            return numberFizzOrBuzz;

        return numberAsText;
    }

    public void IsNumberValidForOneToOneHundred(int number)
    {
        //throw new NotImplementedException("Not implement yet");

        if (number < 1 || number > 100)
            throw new ArgumentException(number.ToString() + "is not a valid number from 1 to 100");
    }

    public string SayFizzBuzzFromOneToOneHundredNumbers()
    {
        //throw new NotImplementedException("Not implement yet");

        List<string> fizzBuzzResult = new List<string>();
        for (int number = 1; number <= 100; number++)
        {
            IsNumberValidForOneToOneHundred(number);

            fizzBuzzResult.Add(SayFizzBuzz(number));
        }

        return String.Join(" ", fizzBuzzResult);
    }
}

