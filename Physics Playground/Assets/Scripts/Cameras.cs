using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject GeneralCamera;
    public GameObject Camera1;
    // Start is called before the first frame update
    void Start()
    {
        GeneralCamera.SetActive(true);
        Camera1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Camera1.SetActive(true);
            GeneralCamera.SetActive(false);
        }
    }
}
