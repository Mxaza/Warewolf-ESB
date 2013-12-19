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
namespace Dev2.Activities.Specs.Toolbox.Recordset.Unique
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class UniqueFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Unique.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Unique", "In order to find unique records in a recordset\r\nAs a Warewolf user\r\nI want tool t" +
                    "hat will allow me", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Unique")))
            {
                Dev2.Activities.Specs.Toolbox.Recordset.Unique.UniqueFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records in a  dataset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsInADataset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records in a  dataset", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "10"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "20"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "20"});
            table1.AddRow(new string[] {
                        "rs().row",
                        "30"});
#line 7
 testRunner.Given("I have the following duplicated recordset", ((string)(null)), table1, "Given ");
#line 13
 testRunner.And("I want to find unique in field \"[[rs().row]]\" with the return field \"[[rs().row]]" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("The result variable is \"[[rec().unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "result",
                        "unique"});
            table2.AddRow(new string[] {
                        "rec().unique",
                        "10"});
            table2.AddRow(new string[] {
                        "rec().unique",
                        "20"});
            table2.AddRow(new string[] {
                        "rec().unique",
                        "30"});
#line 16
 testRunner.Then("the unique result will be", ((string)(null)), table2, "Then ");
#line 21
 testRunner.And("the unique execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records in a  dataset comma separated")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsInADatasetCommaSeparated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records in a  dataset comma separated", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "10"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "20"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "20"});
            table3.AddRow(new string[] {
                        "rs().row",
                        "30"});
            table3.AddRow(new string[] {
                        "rs().data",
                        "10"});
            table3.AddRow(new string[] {
                        "rs().data",
                        "20"});
            table3.AddRow(new string[] {
                        "rs().data",
                        "20"});
            table3.AddRow(new string[] {
                        "rs().data",
                        "30"});
#line 24
 testRunner.Given("I have the following duplicated recordset", ((string)(null)), table3, "Given ");
#line 34
 testRunner.And("I want to find unique in field \"[[rs().row]],[[rs().data]]\" with the return field" +
                    " \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("The result variable is \"[[rec(*).unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec",
                        "unique"});
            table4.AddRow(new string[] {
                        "rec().unique",
                        "10"});
            table4.AddRow(new string[] {
                        "rec().unique",
                        "20"});
            table4.AddRow(new string[] {
                        "rec().unique",
                        "30"});
#line 37
 testRunner.Then("the unique result will be", ((string)(null)), table4, "Then ");
#line 42
 testRunner.And("the unique execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records in an empty dataset")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsInAnEmptyDataset()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records in an empty dataset", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
#line 45
 testRunner.Given("I have the following empty recordset", ((string)(null)), table5, "Given ");
#line 47
 testRunner.And("I want to find unique in field \"[[rs().row]]\" with the return field \"[[rs().row]]" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("The result variable is \"[[rec().unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec",
                        "unique"});
#line 50
 testRunner.Then("the unique result will be", ((string)(null)), table6, "Then ");
#line 52
 testRunner.And("the unique execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records in a  dataset and the in field is blank")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsInADatasetAndTheInFieldIsBlank()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records in a  dataset and the in field is blank", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table7.AddRow(new string[] {
                        "rs().row",
                        "3"});
#line 55
 testRunner.Given("I have the following duplicated recordset", ((string)(null)), table7, "Given ");
#line 61
 testRunner.And("I want to find unique in field \"\" with the return field \"[[rs().row]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("The result variable is \"[[rec().unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec",
                        "unique"});
#line 64
 testRunner.Then("the unique result will be", ((string)(null)), table8, "Then ");
#line 66
 testRunner.And("the unique execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records in a  dataset the return field is blank")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsInADatasetTheReturnFieldIsBlank()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records in a  dataset the return field is blank", ((string[])(null)));
#line 68
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
            table9.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table9.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table9.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table9.AddRow(new string[] {
                        "rs().row",
                        "3"});
