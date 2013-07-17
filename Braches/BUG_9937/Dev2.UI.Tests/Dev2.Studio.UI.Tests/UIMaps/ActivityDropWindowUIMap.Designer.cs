﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Linq;

namespace Dev2.Studio.UI.Tests.UIMaps.ActivityDropWindowUIMapClasses
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
    public partial class ActivityDropWindowUIMap
    {

        /// <summary>
        /// ClickOkButton
        /// </summary>
        public void ClickOkButton()
        {
            #region Variable Declarations
            WpfButton uIOKButton = this.UIWorkflowWindow.UIOKButton;
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(79, 11));
        }

        /// <summary>
        /// ClickCancelButton
        /// </summary>
        public void ClickCancelButton()
        {
            #region Variable Declarations
            WpfButton uICancelButton = this.UIWorkflowWindow.UICancelButton;
            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(64, 7));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UITestControl GetOkButtonOnActivityDropWindow()
        {
            UITestControl buttonControl = null;
            var children = this.UIWorkflowWindow.GetChildren();
            buttonControl = children.FirstOrDefault(c => c.FriendlyName == "OK");

            return buttonControl;
        }

        /// <summary>
        /// SingleClickAFolder
        /// </summary>
        public void SingleClickAFolder()
        {
            #region Variable Declarations
            WpfTreeItem uIDev2StudioViewModelsTreeItem1 = this.UIWorkflowWindow.UITheNavigationViewCustom.UITvExplorerTree.UIDev2StudioViewModelsTreeItem.UIDev2StudioViewModelsTreeItem1.UIDev2StudioViewModelsTreeItem;
            #endregion

            // Click 'Dev2.Studio.ViewModels.Navigation.EnvironmentTreeV...' -> 'Dev2.Studio.ViewModels.Navigation.ServiceTypeTreeV...' -> 'Dev2.Studio.ViewModels.Navigation.CategoryTreeView...' tree item
            Mouse.Click(uIDev2StudioViewModelsTreeItem1, new Point(57, 9));
        }

        /// <summary>
        /// SingleClickAResource
        /// </summary>
        public void SingleClickAResource()
        {
            #region Variable Declarations
            WpfTreeItem uIDev2StudioViewModelsTreeItem1 = this.UIWorkflowWindow.UITheNavigationViewCustom.UITvExplorerTree.UIDev2StudioViewModelsTreeItem.UIDev2StudioViewModelsTreeItem1.UIDev2StudioViewModelsTreeItem.UIDev2StudioViewModelsTreeItem1;
            #endregion

            // Double-Click 'Dev2.Studio.ViewModels.Navigation.EnvironmentTreeV...' -> 'Dev2.Studio.ViewModels.Navigation.ServiceTypeTreeV...' -> 'Dev2.Studio.ViewModels.Navigation.CategoryTreeView...' -> 'Dev2.Studio.ViewModels.Navigation.ResourceTreeView...' tree item
            Mouse.Click(uIDev2StudioViewModelsTreeItem1, new Point(73, 9));
        }

        /// <summary>
        /// DoubleClickAFolder
        /// </summary>
        public void DoubleClickAFolder()
        {
            #region Variable Declarations
            WpfTreeItem uIDev2StudioViewModelsTreeItem1 = this.UIWorkflowWindow.UITheNavigationViewCustom.UITvExplorerTree.UIDev2StudioViewModelsTreeItem.UIDev2StudioViewModelsTreeItem1.UIDev2StudioViewModelsTreeItem;
            #endregion

            // Click 'Dev2.Studio.ViewModels.Navigation.EnvironmentTreeV...' -> 'Dev2.Studio.ViewModels.Navigation.ServiceTypeTreeV...' -> 'Dev2.Studio.ViewModels.Navigation.CategoryTreeView...' tree item
            Mouse.DoubleClick(uIDev2StudioViewModelsTreeItem1, new Point(57, 9));
        }
        
        /// <summary>
        /// DoubleClickAResource
        /// </summary>
        public void DoubleClickAResource()
        {
            #region Variable Declarations
            WpfTreeItem uIDev2StudioViewModelsTreeItem1 = this.UIWorkflowWindow.UITheNavigationViewCustom.UITvExplorerTree.UIDev2StudioViewModelsTreeItem.UIDev2StudioViewModelsTreeItem1.UIDev2StudioViewModelsTreeItem.UIDev2StudioViewModelsTreeItem1;
            #endregion

            // Double-Click 'Dev2.Studio.ViewModels.Navigation.EnvironmentTreeV...' -> 'Dev2.Studio.ViewModels.Navigation.ServiceTypeTreeV...' -> 'Dev2.Studio.ViewModels.Navigation.CategoryTreeView...' -> 'Dev2.Studio.ViewModels.Navigation.ResourceTreeView...' tree item
            Mouse.DoubleClick(uIDev2StudioViewModelsTreeItem1, new Point(73, 9));
        }
        
        #region Properties
        public UIWorkflowWindow UIWorkflowWindow
        {
            get
            {
                if ((this.mUIWorkflowWindow == null))
                {
                    this.mUIWorkflowWindow = new UIWorkflowWindow();
                }
                return this.mUIWorkflowWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIWorkflowWindow mUIWorkflowWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIWorkflowWindow : WpfWindow
    {
        
        public UIWorkflowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Workflow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Workflow");
            #endregion
        }
        
        #region Properties
        public UITheNavigationViewCustom UITheNavigationViewCustom
        {
            get
            {
                if ((this.mUITheNavigationViewCustom == null))
                {
                    this.mUITheNavigationViewCustom = new UITheNavigationViewCustom(this);
                }
                return this.mUITheNavigationViewCustom;
            }
        }

        public WpfButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WpfButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("Workflow");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }

        public WpfButton UICancelButton
        {
            get
            {
                if ((this.mUICancelButton == null))
                {
                    this.mUICancelButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUICancelButton.SearchProperties[WpfButton.PropertyNames.Name] = "Cancel";
                    this.mUICancelButton.WindowTitles.Add("Workflow");
                    #endregion
                }
                return this.mUICancelButton;
            }
        }       

        #endregion
        
        #region Fields
        private UITheNavigationViewCustom mUITheNavigationViewCustom;
        private WpfButton mUIOKButton;
        private WpfButton mUICancelButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITheNavigationViewCustom : WpfCustom
    {
        
        public UITheNavigationViewCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.NavigationView";
            this.SearchProperties["AutomationId"] = "TheNavigationView";
            this.WindowTitles.Add("Workflow");
            #endregion
        }
        
        #region Properties
        public UITvExplorerTree UITvExplorerTree
        {
            get
            {
                if ((this.mUITvExplorerTree == null))
                {
                    this.mUITvExplorerTree = new UITvExplorerTree(this);
                }
                return this.mUITvExplorerTree;
            }
        }
        #endregion
        
        #region Fields
        private UITvExplorerTree mUITvExplorerTree;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITvExplorerTree : WpfTree
    {
        
        public UITvExplorerTree(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTree.PropertyNames.AutomationId] = "tvExplorer";
            this.WindowTitles.Add("Workflow");
            #endregion
        }
        
        #region Properties
        public UIDev2StudioViewModelsTreeItem UIDev2StudioViewModelsTreeItem
        {
            get
            {
                if ((this.mUIDev2StudioViewModelsTreeItem == null))
                {
                    this.mUIDev2StudioViewModelsTreeItem = new UIDev2StudioViewModelsTreeItem(this);
                }
                return this.mUIDev2StudioViewModelsTreeItem;
            }
        }
        #endregion
        
        #region Fields
        private UIDev2StudioViewModelsTreeItem mUIDev2StudioViewModelsTreeItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDev2StudioViewModelsTreeItem : WpfTreeItem
    {
        
        public UIDev2StudioViewModelsTreeItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTreeItem.PropertyNames.AutomationId] = "UI_localhost (http://127.0.0.1:77/dsf)_AutoID";
            this.WindowTitles.Add("Workflow");
            #endregion
        }
        
        #region Properties
        public UIDev2StudioViewModelsTreeItem1 UIDev2StudioViewModelsTreeItem1
        {
            get
            {
                if ((this.mUIDev2StudioViewModelsTreeItem1 == null))
                {
                    this.mUIDev2StudioViewModelsTreeItem1 = new UIDev2StudioViewModelsTreeItem1(this);
                }
                return this.mUIDev2StudioViewModelsTreeItem1;
            }
        }
        #endregion
        
        #region Fields
        private UIDev2StudioViewModelsTreeItem1 mUIDev2StudioViewModelsTreeItem1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDev2StudioViewModelsTreeItem1 : WpfTreeItem
    {
        
        public UIDev2StudioViewModelsTreeItem1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTreeItem.PropertyNames.AutomationId] = "UI_WORKFLOWS_AutoID";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Workflow");
            #endregion
        }
        
        #region Properties
        public UIDev2StudioViewModelsTreeItem2 UIDev2StudioViewModelsTreeItem
        {
            get
            {
                if ((this.mUIDev2StudioViewModelsTreeItem == null))
                {
                    this.mUIDev2StudioViewModelsTreeItem = new UIDev2StudioViewModelsTreeItem2(this);
                }
                return this.mUIDev2StudioViewModelsTreeItem;
            }
        }
        #endregion
        
        #region Fields
        private UIDev2StudioViewModelsTreeItem2 mUIDev2StudioViewModelsTreeItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDev2StudioViewModelsTreeItem2 : WpfTreeItem
    {
        
        public UIDev2StudioViewModelsTreeItem2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTreeItem.PropertyNames.AutomationId] = "UI_MO_AutoID";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Workflow");
            #endregion
        }
        
        #region Properties
        public WpfTreeItem UIDev2StudioViewModelsTreeItem1
        {
            get
            {
                if ((this.mUIDev2StudioViewModelsTreeItem1 == null))
                {
                    this.mUIDev2StudioViewModelsTreeItem1 = new WpfTreeItem(this);
                    #region Search Criteria
                    this.mUIDev2StudioViewModelsTreeItem1.SearchProperties[WpfTreeItem.PropertyNames.AutomationId] = "UI_fileTest_AutoID";
                    this.mUIDev2StudioViewModelsTreeItem1.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIDev2StudioViewModelsTreeItem1.WindowTitles.Add("Workflow");
                    #endregion
                }
                return this.mUIDev2StudioViewModelsTreeItem1;
            }
        }
        #endregion
        
        #region Fields
        private WpfTreeItem mUIDev2StudioViewModelsTreeItem1;
        #endregion
    }
}
