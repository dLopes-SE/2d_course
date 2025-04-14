using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Constants
    [SerializeField]
    float walkSpeed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(walkSpeed * direction * Time.deltaTime, 0, 0);
        transform.localScale = new Vector3(direction < 0 ? -1 : 1, 1, 1);
    }
}
