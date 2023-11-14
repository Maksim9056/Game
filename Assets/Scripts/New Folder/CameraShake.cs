using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeDuration = 0.1f;
    public float shakeIntensity = 0.1f;

    private Vector3 originalPosition;
    private float shakeEndTime;

    private void Awake()
    {
        originalPosition = transform.localPosition;
    }

    private void Update()
    {
        if (Time.time <= shakeEndTime)
        {
            transform.localPosition = originalPosition + Random.insideUnitSphere * shakeIntensity;
        }
        else
        {
            transform.localPosition = originalPosition;
        }
    }

    public void Shake()
    {
        shakeEndTime = Time.time + shakeDuration;
    }
}
