using System.Collections;
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
    public float rotationSpeed = 50f;
    public float bulletSpeed = 250f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
            Shoot();
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
