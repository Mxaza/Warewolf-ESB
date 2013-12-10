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
namespace Dev2.Activities.Specs.Toolbox.Data.DataSplit
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DataSplitFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DataSplit.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DataSplit", "In order to split data\r\nAs a Warewolf user\r\nI want a tool that splits two or more" +
                    " pieces of data", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "DataSplit")))
            {
                Dev2.Activities.Specs.Toolbox.Data.DataSplit.DataSplitFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text to a recordset using Index")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextToARecordsetUsingIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text to a recordset using Index", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("A string to split with value \"abcde\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Index\" at \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().letters"});
            table1.AddRow(new string[] {
                        "a"});
            table1.AddRow(new string[] {
                        "b"});
            table1.AddRow(new string[] {
                        "c"});
            table1.AddRow(new string[] {
                        "d"});
            table1.AddRow(new string[] {
                        "e"});
#line 10
 testRunner.Then("the split result will be", ((string)(null)), table1, "Then ");
#line 17
 testRunner.And("the data split execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split characters using Index Going Backwards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitCharactersUsingIndexGoingBackwards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split characters using Index Going Backwards", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("A string to split with value \"@!?><\":}{+_)(*&^~\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And("assign to variable \"[[vowels(*).chars]]\" split type \"Index\" at \"7\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().chars"});
            table2.AddRow(new string[] {
                        "_)(*&^~"});
            table2.AddRow(new string[] {
                        "><\":}{+"});
            table2.AddRow(new string[] {
                        "@!?"});
#line 23
 testRunner.Then("the split result will be", ((string)(null)), table2, "Then ");
#line 28
 testRunner.And("the data split execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text using All split types - Some with Include selected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextUsingAllSplitTypes_SomeWithIncludeSelected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text using All split types - Some with Include selected", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("A string to split with value \"IndexTab\tChars,space end\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Index\" at \"5\" and Include \"" +
                    "Selected\" and Escape \"\\\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Tab\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type as \"Chars\" at \"ars,\" and esc" +
                    "ape \"\" and include is \"unselected\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type as \"Space\" at \"1\" and escape" +
                    " \"\\\" and include is \"unselected\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"End\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().letters"});
            table3.AddRow(new string[] {
                        "Index"});
            table3.AddRow(new string[] {
                        "Tab"});
            table3.AddRow(new string[] {
                        "Chars,"});
            table3.AddRow(new string[] {
                        "space"});
            table3.AddRow(new string[] {
                        "end"});
#line 38
 testRunner.Then("the split result will be", ((string)(null)), table3, "Then ");
#line 45
 testRunner.And("the data split execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split CSV file format into recordset - some fields blank")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitCSVFileFormatIntoRecordset_SomeFieldsBlank()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split CSV file format into recordset - some fields blank", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("A file \"CSVExample.txt\" to split", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("assign to variable \"[[rec().id]]\" split type \"Chars\" at \",\" and Include \"Unselect" +
                    "ed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("assign to variable \"[[rec().name]]\" split type \"Chars\" at \",\" and Include \"Unsele" +
                    "cted\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("assign to variable \"\" split type as \"Chars\" at \",\" and escape \"\" and include is \"" +
                    "unselected\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("assign to variable \"[[rec().phone]]\" split type \"NewLine\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("assign to variable \"\" split type as \"\" at \"\" and escape \"\" and include is \"unsele" +
                    "cted\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec().id",
                        "rec().name",
                        "rec().phone"});
            table4.AddRow(new string[] {
                        "ID",
                        "NAME",
                        "PHONE"});
            table4.AddRow(new string[] {
                        "1",
                        "Barney",
                        "1234"});
            table4.AddRow(new string[] {
                        "2",
                        "Tshepo",
                        "5678"});
            table4.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table4.AddRow(new string[] {
                        "3",
                        "Mo",
                        ""});
#line 56
 testRunner.Then("the split result will be", ((string)(null)), table4, "Then ");
#line 63
 testRunner.And("the data split execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split CSV file format into recordset - Skip blank rows selected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitCSVFileFormatIntoRecordset_SkipBlankRowsSelected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split CSV file format into recordset - Skip blank rows selected", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 66
 testRunner.Given("A file \"CSVExample.txt\" to split", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
 testRunner.And("assign to variable \"[[rec().id]]\" split type \"Chars\" at \",\" and Include \"Unselect" +
                    "ed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("assign to variable \"[[rec().name]]\" split type \"Chars\" at \",\" and Include \"Unsele" +
                    "cted\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("assign to variable \"\" split type \"Chars\" at \",\" and Include \"Unselected\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("assign to variable \"[[rec().phone]]\" split type \"NewLine\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("assign to variable \"\" split type as \"\" at \"\" and escape \"\" and include is \"select" +
                    "ed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec().id",
                        "rec().name",
                        "rec().phone"});
            table5.AddRow(new string[] {
                        "ID",
                        "NAME",
                        "PHONE"});
            table5.AddRow(new string[] {
                        "1",
                        "Barney",
                        "1234"});
            table5.AddRow(new string[] {
                        "2",
                        "Tshepo",
                        "5678"});
            table5.AddRow(new string[] {
                        "3",
                        "Mo",
                        "01"});
#line 73
 testRunner.Then("the split result will be", ((string)(null)), table5, "Then ");
#line 79
 testRunner.And("the data split execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split blank text using All split types")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitBlankTextUsingAllSplitTypes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split blank text using All split types", ((string[])(null)));
#line 81
this.ScenarioSetup(scenarioInfo);
#line 82
 testRunner.Given("A string to split with value \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Index\" at \"5\" and Include \"" +
                    "Selected\" and Escape \"\\\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Tab\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Chars\" at \"ars,\" and Includ" +
                    "e \"Selected\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type as \"Space\" at \"\" and escape " +
                    "\"\\\" and include is \"unselected\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"End\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"NewLine\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().letters"});
#line 90
 testRunner.Then("the split result will be", ((string)(null)), table6, "Then ");
#line 92
 testRunner.And("the data split execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text using Index where index > provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextUsingIndexWhereIndexProvided()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text using Index where index > provided", ((string[])(null)));
#line 94
this.ScenarioSetup(scenarioInfo);
#line 95
 testRunner.Given("A string to split with value \"123\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 96
 testRunner.And("assign to variable \"[[var]]\" split type \"Index\" at \"5\" and Include \"Selected\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.Then("the split result for \"[[var]]\" will be \"123\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.And("the data split execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text using Char and Escape character")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextUsingCharAndEscapeCharacter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text using Char and Escape character", ((string[])(null)));
#line 101
this.ScenarioSetup(scenarioInfo);
#line 102
 testRunner.Given("A string to split with value \"123|,45,1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 103
 testRunner.And("assign to variable \"[[var]]\" split type \"Chars\" at \",\" and Include \"Unselected\" a" +
                    "nd Escape \"|\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Then("the split result for \"[[var]]\" will be \"123|,45\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.And("the data split execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
