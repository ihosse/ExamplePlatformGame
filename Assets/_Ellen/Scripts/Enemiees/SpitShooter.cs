﻿using UnityEngine;

public class SpitShooter : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D projectile;

    [SerializeField]
    private Transform projectileInitialPosition;

    [SerializeField]
    private float shotForce = 200;

    private void Start()
    {
        projectile.gameObject.SetActive(false);
    }

    public void Shot(float horizontalDirection)
    {
        projectile.gameObject.SetActive(true);

        projectile.velocity = Vector2.zero;
        projectile.transform.position = projectileInitialPosition.position;

        Vector2 direction = new(horizontalDirection, 1);
        projectile.AddForce(direction * shotForce);
    }
}