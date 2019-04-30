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
	public partial class UIShopGold : UIElement
	{
        public ProductGoldModel ProductGoldModel { get; set; }
        private void Awake()
		{
            TxtBtnBuyNum.text = ProductGoldModel.ProductGoldPrice.ToString();
            ImgProduct.sprite = Resources.Load<Sprite>(ProductGoldModel.ProductGoldSprite);
            switch (ProductGoldModel.ProductGoldID)
            {
                case 1:
                    ImgProduct.LocalScale(0.5f, 0.5f, 0.5f);
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

            TxtProductNum.text = ProductGoldModel.ProductGoldNum.ToString();
            if (ProductGoldModel.ProductGoldBouns > 0)
            {
                TxtBonus.Show();
                TxtBonus.text = "Bonus +" + ProductGoldModel.ProductGoldBouns.ToString() + "%";
            }
            else
            {
                TxtBonus.Hide();
            }
            if (ProductGoldModel.ProductGoldPurpleSprite.Length > 0)
            {
                ImgShopLabel.Show();
                TxtShopLabel.Show();
                ImgShopLabel.sprite = Resources.Load<Sprite>(ProductGoldModel.ProductGoldPurpleSprite);
                TxtShopLabel.text = ProductGoldModel.ProductGoldPurpleDesc;
            }
            else
            {
                ImgShopLabel.Hide();
                TxtShopLabel.Hide();
            }

            BtnBuy.OnClickAsObservable().Subscribe(_ =>
            {
                if (GameData.GemCount >= ProductGoldModel.ProductGoldPrice)
                {
                    // 减少钻石
                    GameData.GemCount = GameData.GemCount - ProductGoldModel.ProductGoldPrice;
                    // 增加金币
                    GameData.GoldCount = GameData.GoldCount + ProductGoldModel.ProductGoldNum;
                    // 更新UI
                    UIMgr.GetPanel<UIShopGoldPanel>().UpdateTopStautsValue();
                    // 跳转到成功界面
                    UIMgr.OpenPanel<UIDataUpdateSucceedPanel>(new UIDataUpdateSucceedPanelData
                    {
                        SuccessModel = new DataUpdateSuccessModel
                        {
                            StrTitle = "购买成功",
                            StrDesc = "成功购买 " + ProductGoldModel.ProductGoldNum + "\n 枚金币！",
                            IsSucceed = true
                        }
                    });
                }
                else
                {
                    // 跳转到钻石不足界面
                    UIMgr.OpenPanel<UIDataUpdateSucceedPanel>(new UIDataUpdateSucceedPanelData
                    {
                        SuccessModel = new DataUpdateSuccessModel
                        {
                            StrTitle = "购买失败",
                            StrDesc = "钻石不足，请先购买钻石哦~",
                            IsSucceed = true
                        }
                    });
                }

            });
        }

		protected override void OnBeforeDestroy()
		{
		}
	}
}