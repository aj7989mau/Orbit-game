using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class StickToParent : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.localPosition = new Vector3(transform.localScale.x*0.5f, 0, 0); //Sets the position to the same as parent
        transform.LookAt(new Vector3 (0,0,0));          //Looks at center of map
        gameObject.tag = "ColObj";
        Quaternion.Inverse(transform.rotation);         //Reverse rotation
    }
}
