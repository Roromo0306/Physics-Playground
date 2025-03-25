using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject GeneralCamera;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;
    public GameObject Camera6;
    // Start is called before the first frame update
    void Start()
    {
        GeneralCamera.SetActive(true);
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Camera1.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Camera2.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera1.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Camera3.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Camera4.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera5.SetActive(false);
            Camera6.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Camera5.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera6.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Camera6.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera5.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Time.timeScale = 1;
        }
    }
}
