﻿using UnityEngine;
using System.Collections.Generic;

public class rotationScript : MonoBehaviour
{

    //6.963


    public bool isClockwise = true;
    public float rotationPeriodInHours;

    //Transform[] Children;
    List<Transform> children;

    public Vector3 offsetAxis;
    public Vector3 rotationAxis = Vector3.up;

    private const float timescale = 1f;

    //Rotation progress between 0 and 1
    private float currentTime;
    float prevRotationAngle;

    void Start()
    {
        children = new List<Transform>();
        Transform[] childrenArray = GetComponentsInChildren<Transform>();
        foreach (Transform child in childrenArray)
        {
            if (child.parent == transform)
                children.Add(child);
            //child is your child transform
        }
        
        currentTime = 0f;
        prevRotationAngle = 0;
    }

    void Update()
    {
        //Debug.Log((Time.deltaTime * timescale / rotationPeriodInHours).ToString("F9"));
        currentTime += Time.deltaTime * timescale / rotationPeriodInHours;


        currentTime %= 1.0f;
        

        float currentRotationAngle = currentTime * 360f;

        if ( !isClockwise )
        {
            currentRotationAngle *= -1f;
        }

        transform.DetachChildren();

        //Debug.Log(currentRotationAngle);
        //transform.rotation = Quaternion.AngleAxis( currentRotationAngle, rotationAxis);
        //transform.rotation = Quaternion.identity;
        transform.Rotate(rotationAxis, currentRotationAngle - prevRotationAngle, Space.Self);
        //transform.Rotate(offsetAxis);
        /*
        if (camera != null)
        {
            camera.transform.parent = transform;
        }*/
        
        foreach (Transform child in children)
        {
            child.parent = transform;
            //child is your child transform
        }
        prevRotationAngle = currentRotationAngle;

        //transform.rotation = Quaternion.AngleAxis(offsetValue, offsetAxis);
    }
}