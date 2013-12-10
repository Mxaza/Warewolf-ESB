﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Activities.Specs.Toolbox.Recordset.Sort
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SortFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Sort.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Sort", "In order to sort a recordset\r\nAs a Warewolf user\r\nI want a tool I can use to arra" +
                    "nge records in either ascending or descending order", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Sort")))
            {
                Dev2.Activities.Specs.Toolbox.Recordset.Sort.SortFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sort a recordset forwards using star notation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sort")]
        public virtual void SortARecordsetForwardsUsingStarNotation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sort a recordset forwards using star notation", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "You"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "are"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "the"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "best"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "user"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "so far"});
#line 7
 testRunner.Given("I have the following recordset to sort", ((string)(null)), table1, "Given ");
#line 16
 testRunner.And("I sort a record \"[[rs(*).row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("my sort order is \"Forward\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.When("the sort records tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table2.AddRow(new string[] {
                        "rs().row",
                        "are"});
            table2.AddRow(new string[] {
                        "rs().row",
                        "best"});
            table2.AddRow(new string[] {
                        "rs().row",
                        "so far"});
            table2.AddRow(new string[] {
                        "rs().row",
                        "the"});
            table2.AddRow(new string[] {
                        "rs().row",
                        "user"});
            table2.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
            table2.AddRow(new string[] {
                        "rs().row",
                        "You"});
#line 19
 testRunner.Then("the sorted recordset \"[[rs().row]]\"  will be", ((string)(null)), table2, "Then ");
#line 28
 testRunner.And("the sort execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sort a recordset backwards using star notation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sort")]
        public virtual void SortARecordsetBackwardsUsingStarNotation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sort a recordset backwards using star notation", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "You"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "are"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "the"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "best"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "user"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "so far"});
#line 31
 testRunner.Given("I have the following recordset to sort", ((string)(null)), table3, "Given ");
#line 40
 testRunner.And("I sort a record \"[[rs(*).row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("my sort order is \"Backwards\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.When("the sort records tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table4.AddRow(new string[] {
                        "rs().row",
                        "You"});
            table4.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
            table4.AddRow(new string[] {
                        "rs().row",
                        "user"});
            table4.AddRow(new string[] {
                        "rs().row",
                        "the"});
            table4.AddRow(new string[] {
                        "rs().row",
                        "so far"});
            table4.AddRow(new string[] {
                        "rs().row",
                        "best"});
            table4.AddRow(new string[] {
                        "rs().row",
                        "are"});
#line 43
 testRunner.Then("the sorted recordset \"[[rs().row]]\"  will be", ((string)(null)), table4, "Then ");
#line 52
 testRunner.And("the sort execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sort a recordset forwards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sort")]
        public virtual void SortARecordsetForwards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sort a recordset forwards", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table5.AddRow(new string[] {
                        "rs().row",
                        "You"});
            table5.AddRow(new string[] {
                        "rs().row",
                        "are"});
            table5.AddRow(new string[] {
                        "rs().row",
                        "the"});
            table5.AddRow(new string[] {
                        "rs().row",
                        "best"});
            table5.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
            table5.AddRow(new string[] {
                        "rs().row",
                        "user"});
            table5.AddRow(new string[] {
                        "rs().row",
                        "so far"});
#line 55
 testRunner.Given("I have the following recordset to sort", ((string)(null)), table5, "Given ");
#line 64
 testRunner.And("I sort a record \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("my sort order is \"Forward\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("the sort records tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table6.AddRow(new string[] {
                        "rs().row",
                        "are"});
            table6.AddRow(new string[] {
                        "rs().row",
                        "best"});
            table6.AddRow(new string[] {
                        "rs().row",
                        "so far"});
            table6.AddRow(new string[] {
                        "rs().row",
                        "the"});
            table6.AddRow(new string[] {
                        "rs().row",
                        "user"});
            table6.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
            table6.AddRow(new string[] {
                        "rs().row",
                        "You"});
#line 67
 testRunner.Then("the sorted recordset \"[[rs().row]]\"  will be", ((string)(null)), table6, "Then ");
#line 76
 testRunner.And("the sort execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sort a recordset backwards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sort")]
        public virtual void SortARecordsetBackwards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sort a recordset backwards", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "You"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "are"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "the"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "best"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "user"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "so far"});
#line 79
 testRunner.Given("I have the following recordset to sort", ((string)(null)), table7, "Given ");
#line 88
 testRunner.And("I sort a record \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("my sort order is \"Backwards\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.When("the sort records tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table8.AddRow(new string[] {
                        "rs().row",
                        "You"});
            table8.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
            table8.AddRow(new string[] {
                        "rs().row",
                        "user"});
            table8.AddRow(new string[] {
                        "rs().row",
                        "the"});
            table8.AddRow(new string[] {
                        "rs().row",
                        "so far"});
            table8.AddRow(new string[] {
                        "rs().row",
                        "best"});
            table8.AddRow(new string[] {
                        "rs().row",
                        "are"});
#line 91
 testRunner.Then("the sorted recordset \"[[rs().row]]\"  will be", ((string)(null)), table8, "Then ");
#line 100
 testRunner.And("the sort execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sort a recordset forwards empty recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sort")]
        public virtual void SortARecordsetForwardsEmptyRecordset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sort a recordset forwards empty recordset", ((string[])(null)));
#line 102
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
#line 103
 testRunner.Given("I have the following recordset to sort", ((string)(null)), table9, "Given ");
#line 105
 testRunner.And("I sort a record \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("my sort order is \"Forward\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.When("the sort records tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
#line 108
 testRunner.Then("the sorted recordset \"[[rs().row]]\"  will be", ((string)(null)), table10, "Then ");
#line 110
 testRunner.And("the sort execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sort a recordset backwards empty recordset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sort")]
        public virtual void SortARecordsetBackwardsEmptyRecordset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sort a recordset backwards empty recordset", ((string[])(null)));
#line 112
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
#line 113
 testRunner.Given("I have the following recordset to sort", ((string)(null)), table11, "Given ");
#line 115
 testRunner.And("I sort a record \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("my sort order is \"Backwards\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.When("the sort records tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
#line 118
 testRunner.Then("the sorted recordset \"[[rs().row]]\"  will be", ((string)(null)), table12, "Then ");
#line 120
 testRunner.And("the sort execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sort a recordset forwards with one row")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sort")]
        public virtual void SortARecordsetForwardsWithOneRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sort a recordset forwards with one row", ((string[])(null)));
#line 122
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table13.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
#line 123
 testRunner.Given("I have the following recordset to sort", ((string)(null)), table13, "Given ");
#line 126
 testRunner.And("I sort a record \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("my sort order is \"Forward\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.When("the sort records tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table14.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
#line 129
 testRunner.Then("the sorted recordset \"[[rs().row]]\"  will be", ((string)(null)), table14, "Then ");
#line 132
 testRunner.And("the sort execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sort a recordset backwards recordset  with one row")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sort")]
        public virtual void SortARecordsetBackwardsRecordsetWithOneRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sort a recordset backwards recordset  with one row", ((string[])(null)));
#line 134
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table15.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
#line 135
 testRunner.Given("I have the following recordset to sort", ((string)(null)), table15, "Given ");
#line 138
 testRunner.And("I sort a record \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("my sort order is \"Backwards\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.When("the sort records tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table16.AddRow(new string[] {
                        "rs().row",
                        "Warewolf"});
#line 141
 testRunner.Then("the sorted recordset \"[[rs().row]]\"  will be", ((string)(null)), table16, "Then ");
#line 144
 testRunner.And("the sort execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
