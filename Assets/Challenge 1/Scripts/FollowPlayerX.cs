﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(20, 0, 0);
    private Vector3 camRotation = new Vector3(0, -90, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        // transform.position = plane.transform.SetPositionAndRotation(plane.transform.position + 
        // offset, Quaternion.Euler(camRotation));
    }
}
