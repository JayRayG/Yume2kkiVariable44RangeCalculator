using System.Text;
using Var44_Model.Enums;

namespace Var44_View;

public class EnglishView : IVarView
{
    public SeishonenPainting AskForSeishonenPainting()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Choose the value of the painting in Seishonen's room");
        
        Console.WriteLine("[0] a (あ)");
        Console.WriteLine("[1] Smudge");
        Console.WriteLine("[2] nu (ぬ)");
        Console.WriteLine("[3] ha (は)");
        Console.WriteLine("[4] wo (を)");
        Console.WriteLine("[5] pe (ぺ)");

        string choice = Console.ReadLine();

        List<string> possibleChoices = new List<string> {"0","1","2","3","4","5"};

        if (possibleChoices.Contains(choice))
        {
            return (SeishonenPainting)Convert.ToInt32(choice);
        }
        Console.WriteLine("Invalid value");
        throw new ApplicationException();
    }

    public List<int> AskForNumeralPathwaysValues()
    {
        Console.WriteLine("Input the values in Numeral Pathways:");
        Console.WriteLine("(You can get there from Check-Disk Nexus, in the door with the number on it)");

        List<int> listOfValues = new List<int>();
        
        for (int i = 0; i < 6; i++)
        {
            ShowWindRose();
            string s = AskForSpecificValue(i);
            bool isValid = IsValueValid(i, s);
            int n;
            if (isValid)
            {
                n = Convert.ToInt32(s);
            }
            else
            {
                throw new ApplicationException();
            }
            listOfValues.Add(n);
        }

        return listOfValues;
    }

    private void ShowWindRose()
    {
        Console.WriteLine("");
        Console.WriteLine("NW   N  NE");
        Console.WriteLine("  \\ | /");
        Console.WriteLine("W - X - E");
        Console.WriteLine("    |");
        Console.WriteLine("    S");
        Console.WriteLine("");
    }

    private string AskForSpecificValue(int whichValue)
    {
        string direction;
        switch (whichValue)
        {
            case 0:
                direction = "NW";
                break;
            case 1:
                direction = "N";
                break;
            case 2:
                direction = "NE";
                break;
            case 3:
                direction = "W";
                break;
            case 4:
                direction = "E";
                break;
            case 5:
                direction = "S";
                break;
            default:
                Console.WriteLine("Invalid value");
                throw new NotImplementedException();
        }
        
        Console.WriteLine("If the value doesn't show up, input 0");
        Console.Write($"{direction}:");
        return Console.ReadLine();
    }

    private bool IsValueValid(int direction, string value)
    {
        int parsedValue;
        bool wasParsed = int.TryParse(value, out parsedValue);

        if (!wasParsed)
        {
            Console.WriteLine("Invalid value");
            return false;
        } else if (parsedValue is < 0 or > 9) {
            Console.WriteLine("Value out of range");
            return false;
        }

        if (direction == 1)
        {
            return parsedValue is 0 or 4;
        }
        return true;
    }

    public void ShowResults(List<int> results)
    {
        Console.WriteLine("The values for variable 44 are:");
        if (results.Count == 0)
        {
            Console.WriteLine("Variable 44 does not exist... Some value was input wrong or it was processed wrong");
        }
        else
        {
            for (int j = 0; j < results.Count; j++)
            {
                Console.Write($"({results[j]})   ");
            }
        }
    }
}