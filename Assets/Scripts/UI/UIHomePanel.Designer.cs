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
    
    
    public partial class UIHomePanel
    {
        
        public const string NAME = "UIHomePanel";
        
        [SerializeField()]
        public Button MenuMission;
        
        [SerializeField()]
        public Button MenuSetting;
        
        [SerializeField()]
        public Button MenuProps;
        
        [SerializeField()]
        public Button MenuMessages;
        
        [SerializeField()]
        public Button btnGoldAdd;
        
        [SerializeField()]
        public Button MenuShop;
        
        [SerializeField()]
        public Button MenuPub;
        
        [SerializeField()]
        public Button MenuHeros;
        
        [SerializeField()]
        public Button BtnUserInfo;
        
        [SerializeField()]
        public Button btnGemAdd;
        
        [SerializeField()]
        public Button MenuBackpack;
        
        [SerializeField()]
        public Button MenuTeam;
        
        private UIHomePanelData mPrivateData = null;
        
        public UIHomePanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIHomePanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            MenuMission = null;
            MenuSetting = null;
            MenuProps = null;
            MenuMessages = null;
            btnGoldAdd = null;
            MenuShop = null;
            MenuPub = null;
            MenuHeros = null;
            BtnUserInfo = null;
            btnGemAdd = null;
            MenuBackpack = null;
            MenuTeam = null;
            mData = null;
        }
    }
}
