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
            ParticleSystem newObj = Instantiate(fire, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(newObj, 15f);
        }
        
    }

}
