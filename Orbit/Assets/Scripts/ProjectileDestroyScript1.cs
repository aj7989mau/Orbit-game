using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroyScript : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 3.0f);
    }

 
}
