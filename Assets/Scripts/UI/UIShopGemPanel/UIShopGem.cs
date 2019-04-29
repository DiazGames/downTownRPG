/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UniRx;

namespace DiazDTRPG
{
	public partial class UIShopGem : UIElement
	{
        public ProductGemModel ProductGemModel { get; set; }
        public void Awake()
		{
            //[SerializeField] public Button BtnBuy;
            TxtBtnBuyNum.text = ProductGemModel.ProductPrice.ToString();
            ImgProduct.sprite = Resources.Load<Sprite>(ProductGemModel.ProductSprite);
            switch (ProductGemModel.ProductID)
            {
                case 1:
                    ImgProduct.LocalScale(0.3f, 0.3f, 0.3f);
                    break;
                case 2:
                    ImgProduct.LocalScale(0.5f, 0.5f, 0.5f);
                    break;
                case 3:
                    ImgProduct.LocalScale(0.8f, 0.8f, 0.8f);
                    break;
                default:
                    ImgProduct.LocalScale(Vector3.one);
                    break;
            }

            TxtProductNum.text = ProductGemModel.ProductNum.ToString();
            if (ProductGemModel.ProductBouns > 0)
            {
                TxtBouns.Show();
                TxtBouns.text = "Bonus +" + ProductGemModel.ProductBouns.ToString() + "%";
            }
            else
            {
                TxtBouns.Hide();
            }
            if(ProductGemModel.ProductPurpleSprite.Length > 0)
            {
                ImgShopLabelPurple.Show();
                TxtShopPurple.Show();
                ImgShopLabelPurple.sprite = Resources.Load<Sprite>(ProductGemModel.ProductPurpleSprite);
                TxtShopPurple.text = ProductGemModel.ProductPurpleDesc;
            }
            else
            {
                ImgShopLabelPurple.Hide();
                TxtShopPurple.Hide();
            }

            BtnBuy.OnClickAsObservable().Subscribe(_ =>
            {
                // 打开购买界面

                // 增加钻石
                GameData.GemCount = GameData.GemCount + ProductGemModel.ProductNum;

                // 更新UI
                UIMgr.GetPanel<UIShopGemPanel>().UpdateTopStautsValue();
            });

        }

		protected override void OnBeforeDestroy()
		{
		}
	}
}