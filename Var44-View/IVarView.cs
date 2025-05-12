using Var44_Model.Enums;

namespace Var44_View;

public interface IVarView
{
    SeishonenPainting AskForSeishonenPainting();

    List<int> AskForNumeralHallwaysValues();

    void ShowResults(List<int> results);
}