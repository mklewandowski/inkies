using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField]
    Transform Target;
    [SerializeField]
    float Speed;

    // Update is called once per frame
    void Update()
    {
        if (Target != null) {
            transform.RotateAround(Target.position, Vector3.back, Speed * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
}
