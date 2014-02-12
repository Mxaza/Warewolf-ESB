﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Text;
using System.Threading;
using System.Windows.Forms;
using Dev2.CodedUI.Tests;
using Dev2.CodedUI.Tests.UIMaps.DocManagerUIMapClasses;
using Dev2.CodedUI.Tests.UIMaps.ExplorerUIMapClasses;
using Dev2.CodedUI.Tests.UIMaps.RibbonUIMapClasses;

namespace Dev2.Studio.UI.Tests.UIMaps.WebServiceWizardUIMapClasses
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

    public partial class WebServiceWizardUIMap : UIMapBase
    {
        /// <summary>
        /// ClickFirstAction
        /// </summary>
        public void ClickMappingTab(int x = 280)
        {
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            Playback.Wait(500);
            Mouse.Click(uIItemImage, new Point(x, 25));
        }

        public void EnterDataIntoMappingTextBox(int textboxNumber, string newMappingText)
        {
            for(int i = 0; i <= textboxNumber; i++)
            {
                SendKeys.SendWait("{TAB}");
                Playback.Wait(50);
            }
            Keyboard.SendKeys(newMappingText);
        }

        public void ClickSaveButton(int numberOfTabsToSaveButton)
        {
            var wizard = StudioWindow.GetChildren()[0].GetChildren()[0];
            wizard.WaitForControlReady();
            for(int i = 0; i <= numberOfTabsToSaveButton; i++)
            {
                SendKeys.SendWait("{TAB}");
                Playback.Wait(50);
            }
            SendKeys.SendWait("{ENTER}");
            Playback.Wait(500);
        }

        public static void Cancel()
        {
            for(var i = 0; i < 4; i++)
            {
                Keyboard.SendKeys("{TAB}");
            }
            Keyboard.SendKeys("{ENTER}");
        }

        #region Properties

        public UIBusinessDesignStudioWindow UIBusinessDesignStudioWindow
        {
            get
            {
                if((this.mUIBusinessDesignStudioWindow == null))
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

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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
                if((this.mUIItemImage == null))
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
