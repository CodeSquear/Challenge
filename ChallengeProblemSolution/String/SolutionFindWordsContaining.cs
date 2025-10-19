namespace ChallengeProblemSolution.String;

public class SolutionFindWordsContaining
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var list = new List<int>();

       for(int i = 0; i < words.Length; i++)
            if (IsContains(words[i] , x))
                list.Add(i);

        return list;
    }

    private bool IsContains(string item, char character)
        => item.Contains(character);
}