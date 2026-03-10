using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickGame : MonoBehaviour
{
    public int clicks = 0;

    public TMP_Text clickText;
    public GameObject popup;

    public void AddClick()
    {
        clicks++;

        clickText.text = "Clicks: " + clicks;

        if (clicks >= 100)
        {
            popup.SetActive(true);
        }
    }
}
