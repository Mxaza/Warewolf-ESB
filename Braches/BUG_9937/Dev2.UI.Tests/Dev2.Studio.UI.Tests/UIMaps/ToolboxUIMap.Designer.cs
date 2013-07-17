﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using Dev2.Studio.UI.Tests;

namespace Dev2.CodedUI.Tests.UIMaps.ToolboxUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;


    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIWarewolfWindow : WpfWindow
    {

        public UIWarewolfWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Warewolf";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Warewolf");
            #endregion
        }

        #region Properties
        public UIUI_DocManager_AutoIDCustom1 UIUI_DocManager_AutoIDCustom
        {
            get
            {
                if ((this.mUIUI_DocManager_AutoIDCustom == null))
                {
                    this.mUIUI_DocManager_AutoIDCustom = new UIUI_DocManager_AutoIDCustom1(this);
                }
                return this.mUIUI_DocManager_AutoIDCustom;
            }
        }

        public UIItemCustom3 UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new UIItemCustom3(this);
                }
                return this.mUIItemCustom;
            }
        }

        public UIActivityBuilderCustom2 UIActivityBuilderCustom
        {
            get
            {
                if ((this.mUIActivityBuilderCustom == null))
                {
                    this.mUIActivityBuilderCustom = new UIActivityBuilderCustom2(this);
                }
                return this.mUIActivityBuilderCustom;
            }
        }

        public WpfImage UIItemImage
        {
            get
            {
                if ((this.mUIItemImage == null))
                {
                    this.mUIItemImage = new WpfImage(this);
                    #region Search Criteria
                    this.mUIItemImage.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mUIItemImage;
            }
        }

        public UIItemCustom12 UIItemCustom1
        {
            get
            {
                if ((this.mUIItemCustom1 == null))
                {
                    this.mUIItemCustom1 = new UIItemCustom12(this);
                }
                return this.mUIItemCustom1;
            }
        }
        #endregion

        #region Fields
        private UIUI_DocManager_AutoIDCustom1 mUIUI_DocManager_AutoIDCustom;

        private UIItemCustom3 mUIItemCustom;

        private UIActivityBuilderCustom2 mUIActivityBuilderCustom;

        private WpfImage mUIItemImage;

        private UIItemCustom12 mUIItemCustom1;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class ToolboxUIMap
    {

        private Studio.UI.Tests.UIWarewolfWindow mUIWarewolfWindow;

        public Studio.UI.Tests.UIWarewolfWindow UIWarewolfWindow
        {
            get
            {
                if ((this.mUIWarewolfWindow == null))
                {
                    this.mUIWarewolfWindow = new Studio.UI.Tests.UIWarewolfWindow();
                }
                return this.mUIWarewolfWindow;
            }
        }

        /// <summary>
        /// ClickDecision
        /// </summary>
        public UITestControl FindControl(string itemAutomationID)
        {

            #region Variable Declarations
            //WpfTabPage uIToolboxTabPage = this.UIWarewolfWindow.UIUI_DocManager_AutoIDCustom.UIPART_UnpinnedTabAreaTabList.UIToolboxTabPage;
            //WpfText uIDecisionText1 = this.UIWarewolfWindow.UIItemCustom.UIPART_ToolsTree.UIControlFlowTreeItem.UIUnlimitedApplicationTreeItem.UIDecisionText.UIDecisionText1;
            //WpfTreeItem uIUnlimitedApplicationTreeItem = this.UIWarewolfWindow.UIItemCustom.UIPART_ToolsTree.UIControlFlowTreeItem.UIUnlimitedApplicationTreeItem;
            //WpfCustom uIFlowchartCustom = this.UIWarewolfWindow.UIActivityBuilderCustom.UIWorkflowItemPresenteCustom.UIFlowchartCustom;
            //WpfImage uIItemImage = this.UIWarewolfWindow.UIItemImage;
            //WpfPane uIScrollViewerPane = this.UIWarewolfWindow.UIItemCustom1.UIUserControl_1Custom.UIScrollViewerPane;
            #endregion


            var toolTree = this.UIWarewolfWindow.UIItemCustom.UIPART_ToolsTree;

            var kids = toolTree.GetChildren();

            foreach (var kid in kids)
            {
                // Now process to find the correct item ;)

                var innerKids = kid.GetChildren();

                foreach (var innerKid in innerKids)
                {
                    string autoID = innerKid.GetProperty("AutomationID").ToString();
                    if (autoID.Contains(itemAutomationID))
                    {
                        return innerKid;
                    }    
                }
            }



            /*
             * Find the list of items and locate the correct item from here ;)
             * 
             * 
             */

            // Click 'Toolbox' tab
            //Mouse.Click(uIToolboxTabPage, new Point(25, 41));

            // Click 'Decision' label
            //Mouse.Click(uIDecisionText1, new Point(4, 7));

            // Move 'Control Flow' -> 'Unlimited.Applications.BusinessDesignStudio.Activi...' tree item to 'Flowchart' custom control
            //uIFlowchartCustom.EnsureClickable(new Point(306, 125));

            //// Much faster! \o/
            //UITestControl dockManager = this.UIBusinessDesignStudioWindow.UIDockManagerCustom;
            //dockManager.Find();
            //WpfCustom uIToolboxCustom = new WpfCustom(dockManager);

            //uIToolboxCustom.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "PART_UnpinnedTabAreaLeft";
            //uIToolboxCustom.WindowTitles.Add("Warewolf");

            ////uIToolboxCustom.SearchProperties["ControlType"] = "TabPage";
            ////uIToolboxCustom.SearchProperties["Name"] = "Toolbox";
            //uIToolboxCustom.Find();
            //UITestControlCollection childCollection = uIToolboxCustom.GetChildren();

            //UITestControlCollection uiTestControlCollection = childCollection[2].GetChildren();

            //UITestControlCollection uiTestControlCollection1 = uiTestControlCollection[6].GetChildren();

            //UITestControlCollection testControlCollection = uiTestControlCollection1[1].GetChildren();

            //foreach (UITestControl subItem in testControlCollection)
            //{
            //    string friendlyName = subItem.FriendlyName;
            //    if (subItem.GetChildren().Count > 0)
            //    {
            //        UITestControlCollection subChildCollection = subItem.GetChildren();
            //        foreach (UITestControl subSubItem in subChildCollection)
            //        {
            //            string autoID = subSubItem.GetProperty("AutomationID").ToString();
            //            if (autoID.Contains(itemAutomationID))
            //            {
            //                return subSubItem;
            //            }
            //        }
            //    }
            //}

            return null;
        }

        #region Properties
        public UIBusinessDesignStudioWindow UIBusinessDesignStudioWindow
        {
            get
            {
                if ((this.mUIBusinessDesignStudioWindow == null))
                {
                    this.mUIBusinessDesignStudioWindow = new UIBusinessDesignStudioWindow();
                }
                return this.mUIBusinessDesignStudioWindow;
            }
        }
        #endregion

        #region Fields
        private UIBusinessDesignStudioWindow mUIBusinessDesignStudioWindow;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIBusinessDesignStudioWindow : WpfWindow
    {

        public UIBusinessDesignStudioWindow()
        {
            #region Search Criteria

            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Warewolf";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Warewolf");

            #endregion
        }

        #region Properties
        public UIItemCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new UIItemCustom(this);
                }
                return this.mUIItemCustom;
            }
        }

        public UITestControl UIDockManagerCustom
        {
            get
            {
                if ((this.mUIDockManagerCustom == null))
                {
                    this.mUIDockManagerCustom = new UITestControl(this);
                    this.mUIDockManagerCustom.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.XamDockManager";
                    this.mUIDockManagerCustom.SearchProperties["AutomationId"] = "UI_DocManager_AutoID";
                    this.mUIDockManagerCustom.WindowTitles.Add("Warewolf");
                    //this.mUIDockManagerCustom.Find();
                }
                return this.mUIDockManagerCustom;
            }
        }
        #endregion

        #region Fields
        private UIItemCustom mUIItemCustom;
        private UITestControl mUIDockManagerCustom;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIItemCustom : WpfCustom
    {

        public UIItemCustom(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.ToolboxUserControl";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }

        #region Properties
        public UIPART_ToolsTree UIPART_ToolsTree
        {
            get
            {
                if ((this.mUIPART_ToolsTree == null))
                {
                    this.mUIPART_ToolsTree = new UIPART_ToolsTree(this);
                }
                return this.mUIPART_ToolsTree;
            }
        }
        #endregion

        #region Fields
        private UIPART_ToolsTree mUIPART_ToolsTree;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIPART_ToolsTree : WpfTree
    {

        public UIPART_ToolsTree(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTree.PropertyNames.AutomationId] = "PART_Tools";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }

        #region Properties
        public UIControlFlowTreeItem UIControlFlowTreeItem
        {
            get
            {
                if ((this.mUIControlFlowTreeItem == null))
                {
                    this.mUIControlFlowTreeItem = new UIControlFlowTreeItem(this);
                }
                return this.mUIControlFlowTreeItem;
            }
        }
        #endregion

        #region Fields
        private UIControlFlowTreeItem mUIControlFlowTreeItem;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIControlFlowTreeItem : WpfTreeItem
    {

        public UIControlFlowTreeItem(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTreeItem.PropertyNames.AutomationId] = "Control Flow";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }

        #region Properties
        public UIUnlimitedApplicationTreeItem UIUnlimitedApplicationTreeItem
        {
            get
            {
                if ((this.mUIUnlimitedApplicationTreeItem == null))
                {
                    this.mUIUnlimitedApplicationTreeItem = new UIUnlimitedApplicationTreeItem(this);
                }
                return this.mUIUnlimitedApplicationTreeItem;
            }
        }
        #endregion

        #region Fields
        private UIUnlimitedApplicationTreeItem mUIUnlimitedApplicationTreeItem;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIUnlimitedApplicationTreeItem : WpfTreeItem
    {

        public UIUnlimitedApplicationTreeItem(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
            string theID = this.AutomationId;
        }

        #region Properties
        public UIDecisionText UIDecisionText
        {
            get
            {
                if ((this.mUIDecisionText == null))
                {
                    this.mUIDecisionText = new UIDecisionText(this);
                }
                return this.mUIDecisionText;
            }
        }
        #endregion

        #region Fields
        private UIDecisionText mUIDecisionText;
        #endregion
    }

    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIDecisionText : WpfText
    {

        public UIDecisionText(UITestControl searchLimitContainer) :
            base(searchLimitContainer)
        {
            #region Search Criteria
            //this.SearchProperties[WpfText.PropertyNames.Name] = "Decision";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }

        #region Properties
        public WpfText UIDecisionText1(string itemName)
        {
            //get
            {
                //if ((this.mUIDecisionText1 == null))
                {
                    this.mUIDecisionText1 = new WpfText(this);
                    #region Search Criteria
                    this.mUIDecisionText1.SearchProperties[WpfText.PropertyNames.Name] = itemName;
                    this.mUIDecisionText1.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIDecisionText1.SearchConfigurations.Add(SearchConfiguration.DisambiguateChild);
                    this.mUIDecisionText1.WindowTitles.Add(TestBase.GetStudioWindowName());
                    #endregion
                }
                return this.mUIDecisionText1;
            }
        }
        #endregion

        #region Fields
        private WpfText mUIDecisionText1;
        #endregion
    }
}
