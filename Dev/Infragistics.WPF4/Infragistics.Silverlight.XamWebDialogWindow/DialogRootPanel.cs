using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Infragistics;

namespace Infragistics.Controls.Interactions.Primitives
{
	/// <summary>
	/// A panel that should used as the Root Element of the <see cref="XamDialogWindow"/>
	/// </summary>
	public class DialogRootPanel : Grid, ICommandTarget
	{
		/// <summary>
		/// Creates a new instance of the <see cref="DialogRootPanel"/>
		/// </summary>
		public DialogRootPanel()
		{


#region Infragistics Source Cleanup (Region)


#endregion // Infragistics Source Cleanup (Region)

		}

		/// <summary>
		/// Gets the <see cref="XamDialogWindow"/> that owns this panel.
		/// </summary>
		public XamDialogWindow DialogWindow
		{
			get;
			internal set;
		}

		#region  GetParameter
		/// <summary>
		/// Returns the object that defines the parameters necessary to execute the command.
		/// </summary>
		/// <param name="source">The CommandSource object which defines the command to be executed.</param>
		/// <returns>The object necessary for the command to complete.</returns>
		protected virtual object GetParameter(CommandSource source)
		{
			if (source.Command is XamDialogWindowCommandBase)
				return this.DialogWindow;

			return null;
		}
		#endregion // GetParameter

		#region SupportsCommand

		/// <summary>
		/// Returns if the object will support a given command type.
		/// </summary>
		/// <param name="command">The command to be validated.</param>
		/// <returns>True if the object recognizes the command as actionable against it.</returns>
		protected virtual bool SupportsCommand(ICommand command)
		{
			return command is XamDialogWindowCommandBase;
		}
		#endregion // SupportsCommand

		#region ICommandTarget Members

		bool ICommandTarget.SupportsCommand(ICommand command)
		{
			return this.SupportsCommand(command);
		}

		object ICommandTarget.GetParameter(CommandSource source)
		{
			return this.GetParameter(source);
		}

		#endregion ICommandTarget
	}
}

#region Copyright (c) 2001-2012 Infragistics, Inc. All Rights Reserved
/* ---------------------------------------------------------------------*
*                           Infragistics, Inc.                          *
*              Copyright (c) 2001-2012 All Rights reserved               *
*                                                                       *
*                                                                       *
* This file and its contents are protected by United States and         *
* International copyright laws.  Unauthorized reproduction and/or       *
* distribution of all or any portion of the code contained herein       *
* is strictly prohibited and will result in severe civil and criminal   *
* penalties.  Any violations of this copyright will be prosecuted       *
* to the fullest extent possible under law.                             *
*                                                                       *
* THE SOURCE CODE CONTAINED HEREIN AND IN RELATED FILES IS PROVIDED     *
* TO THE REGISTERED DEVELOPER FOR THE PURPOSES OF EDUCATION AND         *
* TROUBLESHOOTING. UNDER NO CIRCUMSTANCES MAY ANY PORTION OF THE SOURCE *
* CODE BE DISTRIBUTED, DISCLOSED OR OTHERWISE MADE AVAILABLE TO ANY     *
* THIRD PARTY WITHOUT THE EXPRESS WRITTEN CONSENT OF INFRAGISTICS, INC. *
*                                                                       *
* UNDER NO CIRCUMSTANCES MAY THE SOURCE CODE BE USED IN WHOLE OR IN     *
* PART, AS THE BASIS FOR CREATING A PRODUCT THAT PROVIDES THE SAME, OR  *
* SUBSTANTIALLY THE SAME, FUNCTIONALITY AS ANY INFRAGISTICS PRODUCT.    *
*                                                                       *
* THE REGISTERED DEVELOPER ACKNOWLEDGES THAT THIS SOURCE CODE           *
* CONTAINS VALUABLE AND PROPRIETARY TRADE SECRETS OF INFRAGISTICS,      *
* INC.  THE REGISTERED DEVELOPER AGREES TO EXPEND EVERY EFFORT TO       *
* INSURE ITS CONFIDENTIALITY.                                           *
*                                                                       *
* THE END USER LICENSE AGREEMENT (EULA) ACCOMPANYING THE PRODUCT        *
* PERMITS THE REGISTERED DEVELOPER TO REDISTRIBUTE THE PRODUCT IN       *
* EXECUTABLE FORM ONLY IN SUPPORT OF APPLICATIONS WRITTEN USING         *
* THE PRODUCT.  IT DOES NOT PROVIDE ANY RIGHTS REGARDING THE            *
* SOURCE CODE CONTAINED HEREIN.                                         *
*                                                                       *
* THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE.              *
* --------------------------------------------------------------------- *
*/
#endregion Copyright (c) 2001-2012 Infragistics, Inc. All Rights Reserved