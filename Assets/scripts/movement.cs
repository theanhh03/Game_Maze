using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private float moveMentX;
    private float moveMentY;
    
    public Text txtPoint;
    public int pointGame = 0;
    public bool isLose;
    public bool win = false;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 6f; 
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        moveMentX = movementVector.x;
        moveMentY = movementVector.y;
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveMentX, 0.0f, moveMentY);
        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Point")){    
            other.gameObject.SetActive(false);
            GetPoint();
        }
        if (other.gameObject.CompareTag("Win"))
        {
            win = true;
        }
        if (other.gameObject.CompareTag("Lose"))
        {
            isLose = true;
        }
    }
    void GetPoint()
    {
        pointGame++;
        txtPoint.text = "Point: " + pointGame.ToString();
    }
}
