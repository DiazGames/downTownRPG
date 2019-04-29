using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;

namespace DiazDTRPG
{
    public class Knapsack : Inventory, ISingleton
    {

        public static Knapsack Instance
        {
            get
            {
                return MonoSingletonProperty<Knapsack>.Instance;
            }
        }

        public void OnSingletonInit()
        {
        }
    }
}