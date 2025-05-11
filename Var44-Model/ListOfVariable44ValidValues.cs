using Var44_Model.Enums;

namespace Var44_Model;

public class ListOfVariable44ValidValues
{
    private List<int> _values = Enumerable.Range(0, 256).ToList();
    private SeishonenPainting _seishonenPainting;
    private List<int> _valuesByDirection;

    public ListOfVariable44ValidValues(SeishonenPainting sP, List<int> vD)
    {
        _seishonenPainting = sP;
        _valuesByDirection = vD;
    }

    public void ApplyLimitations()
    {
        ApplySeishonenLimitation();
        ApplyNumeralPathwaysLimitation();
    }

    private void ApplySeishonenLimitation()
    {
        switch (_seishonenPainting)
        {
            case SeishonenPainting.a:
                _values.RemoveAll(n => !IsBetweenValues(0, 61, n));
                break;
            case SeishonenPainting.smudge:
                _values.RemoveAll(n => !IsBetweenValues(62, 62, n));
                break;
            case SeishonenPainting.nu:
                _values.RemoveAll(n => !IsBetweenValues(63, 126, n));
                break;
            case SeishonenPainting.ha:
                _values.RemoveAll(n => !IsBetweenValues(127, 191, n));
                break;
            case SeishonenPainting.wo:
                _values.RemoveAll(n => !IsBetweenValues(192, 236, n));
                break;
            case SeishonenPainting.pe:
                _values.RemoveAll(n => !IsBetweenValues(237, 255, n));
                break;
        }
    }

    private static bool IsBetweenValues(int min, int max, int value)
    {
        return min <= value && value <= max;
    }

    private void ApplyNumeralPathwaysLimitation()
    {
        switch (_valuesByDirection[0])
        {
            case 0:
                _values.RemoveAll(n => !IsBetweenValues(0, 19, n));
                break;
            case 1:
                _values.RemoveAll(n => !IsBetweenValues(20, 69, n));
                break;
            case 2:
                _values.RemoveAll(n => !IsBetweenValues(70, 82, n));
                break;
            case 3:
                _values.RemoveAll(n => !IsBetweenValues(83, 89, n));
                break;
            case 4:
                _values.RemoveAll(n => !IsBetweenValues(90, 102, n));
                break;
            case 5:
                _values.RemoveAll(n => !IsBetweenValues(103, 125, n));
                break;
            case 6:
                _values.RemoveAll(n => !IsBetweenValues(126, 126, n));
                break;
            case 7:
                _values.RemoveAll(n => !IsBetweenValues(127, 189, n));
                break;
            case 8:
                _values.RemoveAll(n => !IsBetweenValues(190, 229, n));
                break;
            case 9:
                _values.RemoveAll(n => !IsBetweenValues(230, 255, n));
                break;
        }

        switch (_valuesByDirection[1])
        {
            case 0:
                _values.RemoveAll(n => IsBetweenValues(120, 134, n));
                break;
            case 4:
                _values.RemoveAll(n => !IsBetweenValues(120, 134, n));
                break;
        }
        
        switch (_valuesByDirection[2])
        {
            case 0:
                _values.RemoveAll(n => !IsBetweenValues(0, 49, n));
                break;
            case 1:
                _values.RemoveAll(n => !IsBetweenValues(50, 99, n));
                break;
            case 2:
                _values.RemoveAll(n => !IsBetweenValues(100, 104, n));
                break;
            case 3:
                _values.RemoveAll(n => !IsBetweenValues(105, 109, n));
                break;
            case 4:
                _values.RemoveAll(n => !IsBetweenValues(110, 119, n));
                break;
            case 5:
                _values.RemoveAll(n => !IsBetweenValues(120, 139, n));
                break;
            case 6:
                _values.RemoveAll(n => !IsBetweenValues(140, 154, n));
                break;
            case 7:
                _values.RemoveAll(n => !IsBetweenValues(155, 170, n));
                break;
            case 8:
                _values.RemoveAll(n => !IsBetweenValues(171, 174, n));
                break;
            case 9:
                _values.RemoveAll(n => !IsBetweenValues(175, 255, n));
                break;
        }
        
        switch (_valuesByDirection[3])
        {
            case 0:
                _values.RemoveAll(n => !IsBetweenValues(0, 0, n));
                break;
            case 1:
                _values.RemoveAll(n => !IsBetweenValues(1, 49, n));
                break;
            case 2:
                _values.RemoveAll(n => !IsBetweenValues(50, 99, n));
                break;
            case 3:
                _values.RemoveAll(n => !IsBetweenValues(100, 149, n));
                break;
            case 4:
                _values.RemoveAll(n => !IsBetweenValues(150, 199, n));
                break;
            case 5:
                _values.RemoveAll(n => !IsBetweenValues(200, 249, n));
                break;
            case 6:
                _values.RemoveAll(n => !IsBetweenValues(250, 250, n));
                break;
            case 7:
                _values.RemoveAll(n => !IsBetweenValues(251, 252, n));
                break;
            case 8:
                _values.RemoveAll(n => !IsBetweenValues(253, 254, n));
                break;
            case 9:
                _values.RemoveAll(n => !IsBetweenValues(255, 255, n));
                break;
        }
        
        switch (_valuesByDirection[4])
        {
            case 0:
                _values.RemoveAll(n => !IsBetweenValues(0, 0, n));
                break;
            case 1:
                _values.RemoveAll(n => !IsBetweenValues(1, 39, n));
                break;
            case 2:
                _values.RemoveAll(n => !IsBetweenValues(40, 109, n));
                break;
            case 3:
                _values.RemoveAll(n => !IsBetweenValues(110, 159, n));
                break;
            case 4:
                _values.RemoveAll(n => !IsBetweenValues(160, 174, n));
                break;
            case 5:
                _values.RemoveAll(n => !IsBetweenValues(175, 179, n));
                break;
            case 6:
                _values.RemoveAll(n => !IsBetweenValues(180, 199, n));
                break;
            case 7:
                _values.RemoveAll(n => !IsBetweenValues(200, 219, n));
                break;
            case 8:
                _values.RemoveAll(n => !IsBetweenValues(220, 241, n));
                break;
            case 9:
                _values.RemoveAll(n => !IsBetweenValues(242, 255, n));
                break;
        }
        
        switch (_valuesByDirection[5])
        {
            case 0:
                _values.RemoveAll(n => !IsBetweenValues(0, 6, n));
                break;
            case 1:
                _values.RemoveAll(n => !IsBetweenValues(7, 17, n));
                break;
            case 2:
                _values.RemoveAll(n => !IsBetweenValues(18, 39, n));
                break;
            case 3:
                _values.RemoveAll(n => !IsBetweenValues(40, 79, n));
                break;
            case 4:
                _values.RemoveAll(n => !IsBetweenValues(80, 129, n));
                break;
            case 5:
                _values.RemoveAll(n => !IsBetweenValues(130, 144, n));
                break;
            case 6:
                _values.RemoveAll(n => !IsBetweenValues(145, 164, n));
                break;
            case 7:
                _values.RemoveAll(n => !IsBetweenValues(165, 169, n));
                break;
            case 8:
                _values.RemoveAll(n => !IsBetweenValues(170, 176, n));
                break;
            case 9:
                _values.RemoveAll(n => !IsBetweenValues(177, 255, n));
                break;
        }
    }

    public List<int> GetListOfValues()
    {
        return _values;
    }
}