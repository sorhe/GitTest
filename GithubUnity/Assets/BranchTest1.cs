﻿using UnityEngine;
using System.Collections;

public class BranchTest1 : MonoBehaviour
{
    public float speed = 10f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * transform.forward, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-speed * transform.forward, Space.World);
        }
    }
}
