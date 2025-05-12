using System.Text;
using Var44_Model.Enums;

namespace Var44_View;

public class SpanishView : IVarView
{
    public SeishonenPainting AskForSeishonenPainting()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Elige el valor de la pintura en la habitación de Seishonen");
        
        Console.WriteLine("[0] a (あ)");
        Console.WriteLine("[1] Mancha");
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
        Console.WriteLine("Valor invalido");
        throw new ApplicationException();
    }

    public List<int> AskForNumeralHallwaysValues()
    {
        Console.WriteLine("Entrega los valores en Numeral Hallways:");
        Console.WriteLine("(Se puede llegar allí desde Check-Disk Nexus, en la puerta que tiene un número)");

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
        Console.WriteLine("NO   N  NE");
        Console.WriteLine("  \\ | /");
        Console.WriteLine("O - X - E");
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
                direction = "NO";
                break;
            case 1:
                direction = "N";
                break;
            case 2:
                direction = "NE";
                break;
            case 3:
                direction = "O";
                break;
            case 4:
                direction = "E";
                break;
            case 5:
                direction = "S";
                break;
            default:
                Console.WriteLine("Valor invalido");
                throw new NotImplementedException();
        }
        
        Console.WriteLine("Si el valor no aparece, escribe 0");
        Console.Write($"{direction}:");
        return Console.ReadLine();
    }

    private bool IsValueValid(int direction, string value)
    {
        int parsedValue;
        bool wasParsed = int.TryParse(value, out parsedValue);

        if (!wasParsed)
        {
            Console.WriteLine("Valor invalido");
            return false;
        } else if (parsedValue is < 0 or > 9) {
            Console.WriteLine("Valor fuera de rango");
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
        Console.WriteLine("Los posibles valores para la variable 44 son:");
        if (results.Count == 0)
        {
            Console.WriteLine("La variable 44 no existe... Algun valor fue agregado incorrectamente o fue procesado de manera erronea");
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