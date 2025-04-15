namespace _20_Valid_Parentheses;

public class Solution
{
    private static readonly Dictionary<char, char> Brackets = new()
    {
        { ')', '(' },
        { '}', '{' },
        { ']', '[' }
    };

    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var symbol in s)
            if (Brackets.TryGetValue(symbol, out var open))
            {
                if (!stack.TryPop(out var closed) || closed != open)
                    return false;
            }
            else
            {
                stack.Push(symbol);
            }

        return stack.Count == 0;
    }
}