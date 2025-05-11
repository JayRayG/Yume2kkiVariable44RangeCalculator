using Var44_Model;
using Var44_Model.Enums;
using Var44_View;

// Choose language / Elige idioma
// 0 : Spanish / Español
// 1 : English / Ingles

int language = 1;

IVarView view;
if (language == 0) {
    view = new SpanishView();
} else if (language == 1) {
    view = new EnglishView();
} else {
    throw new NotImplementedException();
}

try
{
    SeishonenPainting seishonen = view.AskForSeishonenPainting();
    List<int> numberValues = view.AskForNumeralPathwaysValues();
    ListOfVariable44ValidValues var44Values = new ListOfVariable44ValidValues(seishonen, numberValues);
    var44Values.ApplyLimitations();
    view.ShowResults(var44Values.GetListOfValues());
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}