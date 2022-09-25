using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Vector3 startPosition;
    float shakeTimer = 0f;
    float shakeTimerMax = .75f;

    void Start ()
    {
        startPosition = transform.position;
    }

    void Update ()
    {
        Vector3 newPos;
        newPos = startPosition;
        if (shakeTimer > 0)
        {
            shakeTimer = shakeTimer - Time.deltaTime;
            if (shakeTimer > 0)
            {
                newPos.x =  newPos.x + Random.Range(shakeTimer * -.20f, shakeTimer * .20f);
                newPos.y =  newPos.y + Random.Range(shakeTimer * -.20f, shakeTimer * .20f);
            }
            transform.position = newPos;
        }
    }

    public void StartShake()
    {
        shakeTimer = shakeTimerMax;
    }
}
