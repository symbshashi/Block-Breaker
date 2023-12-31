using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;

    Vector2 paddleToBallVector;
    bool hasStart = false;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStart) 
        { 
        LockBallToPaddle();
        LaunchOnMouseClick();
        }


    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStart = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2 (xPush , yPush);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStart)
        {
            GetComponent<AudioSource>().Play();
        }
       
    }
}
