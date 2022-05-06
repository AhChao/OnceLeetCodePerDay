namespace OnceLeetCodePerDay.Implements;

public class L1678GoalParserInterpretation
{
    public string Interpret(string command)
    {
        for(var i = 0; i < command.Length; i++)
        {
            if(command[i] == '(')
            {
                if(command[i + 1] == 'a')
                    command = command.Substring(0, i) + "al" + command.Substring(i + 4);
                else
                    command = command.Substring(0, i) + "o" + command.Substring(i + 2);
            }
        }

        return command;
    }
}