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
    
    public class UIMapStagesPanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIMapStagesPanel : QFramework.UIPanel
    {
        protected override void RegisterUIEvent()
        {
            BtnBack.OnClickAsObservable().Subscribe(_ =>
            {
                CloseSelf();
            });
            StageCompleteStar3.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIMapStatesDesPanel>();
            });
            StageLock.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIMapStagesLockPanel>();
            });
            BtnGoldAdd.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIShopGoldPanel>();
            });
            BtnGemAdd.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIShopGemPanel>();
            });
        }
        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIMapStagesPanelData ?? new UIMapStagesPanelData();
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
