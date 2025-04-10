using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Constants
    [SerializeField]
    float walkSpeed = 2f;
    bool canMoveLeft = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        if (direction < 0 && !canMoveLeft)
        {
            return;
        }
        else if (direction > 0)
        {
            if (!canMoveLeft)
                canMoveLeft = true;
        }

        transform.Translate(walkSpeed * direction * Time.deltaTime, 0, 0);
        transform.localScale = new Vector3(direction < 0 ? -1 : 1, 1, 1);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.tag == "left_wall")
            canMoveLeft = false;
    }
}
