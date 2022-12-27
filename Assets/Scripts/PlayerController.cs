using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private string horizontalAxisName = "Horizontal";
    [SerializeField] private float rangeX = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis(horizontalAxisName);

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Constraint
        // Left wall
        if (transform.position.x < -rangeX)
        {
            var copiedPos = transform.position;
            copiedPos.x = -rangeX;
            transform.position = copiedPos;
        }
        // Right wall
        else if (rangeX < transform.position.x)
        {
            var copiedPos = transform.position;
            copiedPos.x = rangeX;
            transform.position = copiedPos;
        }
    }
}
