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
    
    
    public partial class UIFreeRewardPanel
    {
        
        public const string NAME = "UIFreeRewardPanel";
        
        [SerializeField()]
        public Button Background;
        
        [SerializeField()]
        public Button BtnClose;
        
        [SerializeField()]
        public Text TxtGemDes;
        
        [SerializeField()]
        public Button BtnWatch;
        
        [SerializeField()]
        public Text TxtGemCout;
        
        [SerializeField()]
        public Text TxtGoldDes;
        
        [SerializeField()]
        public Button BtnShare;
        
        [SerializeField()]
        public Text TxtGoldCout;
        
        private UIFreeRewardPanelData mPrivateData = null;
        
        public UIFreeRewardPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIFreeRewardPanelData());
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
            TxtGemDes = null;
            BtnWatch = null;
            TxtGemCout = null;
            TxtGoldDes = null;
            BtnShare = null;
            TxtGoldCout = null;
            mData = null;
        }
    }
}
