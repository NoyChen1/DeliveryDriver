using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private State state;
    enum State
    {
        Free,
        Busy
    }

    private void Start()
    {
        state = State.Free;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag) {
            case "Obstacle":
                print("hitted an obstacle");
                break;
            default:
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Delivery":
                if(state == State.Free)
                {
                    state = State.Busy;
                    print("Now I'm " + state);
                }
                break;
            case "Customer":
                if(state == State.Busy)
                {
                    state = State.Free;
                    print("Now I'm " + state);
                }
                break;
            default:
                break;
        }
    }
}
