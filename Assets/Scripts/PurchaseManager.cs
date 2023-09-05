using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Minecraft.InventorySystem
{
    public class PurchaseManager : MonoBehaviour
    {
        
        public int emeraldcost;
        
        public void PurchaseOnClick()
        {
            if (myemerald >= emeraldcost)
            {
                myemerald = myemerald-itemdata.cost;
            }
        }


        // Update is called once per frame
        void Update()
        {
            emeraldText.text = emerald.ToString();
            /*
            costText.text = GetComponent<UIItem>().cost;
            emeraldText.text = fakecost + item..cost;
            */
        }
    }
}

