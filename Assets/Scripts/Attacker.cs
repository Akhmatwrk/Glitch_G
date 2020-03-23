using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [Range (0f, 5f)]    [SerializeField] float movingSpeed = 0f;

    GameObject currentTarget;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetMovementSpeed(float movementSpeed)
    {
        movingSpeed = movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * movingSpeed);
        CheckAnimationStatus();
    }

    private void CheckAnimationStatus()
    {
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }

    }

    public void Attack (GameObject target)
    {
        animator.SetBool("isAttacking",true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget) {return;}
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }
    }
}
