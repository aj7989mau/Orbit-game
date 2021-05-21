using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    public float size;
    public float fullSize;
    public float speed;
    private float currentSize;
    private RectTransform crosshair;
    private AudioSource audioSrc;

    bool isMoving
    {
        get
        {
            if ((Input.GetAxis("Horizontal") != 0) || Input.GetAxis("Vertical") != 0 || Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
      
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        crosshair = GetComponent<RectTransform>();
        currentSize = size;
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        crosshair.sizeDelta = new Vector2(size, size);
        

        if (isMoving)
        {
            currentSize = Mathf.Lerp(currentSize, fullSize, Time.deltaTime * speed);
        }

        else
        {
            currentSize = Mathf.Lerp(currentSize, size, Time.deltaTime * speed);
        }

        crosshair.sizeDelta = new Vector2(currentSize, currentSize);

        if (Input.GetMouseButtonDown(0))
        {
            audioSrc.Play();
        }
    }
}
