using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLauncher : MonoBehaviour
{
    [SerializeField]
    private Transform firePointBomb;
    [SerializeField]
    private Rigidbody bombPrefab;
    [SerializeField]
    private float launchForce = 500f;
    private float nextProjectile = 0.0f;
    private float projectileCoolDown = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && Time.time > nextProjectile)
        {
            LaunchProjectileBomb();
            nextProjectile = Time.time + projectileCoolDown;
        }

    }

    private void LaunchProjectileBomb()
    {
        var projectileBombInstance = Instantiate(
            bombPrefab,
            firePointBomb.position,
            firePointBomb.rotation);


        projectileBombInstance.AddForce(firePointBomb.forward * launchForce);
    }
}
