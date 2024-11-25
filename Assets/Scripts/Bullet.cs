using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public static float bulletDamage = 25f;
    [SerializeField] public GameObject hitVFXPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<ReceiveDamage>().DamageReceived(bulletDamage);

            GameObject hitVFXPrefabClone = Instantiate(hitVFXPrefab, transform.position, transform.rotation);

            Destroy(hitVFXPrefabClone, 4f);
        }
    }
}
