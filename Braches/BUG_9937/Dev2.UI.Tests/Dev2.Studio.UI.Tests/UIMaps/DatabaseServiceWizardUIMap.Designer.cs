﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Threading;
using Dev2.CodedUI.Tests;
using Dev2.CodedUI.Tests.UIMaps.RibbonUIMapClasses;

namespace Dev2.Studio.UI.Tests.UIMaps.DatabaseServiceWizardUIMapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public partial class DatabaseServiceWizardUIMap
    {
        
        /// <summary>
        /// NewDbSource
        /// </summary>
        public void NewDbSource()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(343, 82));
        }
        
        /// <summary>
        /// ClickFirstAction
        /// </summary>
        public void ClickFirstAction()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(172, 164));
        }
        
        /// <summary>
        /// ClickTestAction
        /// </summary>
        public void ClickTestAction()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(889, 84));
        }
        
        /// <summary>
        /// ClickOK
        /// </summary>
        public void ClickOK()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(767, 523));
        }

        /// <summary>
        /// DatabaseServiceClickCancel
        /// </summary>
        public void DatabaseServiceClickCancel()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Keyboard.SendKeys("{TAB}{TAB}{ENTER}");
            //Mouse.Click(uIItemImage, new Point(874, 533));
        }

        public void InitializeFullTestServiceAndSource(string serverAndSourceCategoryName, string serverAndSourceName)
        {
            //DbSource
            Keyboard.SendKeys("{CTRL}{SHIFT}D");
            Thread.Sleep(1000);
            Keyboard.SendKeys("{TAB}{TAB}{ENTER}");
            Thread.Sleep(10);
            Keyboard.SendKeys("RSAKLFSVRGENDEV");
            Thread.Sleep(10);
            Keyboard.SendKeys("{TAB}{RIGHT}{TAB}");
            Thread.Sleep(10);
            Keyboard.SendKeys("testuser");
            Thread.Sleep(10);
            Keyboard.SendKeys("{TAB}");
            Thread.Sleep(10);
            Keyboard.SendKeys("test123");
            Thread.Sleep(10);
            Keyboard.SendKeys("{TAB}{ENTER}");
            Thread.Sleep(1000);
            Keyboard.SendKeys("{TAB}{DOWN}{TAB}{ENTER}{ENTER}");
            Thread.Sleep(10);
            Keyboard.SendKeys(serverAndSourceCategoryName);
            Thread.Sleep(10);
            Keyboard.SendKeys("{ENTER}");
            Thread.Sleep(1000);
            Keyboard.SendKeys("{TAB}{TAB}{TAB}");
            Thread.Sleep(10);
            Keyboard.SendKeys(serverAndSourceName);
            Thread.Sleep(10);
            Keyboard.SendKeys("{ENTER}");
            Thread.Sleep(1000);
            //DbService
            ClickFirstAction();
            ClickTestAction();
            ClickOK();
            Keyboard.SendKeys("{ENTER}");
            Thread.Sleep(10);
            Keyboard.SendKeys(serverAndSourceCategoryName);
            Thread.Sleep(10);
            Keyboard.SendKeys("{ENTER}{TAB}{TAB}{TAB}");
            Thread.Sleep(10);
            Keyboard.SendKeys(serverAndSourceName);
            Thread.Sleep(10);
            Keyboard.SendKeys("{ENTER}");
        }

        public void TabToOutputMappings(UITestControl control)
        {
            Keyboard.SendKeys(control, "{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}");
            Keyboard.SendKeys(control, "{RIGHT}");
            Keyboard.SendKeys(control, "{TAB}{TAB}{TAB}{TAB}");
        }
         
        public bool IsControlADbServiceWizard(UITestControl wizardWindow)
        {
            return (wizardWindow.ControlType == ControlType.Window && wizardWindow.BoundingRectangle.Width > 900 && wizardWindow.BoundingRectangle.Width < 1000 && wizardWindow.BoundingRectangle.Height > 500 && wizardWindow.BoundingRectangle.Height < 600);
        }

        public void SaveDialogClickFirstFolder()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(467, 149));
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIBusinessDesignStudioWindow : WpfWindow
    {
        
        public UIBusinessDesignStudioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.Name, "Warewolf", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UIZ5bc03f5226434284a36Custom UIZ5bc03f5226434284a36Custom
        {
            get
            {
                if ((this.mUIZ5bc03f5226434284a36Custom == null))
                {
                    this.mUIZ5bc03f5226434284a36Custom = new UIZ5bc03f5226434284a36Custom(this);
                }
                return this.mUIZ5bc03f5226434284a36Custom;
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
                    this.mUIItemImage.WindowTitles.Add(TestBase.GetStudioWindowName());
                    #endregion
                }
                return this.mUIItemImage;
            }
        }
        #endregion
        
        #region Fields
        private UIZ5bc03f5226434284a36Custom mUIZ5bc03f5226434284a36Custom;
        
        private WpfImage mUIItemImage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIZ5bc03f5226434284a36Custom : WpfCustom
    {
        
        public UIZ5bc03f5226434284a36Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.SplitPane";
            this.SearchProperties["AutomationId"] = "Z5bc03f5226434284a364fdd8116a4038";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public UIUI_TabManager_AutoIDTabList UIUI_TabManager_AutoIDTabList
        {
            get
            {
                if ((this.mUIUI_TabManager_AutoIDTabList == null))
                {
                    this.mUIUI_TabManager_AutoIDTabList = new UIUI_TabManager_AutoIDTabList(this);
                }
                return this.mUIUI_TabManager_AutoIDTabList;
            }
        }
        #endregion
        
        #region Fields
        private UIUI_TabManager_AutoIDTabList mUIUI_TabManager_AutoIDTabList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIUI_TabManager_AutoIDTabList : WpfTabList
    {
        
        public UIUI_TabManager_AutoIDTabList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "UI_TabManager_AutoID";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public UIStartPageTabPage UIStartPageTabPage
        {
            get
            {
                if ((this.mUIStartPageTabPage == null))
                {
                    this.mUIStartPageTabPage = new UIStartPageTabPage(this);
                }
                return this.mUIStartPageTabPage;
            }
        }
        #endregion
        
        #region Fields
        private UIStartPageTabPage mUIStartPageTabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIStartPageTabPage : WpfTabPage
    {
        
        public UIStartPageTabPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.Name] = "Start Page";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public UIStartPageCustom UIStartPageCustom
        {
            get
            {
                if ((this.mUIStartPageCustom == null))
                {
                    this.mUIStartPageCustom = new UIStartPageCustom(this);
                }
                return this.mUIStartPageCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIStartPageCustom mUIStartPageCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIStartPageCustom : WpfCustom
    {
        
        public UIStartPageCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.ContentPane";
            this.SearchProperties["AutomationId"] = "splurt";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public WpfImage UIItemImage
        {
            get
            {
                if ((this.mUIItemImage == null))
                {
                    this.mUIItemImage = new WpfImage(this);
                    #region Search Criteria
                    this.mUIItemImage.WindowTitles.Add(TestBase.GetStudioWindowName());
                    #endregion
                }
                return this.mUIItemImage;
            }
        }
        #endregion
        
        #region Fields
        private WpfImage mUIItemImage;
        #endregion
    }
}
