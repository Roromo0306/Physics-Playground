using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject GeneralCamera;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    // Start is called before the first frame update
    void Start()
    {
        GeneralCamera.SetActive(true);
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Camera1.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Camera2.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera1.SetActive(false);
            Camera3.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Camera3.SetActive(true);
            GeneralCamera.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(false);
        }
    }
}
