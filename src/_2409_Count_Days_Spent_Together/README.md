# 2409. Count Days Spent Together

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)
![Topics](https://img.shields.io/badge/string-blue)

[2409. Count Days Spent Together](https://leetcode.com/problems/count-days-spent-together/description/)

Alice and Bob are traveling to Rome for separate business meetings. You are given 4 strings arriveAlice, leaveAlice,
arriveBob, and leaveBob. Alice will be in the city from the dates arriveAlice to leaveAlice (inclusive), while Bob will
be in the city from the dates arriveBob to leaveBob (inclusive). Each will be a 5-character string in the format "
MM-DD", corresponding to the month and day of the date. Return the total number of days that Alice and Bob are in Rome
together. You can assume that all dates occur in the same calendar year, which is not a leap year. Note that the number
of days per month can be represented as: [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31].

## Example 1

> **Input**: `arriveAlice = "08-15", leaveAlice = "08-18", arriveBob = "08-16", leaveBob = "08-19"`  
> **Output**: `3`  
> **Explanation**: Alice will be in Rome from August 15 to August 18. Bob will be in Rome from August 16 to August 19.
> They are both in Rome together on August 16th, 17th, and 18th, so the answer is 3.

## Example 2

> **Input**: `arriveAlice = "10-01", leaveAlice = "10-31", arriveBob = "11-01", leaveBob = "12-31"`  
> **Output**: `0`  
> **Explanation**: There is no day when Alice and Bob are in Rome together, so we return 0.

## Constraints

> - `All dates are provided in the format "MM-DD"`
> - `Alice and Bob's arrival dates are earlier than or equal to their leaving dates.`
> - `The given dates are valid dates of a non-leap year.`

## Code

```csharp
private static readonly int[] Days = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
{
    var aliceStart = CountDaysInternal(arriveAlice);
    var aliceEnd = CountDaysInternal(leaveAlice);

    var bobStart = CountDaysInternal(arriveBob);
    var bobEnd = CountDaysInternal(leaveBob);

    return Math.Max(0, Math.Min(aliceEnd, bobEnd) - Math.Max(aliceStart, bobStart) + 1);
}

private int CountDaysInternal(ReadOnlySpan<char> date)
{
    var m = int.Parse(date[..2]);
    var d = int.Parse(date[3..5]);

    return Days[..(m - 1)].Sum() + d;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)