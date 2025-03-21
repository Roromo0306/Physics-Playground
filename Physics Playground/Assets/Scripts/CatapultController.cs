using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultController : MonoBehaviour
{
    public Rigidbody proyectil;
    public float fuerzaLanzamiento = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            proyectil.AddForce(Vector3.up * fuerzaLanzamiento);
        }
    }
}
