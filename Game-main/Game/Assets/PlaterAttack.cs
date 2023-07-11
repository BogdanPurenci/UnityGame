using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterAttack : MonoBehaviour
{
    private Animator anim;
    private PlayerMovement playerMovement;
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;
    private float cooldownTimer = Mathf.Infinity;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        if(Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
        {
            Attack();
        }
        cooldownTimer += Time.deltaTime;
    }
    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[FireBall()].transform.position = firePoint.position;
        fireballs[FireBall()].GetComponent<ProjectTile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private int FireBall()
    {
        for(int i = 0; i<fireballs.Length;i++)
        {
            if (!fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}
