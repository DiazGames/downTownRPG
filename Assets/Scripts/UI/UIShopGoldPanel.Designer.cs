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
    
    
    public partial class UIShopGoldPanel
    {
        
        public const string NAME = "UIShopGoldPanel";
        
        [SerializeField()]
        public Button Background;
        
        [SerializeField()]
        public Button BtnGold;
        
        [SerializeField()]
        public Button BtnDiamand;
        
        [SerializeField()]
        public Button BtnClose;
        
        private UIShopGoldPanelData mPrivateData = null;
        
        public UIShopGoldPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIShopGoldPanelData());
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
            BtnGold = null;
            BtnDiamand = null;
            BtnClose = null;
            mData = null;
        }
    }
}
