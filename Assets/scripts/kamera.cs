using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    //variabel
    [SerializeField] private float sensivity;
    // Start is called before the first frame update

    //referensi
    private Transform parent;
 
        void Start()
    {
        parent = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        parent.Rotate(Vector3.up, mouseX);
    }
}
