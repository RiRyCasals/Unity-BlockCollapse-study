using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100;

    private void Start() {
        Vector3 force = new Vector3(8.0f, -10.0f, 0.0f) * speed;
        this.GetComponent<Rigidbody>().AddForce(force);
    }
}
