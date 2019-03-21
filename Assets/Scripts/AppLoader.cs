using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;

namespace DiazDTRPG
{
    public class AppLoader : MonoBehaviour
    {
        private void Awake()
        {
            ResMgr.Init();
            UIMgr.SetResolution(Screen.width, Screen.height, 1.0f);
            DontDestroyOnLoad(UIManager.Instance);
        }

        private void Start()
        {
            UIMgr.OpenPanel<UIHomePanel>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}