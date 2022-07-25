using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkBullet : MonoBehaviour
{
    float maxX = 15f;

    void Awake()
    {
        float aspect = (float)Screen.width / Screen.height;
        float worldHeight = Camera.main.orthographicSize * 2;
        float worldWidth = worldHeight * aspect;
        maxX = worldWidth / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= maxX)
            Destroy(this.gameObject);
    }
}
