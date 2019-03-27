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
    
    
    public partial class UIMapPanel
    {
        
        public const string NAME = "UIMapPanel";
        
        // 冰城
        [SerializeField()]
        public Button BtnLevelIceTown;
        
        // 冰原
        [SerializeField()]
        public Button BtnLevelIce;
        
        // 森林
        [SerializeField()]
        public Button BtnLevelForest;
        
        // 森林城
        [SerializeField()]
        public Button BtnLevelForestTown;
        
        // 沼泽地
        [SerializeField()]
        public Button BtnLevelWetlands;
        
        // 沙漠
        [SerializeField()]
        public Button BtnLevelDesert;
        
        // 火山
        [SerializeField()]
        public Button BtnLevelVolcano;
        
        // 火山城
        [SerializeField()]
        public Button BtnLevelVolcanoTown;
        
        [SerializeField()]
        public Button BtnHomeTown;
        
        private UIMapPanelData mPrivateData = null;
        
        public UIMapPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIMapPanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            BtnLevelIceTown = null;
            BtnLevelIce = null;
            BtnLevelForest = null;
            BtnLevelForestTown = null;
            BtnLevelWetlands = null;
            BtnLevelDesert = null;
            BtnLevelVolcano = null;
            BtnLevelVolcanoTown = null;
            BtnHomeTown = null;
            mData = null;
        }
    }
}