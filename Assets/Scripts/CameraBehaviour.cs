using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] [Range(0.01f, 1f)] float spinningSpeed;
    private Vector3 rotateValue;
    private bool rotationDirection = true;

    // Update is called once per frame
    void Update()
    {
        rotateValue = new Vector3(0, spinningSpeed, 0);

        Debug.Log(this.gameObject.transform.rotation.w);

        if (this.gameObject.transform.rotation.w >= 0.4)
        {
            rotationDirection = false;
        }
        if (this.gameObject.transform.rotation.w <= -0.4)
        {
            rotationDirection = true;
        }

        switch (rotationDirection)
        {
            case true: transform.eulerAngles -= rotateValue;
                break;
            case false: transform.eulerAngles += rotateValue;
                break;
        }
    }
}
