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
	public partial class ToolTip : UIElement
	{
        //private float targetAlpha = 0;
        //public float smoothing = 1;

		private void Awake()
		{
            BtnTipClose.OnClickAsObservable().Subscribe(_ =>
            {
                Hide();
            });
		}

        private void Update()
        {
            //if (Math.Abs(canvasGroup.alpha - targetAlpha) > 0)
            //{
            //    canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, targetAlpha, smoothing * Time.deltaTime);
            //    if (Mathf.Abs(canvasGroup.alpha - targetAlpha) < 0.05f)
            //    {
            //        canvasGroup.alpha = targetAlpha;
            //    }
            //}
        }

        protected override void OnBeforeDestroy()
		{
		}

        public void ShowToolTip(string content)
        {
            TxtContent.text = content;
            TxtToolTip.text = content;
            this.Show();
            //targetAlpha = 1;
        }
        public void HideToolTip()
        {
            this.Hide();
            //targetAlpha = 0;
        }
    }
}