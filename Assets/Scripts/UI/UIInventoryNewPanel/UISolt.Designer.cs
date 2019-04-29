/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace DiazDTRPG
{
	public partial class UISolt
	{
		[SerializeField] public UIItem UIItem;

		public void Clear()
		{
			UIItem = null;
		}

		public override string ComponentName
		{
			get { return "UISolt";}
		}
	}
}
