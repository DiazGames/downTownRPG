/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace DiazDTRPG
{
	public partial class UIItem
	{
		[SerializeField] public Image ImgItemCount;
		[SerializeField] public Text TxtItemCount;

		public void Clear()
		{
			ImgItemCount = null;
			TxtItemCount = null;
		}

		public override string ComponentName
		{
			get { return "UIItem";}
		}
	}
}
