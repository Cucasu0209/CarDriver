using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class TestSpline : MonoBehaviour
{
    [SerializeField] private SplineAnimate Animate;

    private void Start()
    {
        Animate.Play();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Animate.IsPlaying) Animate.Pause();
            else Animate.Play();
        }


    }
}
