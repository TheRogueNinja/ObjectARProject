using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleTrans : MonoBehaviour {
    public Transform caps;
    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            caps.transform.Translate(new Vector3(0, 0, 2f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            caps.transform.Translate(new Vector3(-2F, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            caps.transform.Translate(new Vector3(0, 0, -2f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            caps.transform.Translate(new Vector3(2F, 0, 0));
        }
    }
}
