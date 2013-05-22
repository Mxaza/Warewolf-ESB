﻿using Dev2.Studio.Core.Interfaces;

namespace Dev2.Studio.Core.Messages
{
    public class ShowEditResourceWizardMessage:IMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public ShowEditResourceWizardMessage(IResourceModel resourceModel, bool forceStandAloneSaveDialog)
        {
            ResourceModel = resourceModel;
            ForceStandAloneSaveDialog = forceStandAloneSaveDialog;
        }

        public IResourceModel ResourceModel { get; set; }
        public bool ForceStandAloneSaveDialog { get; set; }
    }
}