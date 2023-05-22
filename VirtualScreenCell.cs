namespace RandomSquares;

public class VirtualScreenCell
{
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }

    public char GetCharacter()
    {
        var charToReturn =
            Up && Right ? '└' :
            Up && Left ? '┘' :
            Down && Right ? '┌' :
            Down && Left ? '┐' :
            Left && !Right && !Up && !Down ? '─' :
            Up && !Right && !Left && !Down ? '│' : ' ';
        return charToReturn;

        //if (Up && Down && Left && Right) return '┼';
        //if (Up && Down && Left && !Right) return '┤';
        //if (Up && Down && !Left && !Right) return '│';
        //if (Up && Down && !Left && Right) return '├';

        //if (Up && !Down && Left && !Right) return '┘';
        //if (Up && !Down && Left && Right) return '┴';
        //if (Up && !Down && !Left && !Right) return '╵';
        //if (Up && !Down && !Left && Right) return '└';

        //if (!Up && Down && Left && !Right) return '┐';
        //if (!Up && Down && Left && Right) return '┬';
        //if (!Up && Down && !Left && !Right) return '╷';
        //if (!Up && Down && !Left && Right) return '┌';

        //if (!Up && !Down && Left && !Right) return '╴';
        //if (!Up && !Down && Left && Right) return '─';
        //if (!Up && !Down && !Left && !Right) return ' ';
        //if (!Up && !Down && !Left && Right) return '╶';
        //return ' ';
    }

    public void AddHorizontal()
    {
        Left = true;
    }

    public void AddVertical()
    {
        Up = true;
    }

    public void AddLowerLeftCorner()
    {
        Up = true;
        Right = true;
    }

    public void AddLowerRightCorner()
    {
        Up = true;
        Left = true;
    }

    public void AddUpperLeftCorner()
    {
        Down = true;
        Right = true;
    }

    public void AddUpperRightCorner()
    {
        Down = true;
        Left = true;
    }
}