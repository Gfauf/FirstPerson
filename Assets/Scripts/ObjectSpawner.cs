using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public Vector3 spawnPosition;
    public float bulletForce;
    public static float bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && bullets > 0)
        {
            GameObject bulletClone = Instantiate(objectPrefab, transform.position, transform.rotation);
            bulletClone.name = "Bullet Clone";

            Rigidbody bulletRigidbody = bulletClone.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = transform.up * bulletForce;


            Destroy(bulletClone, 2f);

            bullets -= 1;
        }
    }
}
