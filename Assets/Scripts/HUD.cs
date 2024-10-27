using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HUD : MonoBehaviour
{
    public TMP_Text bulletCount;
    public TMP_Text enemiesLeft;
    public static int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        bulletCount.text = "Bullets: " + ObjectSpawner.bullets.ToString();
        enemiesLeft.text = "Enemies left: " + enemyCount;
    }

    // Update is called once per frame
    void Update()
    {
        UIText();
    }


    public void UIText()
    {
        bulletCount.text = "Bullets: " + ObjectSpawner.bullets.ToString();
        enemiesLeft.text = "Enemies left: " + enemyCount;
    }
}
