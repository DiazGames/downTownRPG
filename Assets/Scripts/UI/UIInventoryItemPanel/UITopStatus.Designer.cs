/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace DiazDTRPG
{
	public partial class UITopStatus
	{
		[SerializeField] public Button BtnClose;
		[SerializeField] public Text TxtGoldNumber;
		[SerializeField] public Button BtnGoldAdd;
		[SerializeField] public Text TxtGemNumber;
		[SerializeField] public Button BtnGemAdd;

		public void Clear()
		{
			BtnClose = null;
			TxtGoldNumber = null;
			BtnGoldAdd = null;
			TxtGemNumber = null;
			BtnGemAdd = null;
		}

		public override string ComponentName
		{
			get { return "UITopStatus";}
		}
	}
}
