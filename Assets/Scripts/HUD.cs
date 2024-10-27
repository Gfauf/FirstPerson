using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HUD : MonoBehaviour
{
    public TMP_Text bulletCount;

    // Start is called before the first frame update
    void Start()
    {
        bulletCount.text = "Bullets: " + ObjectSpawner.bullets.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UIText();
    }


    public void UIText()
    {
        bulletCount.text = "Bullets: " + ObjectSpawner.bullets.ToString();
    }
}
