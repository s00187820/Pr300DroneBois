using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public bool isFiring;

    public BulletController bullet;
    public float bulletSpeed;

    public float timeShots;
    public float shotCount;

    public Transform firePoint;

    void Start()
    {
        
    }

    
    void Update()
    {
       if(isFiring)
        {
            shotCount -= Time.deltaTime;
            if(shotCount <= 0)
            {
                shotCount = timeShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                newBullet.speed = bulletSpeed;
            }
        }
       else
        {
            shotCount = 0;
        }
    }
}
