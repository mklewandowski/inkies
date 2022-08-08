using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAndHide : MonoBehaviour
{
    enum JuicyState {
        Normal,
        Shrink,
    };
    JuicyState state = JuicyState.Normal;

    [SerializeField]
    float ShrinkTo = .1f;
    [SerializeField]
    float Rate = 7f;

    // Update is called once per frame
    void Update()
    {
        if (state == JuicyState.Shrink)
        {
            float newScale = Mathf.Max(ShrinkTo, this.transform.localScale.x - Time.deltaTime * Rate);
            this.transform.localScale = new Vector3(newScale, newScale, newScale);
            if (newScale == ShrinkTo)
            {
                state =  JuicyState.Normal;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void StartEffect()
    {
        state = JuicyState.Shrink;
    }

    public void StopEffect()
    {
        state = JuicyState.Normal;
    }

    public bool IsShrinking()
    {
        return (state == JuicyState.Shrink);
    }
}
