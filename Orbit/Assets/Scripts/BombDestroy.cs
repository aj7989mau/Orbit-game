using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroy : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 5.0f);
    }
}
