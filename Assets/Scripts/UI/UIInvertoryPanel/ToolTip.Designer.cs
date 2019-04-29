/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace DiazDTRPG
{
	public partial class ToolTip
	{
		[SerializeField] public Text TxtContent;
        [SerializeField] public Text TxtToolTip;
        [SerializeField] public Button BtnTipClose;
        [SerializeField] public CanvasGroup canvasGroup;
        public void Clear()
		{
			TxtContent = null;
			BtnTipClose = null;
		}

		public override string ComponentName
		{
			get { return "ToolTip";}
		}
	}
}
