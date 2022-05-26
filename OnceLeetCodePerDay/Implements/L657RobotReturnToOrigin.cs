namespace OnceLeetCodePerDay.Implements;

public class L657RobotReturnToOrigin
{
    public bool JudgeCircle(string moves)
    {
        var vertical = 0;
        var horizontal = 0;
        for(var i = 0; i < moves.Length; i++)
        {
            switch(moves[i])
            {
                case 'U':
                    vertical++;
                    break;
                case 'D':
                    vertical--;
                    break;
                case 'L':
                    horizontal--;
                    break;
                case 'R':
                    horizontal++;
                    break;
            }
        }

        return vertical == 0 && horizontal == 0;
    }
}