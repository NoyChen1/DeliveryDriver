using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject car;
    void LateUpdate()
    {
        float xPos = car.transform.position.x;
        float yPos = car.transform.position.y;
        float zPos = this.transform.position.z;

        transform.position = new Vector3(xPos, yPos, zPos);
    }
}
