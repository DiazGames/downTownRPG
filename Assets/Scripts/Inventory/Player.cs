using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DiazDTRPG
{
    public class Player : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                int id = Random.Range(1, 2);
                Knapsack.Instance.StoreItem(id);
            }
        }
    }
}