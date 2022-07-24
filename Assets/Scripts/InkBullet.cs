using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkBullet : MonoBehaviour
{
    float maxX = 15f;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= maxX)
            Destroy(this.gameObject);
    }
}
