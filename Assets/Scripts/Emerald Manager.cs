using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Minecraft.InventorySystem
{
        public class EmeraldManager : MonoBehaviour
    {
        // Start is called before the first frame update
        public TMPro.TMP_Text emeraldText;
        public int myemerald = 64;

        // Update is called once per frame
        void Update()
        {
            EmeraldUpdate();
        }

        public void EmeraldUpdate()
        {
            if (myemerald == 0)
            {
                emeraldText.text = "1";
            }
            else
            emeraldText.text = myemerald.ToString();
        }
    }
}


