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
    
    
    public partial class UIAddInventoryPanel
    {
        
        public const string NAME = "UIAddInventoryPanel";
        
        [SerializeField()]
        public UITopStatus UITopStatus;
        
        [SerializeField()]
        public Text TxtAddInvenDesc;
        
        [SerializeField()]
        public Button BtnAdd;
        
        [SerializeField()]
        public Text TxtUseGem;
        
        private UIAddInventoryPanelData mPrivateData = null;
        
        public UIAddInventoryPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIAddInventoryPanelData());
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
            TxtAddInvenDesc = null;
            BtnAdd = null;
            TxtUseGem = null;
            mData = null;
        }
    }
}
