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
    
    public class UIHeroPubPanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIHeroPubPanel : QFramework.UIPanel
    {
        protected override void RegisterUIEvent()
        {

            BtnFree.OnClickAsObservable().Subscribe(_ =>
            {
                // do something
            });

            BtnGem.OnClickAsObservable().Subscribe(_ =>
            {
                // do something
            });
        }
        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIHeroPubPanelData ?? new UIHeroPubPanelData();
            // please add init code here
            UITopStatus.TxtTopTitle.text = "酒馆";
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
