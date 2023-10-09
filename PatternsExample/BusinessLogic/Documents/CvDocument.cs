using PatternsExample.Base;
using PatternsExample.BusinessLogic.Pages;

namespace PatternsExample.BusinessLogic.Documents;

public sealed class CvDocument : Document
{
    protected override void RenderDocument()
    {
        Pages.Add(new IntroductionPage());
        Pages.Add(new EducationPage());
        Pages.Add(new ExperiencePage());
        Pages.Add(new SkillsPage());
    }
}