using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombColliderScript : MonoBehaviour
{
    public ParticleSystem fire = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ColObj")
        {
            Instantiate(fire, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        
    }

}
