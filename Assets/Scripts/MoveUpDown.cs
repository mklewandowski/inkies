using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float topY;
    public float bottomY;
    public float offsetY;
    private bool movingDown = true;
    public float moveSpeedMin = .25f;
    public float moveSpeedMax = 1f;
    public float moveSpeed = .75f;
    public bool bounceOn = false;

    // Use this for initialization
    void Start () {
        if (topY == 0 && bottomY == 0)
        {
            topY = this.transform.localPosition.y + offsetY;
            bottomY = this.transform.localPosition.y - offsetY;
        }
        if (moveSpeedMin != moveSpeedMax)
        {
            moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
        }
    }

    // Update is called once per frame
    void Update () {
        if (bounceOn)
        {
            if (movingDown)
            {
                Vector3 newpos = this.transform.localPosition;
                newpos.y = Mathf.Max (bottomY, newpos.y - moveSpeed * Time.deltaTime);
                this.transform.localPosition = newpos;
                if (newpos.y == bottomY)
                    movingDown = false;
            }
            else
            {
                Vector3 newpos = this.transform.localPosition;
                newpos.y = Mathf.Min (topY, newpos.y + moveSpeed * Time.deltaTime);
                this.transform.localPosition = newpos;
                if (newpos.y == topY)
                    movingDown = true;
            }
        }
    }

    public void StartEffect()
    {
        bounceOn = true;
    }
}
