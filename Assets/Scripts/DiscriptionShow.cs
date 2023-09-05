using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionShow : MonoBehaviour
{
    public TMPro.TMP_Text descriptionText;
    public string description;

    void Update()
    {
        DescriptionUpdate();   
    }
    public void DescriptionUpdate()
    {
        descriptionText.text = description;
    }
}
