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
    
    
    public partial class UIGetRewardPanel
    {
        
        public const string NAME = "UIGetRewardPanel";
        
        [SerializeField()]
        public Button Background;
        
        [SerializeField()]
        public Button BtnClose;
        
        [SerializeField()]
        public Button BtnOK;
        
        private UIGetRewardPanelData mPrivateData = null;
        
        public UIGetRewardPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIGetRewardPanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            Background = null;
            BtnClose = null;
            BtnOK = null;
            mData = null;
        }
    }
}