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
    
    public class UIGamePausePanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIGamePausePanel : QFramework.UIPanel
    {
        protected override void RegisterUIEvent()
        {
            BtnContinue.OnClickAsObservable().Subscribe(_ =>
            {
                //UIMgr.GetPanel<UIGamePanel>().mData.ShowCharacters = true;
                UIMgr.GetPanel<UIGamePanel>().Transform.Find("Characters").gameObject.SetActive(true);
                UIMgr.GetPanel<UIGamePanel>().Transform.Find("Emenys").gameObject.SetActive(true);
                CloseSelf();
            });

            BtnRestart.OnClickAsObservable().Subscribe(_ =>
            {
                //UIMgr.GetPanel<UIGamePanel>().mData.ShowCharacters = true;
                UIMgr.GetPanel<UIGamePanel>().Transform.Find("Characters").gameObject.SetActive(true);
                UIMgr.GetPanel<UIGamePanel>().Transform.Find("Emenys").gameObject.SetActive(true);
                CloseSelf();
            });
            BtnGiveUp.OnClickAsObservable().Subscribe(_ =>
            {
                CloseSelf();
                UIMgr.ClosePanel<UIGamePanel>();
            });

            BtnSetting.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIGamePauseSettingPanel>();
            });
        }
        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIGamePausePanelData ?? new UIGamePausePanelData();
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
