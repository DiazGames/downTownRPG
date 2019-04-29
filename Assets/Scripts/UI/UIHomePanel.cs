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
    
    
    public class UIHomePanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIHomePanel : QFramework.UIPanel
    {
        protected override void RegisterUIEvent()
        {
            // 英雄按钮点击
            MenuHeros.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Clicked MenuHeros!");
                UIMgr.OpenPanel<UIMyInfoPanel>();
            });
            // 队伍按钮点击
            MenuTeam.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Clicked MenuTeam!");
                UIMgr.OpenPanel<UIMyInfoPanel>();
            });
            // 背包按钮点击
            MenuBackpack.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Clicked MenuBackpack!");
                UIMgr.OpenPanel<UIInventoryNewPanel>();
            });
            // 酒馆按钮点击
            MenuPub.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIHeroPubPanel>();
            });
            // 道具按钮点击
            MenuProps.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Clicked MenuProps!");
                UIMgr.OpenPanel<UIPropPanel>();
            });
            // 任务按钮点击
            MenuMission.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Clicked Mission!");
                UIMgr.OpenPanel<UIMissionPanel>();
            });
            // 商店按钮点击
            MenuShop.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Clicked MenuShop!");
                UIMgr.OpenPanel<UIShopGoldPanel>();
            });
            // 设置按钮点击
            MenuSetting.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Clicked MenuSetting!");
                UIMgr.OpenPanel<UISettingPanel>();
            });
            // 消息按钮点击
            MenuMessages.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("Clicked MenuMessages!");
                UIMgr.OpenPanel<UIMessagePanel>();
            });
            // 增加钻石按钮点击
            BtnGemAdd.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIShopGemPanel>();
            });
            // 增加金币按钮
            BtnGoldAdd.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIShopGoldPanel>();
            });
            // 用户信息按钮点击
            BtnUserInfo.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIMyInfoPanel>();
            });
            // 战斗按钮点击
            BtnPlay.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIMapPanel>();
            });
            // 福利按钮点击
            MenuFree.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIFreeRewardPanel>();
            });
        }
        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIHomePanelData ?? new UIHomePanelData();
            // please add init code here
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
    }
}
