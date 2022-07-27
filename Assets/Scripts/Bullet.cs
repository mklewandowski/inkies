using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float screenRightEdge = 15f;
    float screenLeftEdge = -15f;

    public bool enemyBullet = false;

    void Awake()
    {
        float aspect = (float)Screen.width / Screen.height;
        float worldHeight = Camera.main.orthographicSize * 2;
        float worldWidth = worldHeight * aspect;
        screenRightEdge = worldWidth / 2f;
        screenLeftEdge = screenRightEdge * -1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= screenRightEdge || this.transform.position.x <= screenLeftEdge)
            Destroy(this.gameObject);
    }
}
