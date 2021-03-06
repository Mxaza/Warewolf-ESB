
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18063
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Activities.Specs.Toolbox.Resources.Service.WebService
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
    public partial class WebServiceActivityFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WebServiceActivity.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WebServiceActivity", "In order to use WebService \r\nAs a Warewolf user\r\nI want a tool that calls the Web" +
                    "Services into the workflow", ProgrammingLanguage.CSharp, new string[] {
                        "ignore"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "WebServiceActivity")))
            {
                Dev2.Activities.Specs.Toolbox.Resources.Service.WebService.WebServiceActivityFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Executing WebService using recordsets")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebServiceActivity")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void ExecutingWebServiceUsingRecordsets()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing WebService using recordsets", new string[] {
                        "mytag"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
      testRunner.Given("I have a WebService \"country list\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
   testRunner.And("the input is mapped as \"[[json]]\" and \"[[a]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
      testRunner.And("the output is mapped as \"[[rec(*).CountryID]] \" and \"[[rec(*).Description]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
      testRunner.When("the Service is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
      testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "[[json]]= json",
                        ""});
            table1.AddRow(new string[] {
                        "[[rec(1).CountryID]]",
                        "[[rec(1).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(2).CountryID]]",
                        "[[rec(2).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(3).CountryID]]",
                        "[[rec(3).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(4).CountryID]]",
                        "[[rec(4).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(5).CountryID]]",
                        "[[rec(5).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(6).CountryID]]",
                        "[[rec(6).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(7).CountryID]]",
                        "[[rec(7).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(8).CountryID]]",
                        "[[rec(8).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(9).CountryID]]",
                        "[[rec(9).Description]]"});
            table1.AddRow(new string[] {
                        "[[rec(10).CountryID]]",
                        "[[rec(10).Description]]"});
#line 14
   testRunner.And("the debug input as", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ""});
            table2.AddRow(new string[] {
                        "[[rec(1).CountryID]] = 1",
                        "[[rec(1).Description]] = Afghanistan"});
            table2.AddRow(new string[] {
                        "[[rec(2).CountryID]] = 2",
                        "[[rec(2).Description]] = Albania"});
            table2.AddRow(new string[] {
                        "[[rec(3).CountryID]] = 3",
                        "[[rec(3).Description]] = Algeria"});
            table2.AddRow(new string[] {
                        "[[rec(4).CountryID]] = 4",
                        "[[rec(4).Description]] = Andorra"});
            table2.AddRow(new string[] {
                        "[[rec(5).CountryID]] = 5",
                        "[[rec(5).Description]] = Angola"});
            table2.AddRow(new string[] {
                        "[[rec(6).CountryID]] = 6",
                        "[[rec(6).Description]] = Argentina"});
            table2.AddRow(new string[] {
                        "[[rec(7).CountryID]] = 7",
                        "[[rec(7).Description]] = Armenia"});
            table2.AddRow(new string[] {
                        "[[rec(8).CountryID]] = 8",
                        "[[rec(8).Description]] = Australia"});
            table2.AddRow(new string[] {
                        "[[rec(9).CountryID]] = 9",
                        "[[rec(9).Description]] = Austria"});
            table2.AddRow(new string[] {
                        "[[rec(10).CountryID]] = 10",
                        "[[rec(10).Description]] = Azerbaijan"});
#line 28
      testRunner.And("the debug output as", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Executing WebService using negative recordset index")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebServiceActivity")]
        public virtual void ExecutingWebServiceUsingNegativeRecordsetIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing WebService using negative recordset index", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
      testRunner.Given("I have a WebService \"country list\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
   testRunner.And("the input is mapped as \"[[json]]\" and \"[[a]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
      testRunner.And("the output is mapped as \"[[rec(-1).CountryID]] \" and \"[[rec(1).Description]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
      testRunner.When("the Service is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
      testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[json]]=",
                        ""});
            table3.AddRow(new string[] {
                        "[[json]]=",
                        ""});
            table3.AddRow(new string[] {
                        "[[rec(-1).CountryID]]",
                        "[[rec(1).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(2).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(3).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(4).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(5).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(6).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(7).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(8).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(9).Description]]"});
            table3.AddRow(new string[] {
                        "",
                        "[[rec(10).Description]]"});
#line 47
   testRunner.And("the debug input as", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[rec(-1).CountryID]] =",
                        "[[rec(1).Description]] = Afghanistan"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(2).Description]] = Albania"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(3).Description]] = Algeria"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(4).Description]] = Andorra"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(5).Description]] = Angola"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(6).Description]] = Argentina"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(7).Description]] = Armenia"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(8).Description]] = Australia"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(9).Description]] = Austria"});
            table4.AddRow(new string[] {
                        "",
                        "[[rec(10).Description]] = Azerbaijan"});
#line 61
      testRunner.And("the debug output as", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Executing WebService using negative recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebServiceActivity")]
        public virtual void ExecutingWebServiceUsingNegativeRecordset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing WebService using negative recordset", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
      testRunner.Given("I have a WebService \"country list\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
   testRunner.And("the input is mapped as \"[[json]]\" and \"[[a]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
      testRunner.And("the output is mapped as \"[[rec(*).CountryID]] \" and \"[[rec(-1).Description]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
      testRunner.When("the Service is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
      testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "[[json]]= json",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(1).CountryID]]",
                        "[[rec(-1).Description]]"});
            table5.AddRow(new string[] {
                        "[[rec(2).CountryID]]",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(3).CountryID]]",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(4).CountryID]]",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(5).CountryID]]",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(6).CountryID]]",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(7).CountryID]]",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(8).CountryID]]",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(9).CountryID]]",
                        ""});
            table5.AddRow(new string[] {
                        "[[rec(10).CountryID]]",
                        ""});
#line 80
   testRunner.And("the debug input as", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(1).CountryID]] = 1",
                        "[[rec(-1).Description]] ="});
            table6.AddRow(new string[] {
                        "[[rec(2).CountryID]] = 2",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(3).CountryID]] = 3",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(4).CountryID]] = 4",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(5).CountryID]] = 5",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(6).CountryID]] = 6",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(7).CountryID]] = 7",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(8).CountryID]] = 8",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(9).CountryID]] = 9",
                        ""});
            table6.AddRow(new string[] {
                        "[[rec(10).CountryID]] = 10",
                        ""});
#line 93
       testRunner.And("the debug output as", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Executing WebService using scalar")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "WebServiceActivity")]
        public virtual void ExecutingWebServiceUsingScalar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing WebService using scalar", ((string[])(null)));
#line 106
this.ScenarioSetup(scenarioInfo);
#line 107
         testRunner.Given("I have a WebService \"country list\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 108
   testRunner.And("the input is mapped as \"[[json]]\" and \"[[a]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
      testRunner.And("the output is mapped as \"[[id]] \" and \"[[dsc]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
      testRunner.When("the Service is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
      testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ""});
            table7.AddRow(new string[] {
                        "[[json]]=json",
                        ""});
            table7.AddRow(new string[] {
                        "[[id]]",
                        "[[dsc]]"});
#line 112
    testRunner.And("the debug input as", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "[[id]] = 10",
                        ""});
            table8.AddRow(new string[] {
                        "[[dsc]] = Azerbaijan",
                        ""});
#line 116
    testRunner.And("the debug output as", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
