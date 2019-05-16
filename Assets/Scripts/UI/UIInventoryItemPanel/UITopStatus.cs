/****************************************************************************
 * 2019.4 风漫云端的MacBook Pro
 ****************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UniRx;

namespace DiazDTRPG
{
    public partial class UITopStatus : UIElement
	{
        private void Awake()
		{
            ShowValueChaged();

            BtnClose.OnClickAsObservable().Subscribe(_ =>
            {
                // 关闭父节点的panel
                UIMgr.ClosePanel(transform.parent.name);
            });

            BtnGemAdd.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIShopGemPanel>();
            });

            BtnGoldAdd.OnClickAsObservable().Subscribe(_ =>
            {
                UIMgr.OpenPanel<UIShopGoldPanel>();
            });
		}

        /// <summary>
        /// 数据更改后更新UI
        /// </summary>
        public void ShowValueChaged()
        {
            TxtGemNumber.text = GameData.GemCount.ToString();
            TxtGoldNumber.text = GameData.GoldCount.ToString();
        }

        protected override void OnBeforeDestroy()
		{
		}
	}
}