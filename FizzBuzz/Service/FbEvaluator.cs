using FizzBuzz.Constants;

namespace FizzBuzz.Service;

public static class FbEvaluator {
    public static FizzBuzzType Evaluate(int number)
    {
        if (number % 15 == 0) {
            return FizzBuzzType.Fifteen;
        }
        if (number % 5 == 0) {
            return FizzBuzzType.Five;
        }
        if (number % 3 == 0) {
            return FizzBuzzType.Three;
        }
        
        return FizzBuzzType.None;
    }
}