#line 69
 testRunner.Given("I have the following duplicated recordset", ((string)(null)), table9, "Given ");
#line 75
 testRunner.And("I want to find unique in field \"[[rs().row]]\" with the return field \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("The result variable is \"[[rec().unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec",
                        "unique"});
#line 78
 testRunner.Then("the unique result will be", ((string)(null)), table10, "Then ");
#line 80
 testRunner.And("the unique execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records using a negative recordset index for In Field")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsUsingANegativeRecordsetIndexForInField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records using a negative recordset index for In Field", ((string[])(null)));
#line 82
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
            table11.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table11.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table11.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table11.AddRow(new string[] {
                        "rs().row",
                        "3"});
#line 83
 testRunner.Given("I have the following duplicated recordset", ((string)(null)), table11, "Given ");
#line 89
 testRunner.And("I want to find unique in field \"[[rs(-1).row]]\" with the return field \"[[rs().row" +
                    "]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("The result variable is \"[[rec().unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec",
                        "unique"});
#line 92
 testRunner.Then("the unique result will be", ((string)(null)), table12, "Then ");
#line 94
 testRunner.And("the unique execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records using a * for In Field")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsUsingAForInField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records using a * for In Field", ((string[])(null)));
#line 96
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
            table13.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table13.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table13.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table13.AddRow(new string[] {
                        "rs().row",
                        "3"});
#line 97
 testRunner.Given("I have the following duplicated recordset", ((string)(null)), table13, "Given ");
#line 103
 testRunner.And("I want to find unique in field \"[[rs(*).row]]\" with the return field \"[[rs().row]" +
                    "]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("The result variable is \"[[rec().unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec",
                        "unique"});
            table14.AddRow(new string[] {
                        "rec().unique",
                        "1"});
            table14.AddRow(new string[] {
                        "rec().unique",
                        "2"});
            table14.AddRow(new string[] {
                        "rec().unique",
                        "3"});
#line 106
 testRunner.Then("the unique result will be", ((string)(null)), table14, "Then ");
#line 111
 testRunner.And("the unique execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records using a negative recordset index for Return Field")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsUsingANegativeRecordsetIndexForReturnField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records using a negative recordset index for Return Field", ((string[])(null)));
#line 113
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
            table15.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table15.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table15.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table15.AddRow(new string[] {
                        "rs().row",
                        "3"});
#line 114
 testRunner.Given("I have the following duplicated recordset", ((string)(null)), table15, "Given ");
#line 120
 testRunner.And("I want to find unique in field \"[[rs().row]]\" with the return field \"[[rs(-1).row" +
                    "]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("The result variable is \"[[rec().unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec",
                        "unique"});
#line 123
 testRunner.Then("the unique result will be", ((string)(null)), table16, "Then ");
#line 125
 testRunner.And("the unique execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Find unique records using a * for Return Field")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Unique")]
        public virtual void FindUniqueRecordsUsingAForReturnField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find unique records using a * for Return Field", ((string[])(null)));
#line 127
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "val"});
            table17.AddRow(new string[] {
                        "rs().row",
                        "1"});
            table17.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table17.AddRow(new string[] {
                        "rs().row",
                        "2"});
            table17.AddRow(new string[] {
                        "rs().row",
                        "3"});
#line 128
 testRunner.Given("I have the following duplicated recordset", ((string)(null)), table17, "Given ");
#line 134
 testRunner.And("I want to find unique in field \"[[rs().row]]\" with the return field \"[[rs(*).row]" +
                    "]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("The result variable is \"[[rec().unique]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.When("the unique tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec",
                        "unique"});
            table18.AddRow(new string[] {
                        "rec().unique",
                        "1"});
            table18.AddRow(new string[] {
                        "rec().unique",
                        "2"});
            table18.AddRow(new string[] {
                        "rec().unique",
                        "3"});
#line 137
 testRunner.Then("the unique result will be", ((string)(null)), table18, "Then ");
#line 142
 testRunner.And("the unique execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
