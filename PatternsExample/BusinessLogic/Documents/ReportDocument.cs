using PatternsExample.Base;
using PatternsExample.BusinessLogic.Pages;

namespace PatternsExample.BusinessLogic.Documents;

public sealed class ReportDocument : Document
{
    protected override void RenderDocument()
    {
        Pages.Add(new IntroductionPage());
        Pages.Add(new SummaryPage());
    }
}