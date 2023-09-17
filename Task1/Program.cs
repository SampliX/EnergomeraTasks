Stack<char> chars = new Stack<char>();

foreach (var c in Console.ReadLine())
{
    switch (c)
    {
        case '(':
        case '{':
        case '[':
            chars.Push(c);
            break;

        case ')':
        case '}':
        case ']':
            if (chars.Count() == 0 ||
                (c == ')' && chars.Peek() != '(') ||
                (c == '}' && chars.Peek() != '{') ||
                (c == ']' && chars.Peek() != '['))
            {
                Console.WriteLine(false);
                return;
            }
            chars.Pop();
            break;
    }
}
Console.WriteLine(chars.Count() == 0);