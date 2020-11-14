using System.Collections.Generic;
using System.Linq;

public class StringValidator
{
    private static Dictionary<char, char> _pairs = new()
    {
        {'(', ')'},
        {'{', '}'},
        {'[', ']'}
    };

    public bool Validate(string text)
    {
        var stack = new Stack<char>();
        foreach (var character in text)
        {
            if(IsOpen(character))
                stack.Push(character);
            else
            {
                var lastCharacter = stack.Pop();
                if (!Closes(lastCharacter, character))
                    return false;
            }
        }

        return stack.Count == 0;
    }

    private bool IsOpen(char character) => new[] { '(', '{', '[' }.Any(x => x == character);
    private bool Closes(char lastCharacter, char character) => character == _pairs[lastCharacter];
}