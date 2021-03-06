// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace DiazDTRPG
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    using QFramework;
    using UniRx;
    
    public class UIShopGemPanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIShopGemPanel : QFramework.UIPanel
    {
        protected override void RegisterUIEvent()
        {
            BtnGold.OnClickAsObservable()
                .Subscribe(_ =>
                {
                    UIMgr.OpenPanel<UIShopGoldPanel>();
                    CloseSelf();
                });

            Background.OnClickAsObservable().Subscribe(_ =>
            {
                CloseSelf();
            });
        }

        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIShopGemPanelData ?? new UIShopGemPanelData();
            // please add init code here
            ShowProductGemList();
            UITopStatus.TxtTopTitle.text = "商店";
        }
        
        protected override void OnOpen(QFramework.IUIData uiData)
        {
        }
        
        protected override void OnShow()
        {
        }
        
        protected override void OnHide()
        {
        }
        
        protected override void OnClose()
        {
        }

        /// <summary>
        /// 显示钻石商品列表
        /// </summary>
        public void ShowProductGemList()
        {

            foreach (ProductGemModel model in ProductGemData.ProductGemDataList)
            {
                UIShopGem.Instantiate()
                .Parent(Contents)
                .LocalIdentity()
                .ApplySelfTo(self =>
                {
                    self.ProductGemModel = model;
                    self.Show();
                });
            }
        }

        /// <summary>
        /// 更新状态条上的数据
        /// </summary>
        public void UpdateTopStautsValue()
        {
            // 更新本页面的数据
            UITopStatus.ShowValueChaged();
            // 更新首页数据
            UIMgr.GetPanel<UIHomePanel>().UpdateTopStautsValue();
        }
    }
}
