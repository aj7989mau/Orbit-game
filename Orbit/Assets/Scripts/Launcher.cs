using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 3000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            LaunchProjectile();
        }

    }

    private void LaunchProjectile()
    {
        var projectileInstance = Instantiate(
            projectilePrefab,
            firePoint.position,
            firePoint.rotation
            );

        projectileInstance.AddForce(firePoint.up * launchForce);
    }
}
