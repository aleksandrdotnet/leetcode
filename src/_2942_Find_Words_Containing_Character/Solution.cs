namespace _2942_Find_Words_Containing_Character;

public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var result = new List<int>();

        for (var i = 0; i < words.Length; i++)
        {
            foreach (var c in words[i])
            {
                if (c == x)
                {
                    result.Add(i);
                    break;
                }
            }
        }

        return result;
    }
}