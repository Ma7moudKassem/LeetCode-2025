using System.Text;

Console.WriteLine(SimplifyPath("/home/"));
string SimplifyPath(string path)
{
    var terms = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

    Stack<string> stack = [];
    StringBuilder sb = new();

    foreach (string term in terms)
    {
        if (term == ".")
            continue;

        if (term == "..")
        {
            if (stack.Count > 0)
                stack.Pop();
        }
        else
            stack.Push(term);
    }

    var parts = stack.ToList(); 
    for (int i = parts.Count - 1; i >= 0; i--) 
        sb.Append($"/{parts[i]}"); 
    
    string result = sb.ToString(); 

    return string.IsNullOrEmpty(result) ? "/" : result;
}