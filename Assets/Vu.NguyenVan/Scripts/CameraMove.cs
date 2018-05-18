using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Transform target;
    public float moveSpeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 p1 = target.position + offset;
        Vector3 speed = Vector3.Lerp(transform.position, p1, moveSpeed);
        transform.position = speed;

        transform.LookAt(target);
    }


}
