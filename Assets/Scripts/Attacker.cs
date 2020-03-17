﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [Range (0f, 5f)]    [SerializeField] float movingSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetMovementSpeed(float movementSpeed)
    {
        movingSpeed = movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * movingSpeed);
    }
}
