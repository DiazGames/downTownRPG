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
    
    
    public partial class UIHeroPubPanel
    {
        
        public const string NAME = "UIHeroPubPanel";
        
        [SerializeField()]
        public Button BtnClose;
        
        [SerializeField()]
        public Button BtnGoldAdd;
        
        [SerializeField()]
        public Button BtnGemAdd;
        
        [SerializeField()]
        public Button BtnFree;
        
        [SerializeField()]
        public Button BtnGem;
        
        private UIHeroPubPanelData mPrivateData = null;
        
        public UIHeroPubPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIHeroPubPanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            BtnClose = null;
            BtnGoldAdd = null;
            BtnGemAdd = null;
            BtnFree = null;
            BtnGem = null;
            mData = null;
        }
    }
}
