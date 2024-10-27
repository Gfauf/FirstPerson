using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class HUD : MonoBehaviour
{
    public TMP_Text bulletCount;
    public TMP_Text enemiesLeft;
    public TMP_Text timeLeft;
    public GameObject gameOverImage;

    public static int enemyCount;

    public float targetTime;

    bool gameLost = false;

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
        targetTime -= Time.deltaTime;
        UIText();
        if (targetTime <= 0)
        {
            gameLost = true;
            TimeEnded();
        }
    }


    public void UIText()
    {
        bulletCount.text = "Bullets: " + ObjectSpawner.bullets.ToString();
        enemiesLeft.text = "Enemies left: " + enemyCount;
        timeLeft.text = "Time left: " + Mathf.Round(targetTime);
    }

    public void TimeEnded()
    {
        gameOverImage.SetActive(true);
        Time.timeScale = 0;
        if (gameLost && Input.GetKeyDown(KeyCode.R))
        {
            gameLost = false;
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}
