const string input = "[()]{}{[()()]()}";
Stack<char> stack = new Stack<char>();
bool balance = true;

foreach(char c in input)
{
    if(c == '[' || c=='(' || c=='{')
    {
        stack.Push(c);
    }

    else 
    {
        char start = stack.Pop();
        if
        (
            (c == ')' && start != '(') ||
            (c == '}' && start != '{') ||
            (c == ']' && start != '[') ||
        )
        {
            balanced = false;
            break;
        }

    }
}

if(balanced)
{
    Console.WriteLine("Balanced");
}

else
{
    Console.WriteLine("Not Balanced");
}