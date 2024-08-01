using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f; // roatation speed
    [SerializeField] float moveSpeed = 10f; // froward/backword speed
    void Start()
    {

    }

    void Update()
    {
        float steerAmound = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; 
        transform.Rotate(0,0, -steerAmound);
        transform.Translate(0, moveAmount, 0);        
    }
}
