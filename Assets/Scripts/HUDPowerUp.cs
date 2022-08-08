using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDPowerUp : MonoBehaviour
{

    float timer = 0f;
    float timerMax = 3f;

    public void Hide()
    {
        this.GetComponent<MoveNormal>().MoveUp();
    }

    public void Show()
    {
        timer = timerMax;
        this.GetComponent<MoveNormal>().MoveDown();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Hide();
            }
        }
    }
}
