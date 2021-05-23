using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleMovement : MonoBehaviour
{
    public float levelLoadDelay;
    public float orbitSpeed;
    public float exitSpeed;
    public GameObject orbitCenter;
    public GameObject titleObject;

    void Update()
    {
        transform.RotateAround(orbitCenter.transform.position, titleObject.transform.up, -orbitSpeed * Time.deltaTime);

        if (Input.GetKeyDown("space"))  
        {
            orbitSpeed = exitSpeed;
            StartCoroutine(LoadLevel());
        }
    }
    private IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(levelLoadDelay);
        SceneManager.LoadScene("Level_1");
    }
}