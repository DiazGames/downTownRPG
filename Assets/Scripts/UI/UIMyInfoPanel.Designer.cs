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
    
    
    public partial class UIMyInfoPanel
    {
        
        public const string NAME = "UIMyInfoPanel";
        
        [SerializeField()]
        public Button Background;
        
        [SerializeField()]
        public Button BtnClose;
        
        private UIMyInfoPanelData mPrivateData = null;
        
        public UIMyInfoPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIMyInfoPanelData());
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
            mData = null;
        }
    }
}
