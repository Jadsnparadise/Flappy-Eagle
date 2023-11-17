using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoviment : MonoBehaviour
{
    private Transform parent;
    private Vector3 goingForward;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(parent.position.x + 6, 3.5f, transform.position.z); // Trava o X e o Z da camera ao do player e o Y a uma altura de 3.5

    }
}
