
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


using System;
using System.ComponentModel;
using System.Security.Principal;

namespace SecurityEditor
{
	internal class AccountInfo : IComparable<AccountInfo>
	{
		public string accountName;
		public string domainName;
		public SecurityIdentifier sid;
		public Microsoft.Win32.NativeMethods.SidNameUse use;

		public AccountInfo(IdentityReference s, string targetComputer = null)
		{
			sid = s is SecurityIdentifier ? (SecurityIdentifier)s : (SecurityIdentifier)s.Translate(typeof(SecurityIdentifier));
			uint res = Microsoft.Win32.NativeMethods.AccountUtils.LookupAccountSid(sid, out accountName, out domainName, out use, targetComputer);
			if (res != 0)
				throw new Win32Exception((int)res);
		}

		public static implicit operator SecurityIdentifier(AccountInfo ai)
		{
			return ai.sid;
		}

		public override string ToString()
		{
			//System.Diagnostics.Debug.WriteLine("{0}\\{1}: {2} ({3})", domainName, accountName, sid.Value, use);
			if (use == Microsoft.Win32.NativeMethods.SidNameUse.WellKnownGroup)
				return accountName;
			return string.Format("{0} ({1}\\{0})", accountName, sid.Value.StartsWith("S-1-5-32") ? Environment.MachineName : domainName);
		}

		public int CompareTo(SecurityIdentifier otherSid)
		{
			return sid.CompareTo(otherSid);
		}

		public int CompareTo(AccountInfo other)
		{
			return this.sid.CompareTo(other.sid);
		}
	}
}
