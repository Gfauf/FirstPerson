using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ReceiveDamage : MonoBehaviour
{
    public float health = 100f;
    public TextMeshProUGUI enemyHealthUI;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        enemyHealthUI.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

   /* private void OnCollisionEnter(Collision collision)
    {
        float receivedDamage = collision.gameObject.GetComponent<Bullet>().bulletDamage; 

        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }

    }*/

    public void DamageReceived(float damage)
    {
        health -= damage;

        UpdateUI();

        if (health <= 0)
        {
            Destroy(gameObject);
            HUD.enemyCount -= 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Deathzone"))
        {
            Destroy(gameObject);
        }
    }
}
