using Var44_Model.Enums;

namespace Var44_View;

public interface IVarView
{
    SeishonenPainting AskForSeishonenPainting();

    List<int> AskForNumeralPathwaysValues();

    void ShowResults(List<int> results);
}