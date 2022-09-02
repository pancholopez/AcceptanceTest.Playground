using System.Diagnostics;

namespace AcceptanceTest.SpecFlow.Playwright.Hooks;

[Binding]
public class CalculatorHooks
{
    private readonly ScenarioContext _scenarioContext;

    public CalculatorHooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeFeature]
    public static void SetupFeature()
    {
        Debug.WriteLine("[BeforeFeature] SetupFeature()");
    }

    [AfterFeature]
    public static void TeardownFeature()
    {
        Debug.WriteLine("[AfterFeature] TeardownFeature()");
    }

    [BeforeScenario]
    public void SetupScenario()
    {
        Debug.WriteLine("[BeforeScenario] SetupScenario()");
    }

    [AfterScenario]
    public void TeardownScenario()
    {
        Debug.WriteLine("[AfterScenario] TeardownScenario()");
    }
}