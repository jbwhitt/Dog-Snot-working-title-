﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Transform shootingPoint; //The point on the head where the bullet comes out

    private void Shoot()
    {
        GameObject bulletHolder = Instantiate(bullet, shootingPoint.transform.position, shootingPoint.transform.rotation) as GameObject; //Instantiates bullet and stores it in bulletHolder
        bulletHolder.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(bulletSpeed, 0f), ForceMode2D.Force); //Adds force to bullet
    }

    public GameObject playerHead; //Reference to sprite head

    Vector3 defaultHeadSize; //Will store default head sprite size for scaling
    public float rotationSpeed = 50f; //How fast head can tilt
    public float bulletSpeed = 250f; //Speed of bullet
    public float chargeRate = 1000f; //How quickly bulletspeed scales when charging
    public float maxFireRate = 2f; //
    public float fireRate = 2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(fireRate < maxFireRate) //Refills fireRate, when full you can shoot again
        {
            fireRate += Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            RotateLeft();
        }

        if (Input.GetKey(KeyCode.S))
        {
            RotateRight();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            defaultHeadSize = playerHead.transform.localScale;
        }

        if (Input.GetKey(KeyCode.Space) && fireRate >= maxFireRate)
        {
            bulletSpeed += chargeRate;
            //playerHead.transform.localScale += new Vector3(0.005f, 0.005f, 0.005f);
        }

        if (Input.GetKeyUp(KeyCode.Space) && fireRate >= maxFireRate)
        {
            Shoot();
            bulletSpeed = 250f;
            playerHead.transform.localScale = defaultHeadSize;
            fireRate = 0;
        }
    }

    private void RotateLeft()
    {
        Vector3 currentRotation = playerHead.transform.localEulerAngles; //Gets the head's current rotation value
        if (currentRotation.z >= 85f)
        {
            currentRotation.z -= 2f;
        }
        else
        {
            currentRotation.z += rotationSpeed * Time.deltaTime;
        }
        playerHead.transform.localEulerAngles = currentRotation; //Sets head's rotation value to the new added value
    }

    private void RotateRight()
    {
        Vector3 currentRotation = playerHead.transform.localEulerAngles; //Gets the head's current rotation value
        if (currentRotation.z <= 1f)
        {
            currentRotation.z += 2f;
        }
        else
        {
            currentRotation.z -= rotationSpeed * Time.deltaTime;
        }
        playerHead.transform.localEulerAngles = currentRotation; //Sets head's rotation value to the new added value
    }
}