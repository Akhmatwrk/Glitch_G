using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly_projectile : MonoBehaviour
{
    [SerializeField] float movingSpeed = 0f;



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * movingSpeed);
    }
}
