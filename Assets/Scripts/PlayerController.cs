using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 7f;
    bool canJump;

    public Rigidbody playerRB;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float frontMovement = Input.GetAxis("Horizontal") * speed;
        float lateralMovement = Input.GetAxis("Vertical") * speed;

        frontMovement *= Time.deltaTime;
        lateralMovement *= Time.deltaTime;

        transform.Translate(frontMovement, 0f, lateralMovement);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            playerRB.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            canJump = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            speed *= 4f;
        }
        
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 10f;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
        }

        if (collision.gameObject.CompareTag("Deathzone"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
