using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody enemyRB;
    public float moveSpeed;

    public PlayerController mainPlayer;
    
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        mainPlayer = FindObjectOfType<PlayerController>();
    }

    void FixedUpdate()
    {
        enemyRB.velocity = (transform.forward * moveSpeed);
    }
    
    void Update()
    {
        transform.LookAt(mainPlayer.transform.position);
    }
}
