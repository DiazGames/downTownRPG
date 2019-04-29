/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace DiazDTRPG
{
	public partial class UIShopGem
	{
		[SerializeField] public Button BtnBuy;
		[SerializeField] public Text TxtBtnBuyNum;
		[SerializeField] public Image ImgBtnIcon;
		[SerializeField] public Image ImgProduct;
		[SerializeField] public Text TxtProductNum;
		[SerializeField] public Text TxtBouns;
		[SerializeField] public Image ImgShopLabelPurple;
		[SerializeField] public Text TxtShopPurple;

		public void Clear()
		{
			BtnBuy = null;
			TxtBtnBuyNum = null;
			ImgBtnIcon = null;
			ImgProduct = null;
			TxtProductNum = null;
			TxtBouns = null;
			ImgShopLabelPurple = null;
			TxtShopPurple = null;
		}

		public override string ComponentName
		{
			get { return "UIShopGem";}
		}
	}
}
