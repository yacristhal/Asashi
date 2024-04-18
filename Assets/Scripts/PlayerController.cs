using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 startTouchPos;
    //private Rigidbody rb;
    private bool isJumping = false;
    private float jumpForce = 300;
    public static PlayerController instance;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startTouchPos = touch.position;              
            }
           else if (touch.phase == TouchPhase.Moved)
            {              
                if (!isJumping && Mathf.Abs(touch.position.y - startTouchPos.y) > 100)
                {
                    isJumping = true;
                   // Vector3 jumpDirection = (touch.position - startTouchPos).normalized;
                   // jumpDirection.y = 0.5f;
                    //rb.AddForce(jumpDirection * jumpForce, ForceMode.Impulse);
                   GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

                }
              
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            //GameOver
            Destroy(other.gameObject);
            Debug.Log("enemy");          
        }
        if (other.CompareTag("coin"))
        {
            // adicionar pontos
            Destroy(other.gameObject);
            Debug.Log("coin");            
        }


    }
}
