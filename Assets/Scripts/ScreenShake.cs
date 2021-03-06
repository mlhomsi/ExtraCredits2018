﻿using UnityEngine;

using System.Collections;



public class CameraShake : MonoBehaviour
{


    public Transform CamTransform;
    
    public float ShakeDuration;
    
    public float ShakeAmount;
    
    public float DecreaseFactor;
    
    public Vector3 OriginalPos;

    void Awake()

    {

        if (CamTransform == null)

        {

            CamTransform = GetComponent<Transform>();

        }

    }



    void OnEnable()

    {

        OriginalPos = CamTransform.localPosition;

    }



    void Update()

    {

        if (ShakeDuration > 0)

        {

            CamTransform.localPosition = OriginalPos + Random.insideUnitSphere * ShakeAmount;



            ShakeDuration -= Time.deltaTime * DecreaseFactor;

        }

        else

        {

            ShakeDuration = 0f;

            CamTransform.localPosition = OriginalPos;

        }

    }

}