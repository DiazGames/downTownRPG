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
    
    
    public partial class UIInventoryNewPanel
    {
        
        public const string NAME = "UIInventoryNewPanel";
        
        [SerializeField()]
        public UITopStatus UITopStatus;
        
        [SerializeField()]
        public Text TxtUsedCount;
        
        [SerializeField()]
        public Text TxtAllCount;
        
        [SerializeField()]
        public Button BtnInventoryAdd;
        
        [SerializeField()]
        public RectTransform Content;
        
        [SerializeField()]
        public UISolt UISolt;
        
        private UIInventoryNewPanelData mPrivateData = null;
        
        public UIInventoryNewPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIInventoryNewPanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            UITopStatus = null;
            TxtUsedCount = null;
            TxtAllCount = null;
            BtnInventoryAdd = null;
            Content = null;
            UISolt = null;
            mData = null;
        }
    }
}
