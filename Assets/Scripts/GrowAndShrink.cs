using UnityEngine;

public class GrowAndShrink : MonoBehaviour
{
    enum JuicyState {
        Normal,
        Grow,
        Shrink,
    };
    JuicyState state = JuicyState.Normal;

    [SerializeField]
    float GrowTo = 1.1f;
    [SerializeField]
    float ShrinkTo = 1f;
    [SerializeField]
    float Rate = 7f;
    [SerializeField]
    float JuiceTime = 0f;

    float timer;
    bool useTimer = false;

    void Start ()
    {
        useTimer = JuiceTime > 0;
        timer = JuiceTime;
    }

    // Update is called once per frame
    void Update ()
    {
        if (state == JuicyState.Normal)
        {
            if (useTimer)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    StartEffect();
                    timer = JuiceTime;
                }
            }
        }
        if (state == JuicyState.Grow)
        {
            float newScale = Mathf.Min(GrowTo, this.transform.localScale.x + Time.deltaTime * Rate);
            this.transform.localScale = new Vector3(newScale, newScale, newScale);
            if (newScale == GrowTo)
            {
                state =  JuicyState.Shrink;
            }
        }
        else if (state == JuicyState.Shrink)
        {
            float newScale = Mathf.Max(ShrinkTo, this.transform.localScale.x - Time.deltaTime * Rate);
            this.transform.localScale = new Vector3(newScale, newScale, newScale);
            if (newScale == ShrinkTo)
            {
                state =  JuicyState.Normal;
            }
        }
    }

    public void StartEffect()
    {
        state = JuicyState.Grow;
    }

    public void StopEffect()
    {
        state = JuicyState.Normal;
    }
}
