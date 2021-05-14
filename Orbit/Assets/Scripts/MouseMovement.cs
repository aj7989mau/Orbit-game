using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float sensitivityY = 5F;
    public float sensitivityZ = 5F;
    //public float minimumX = -90F;
    //public float maximumX = 90F;
    public float minimumZ = -20F;
    public float maximumZ = 90F;
    float rotationZ = 0F;
    float rotationY = 0f;

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        //rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        rotationZ += Input.GetAxis("Mouse Y") * sensitivityZ;
        rotationZ = Mathf.Clamp(rotationZ, minimumZ, maximumZ);
        transform.localEulerAngles = new Vector3(0, rotationY, -rotationZ);
    }
}
