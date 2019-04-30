/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace DiazDTRPG
{
	public partial class UIShopGold
	{
		[SerializeField] public Button BtnBuy;
		[SerializeField] public Text TxtBtnBuyNum;
		[SerializeField] public Image ImgBtnIcon;
		[SerializeField] public Image ImgProduct;
		[SerializeField] public Text TxtProductNum;
		[SerializeField] public Text TxtBonus;
		[SerializeField] public Image ImgShopLabel;
		[SerializeField] public Text TxtShopLabel;

		public void Clear()
		{
			BtnBuy = null;
			TxtBtnBuyNum = null;
			ImgBtnIcon = null;
			ImgProduct = null;
			TxtProductNum = null;
			TxtBonus = null;
			ImgShopLabel = null;
			TxtShopLabel = null;
		}

		public override string ComponentName
		{
			get { return "UIShopGold";}
		}
	}
}
