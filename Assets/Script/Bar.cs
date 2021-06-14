using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    private void Update() {
        Transform barTransform = GameObject.Find("Bar").transform;
        Vector3 position = barTransform.position;

        if (Input.GetKey(KeyCode.LeftArrow) && position.x > -20) {
            this.gameObject.transform.Translate(-0.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) && position.x < 20) {
            this.gameObject.transform.Translate(0.5f, 0f, 0f);
        }
    }
}
