namespace RandomSquares;

public class VirtualScreenRow
{
    private VirtualScreenCell[] _cells;

    public VirtualScreenRow(int screenWidth)
    {
        _cells = new VirtualScreenCell[screenWidth];
        for (int i = 0; i < _cells.Length; i++)
        {
            _cells[i] = new VirtualScreenCell();
        }
    }

    public void AddBoxTopRow(int boxX, int boxWidth)
    {
        _cells[boxX].AddUpperLeftCorner();
        var width = boxX + boxWidth - 1;
        for (int i = boxX; i < width; i++)
        {
            _cells[i].AddHorizontal();
        }
        _cells[width].AddUpperRightCorner();
    }

    public void AddBoxBottomRow(int boxX, int boxWidth)
    {
        _cells[boxX].AddLowerLeftCorner();
        var width = boxX + boxWidth - 1;
        for (int i = boxX; i < width; i++)
        {
            _cells[i].AddHorizontal();
        }
        _cells[width].AddLowerRightCorner();
    }

    public void AddBoxMiddleRow(int boxX, int boxWidth)
    {
        var width = boxX + boxWidth - 1;
        _cells[boxX].AddVertical();
        _cells[width].AddVertical();
    }

    public void Show()
    {
        foreach (var cell in _cells)
        {
            Console.Write(cell.GetCharacter());
        }
        Console.WriteLine();
    }
}