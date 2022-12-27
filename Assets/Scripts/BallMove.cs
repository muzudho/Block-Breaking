using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] private float rightSpeed;
    [SerializeField] private float upSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * Time.deltaTime * rightSpeed);
        transform.Translate(Vector3.up * Time.deltaTime * upSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Ball collide to {other.gameObject.name}");

        if (other.gameObject.name == "Wall Top")
        {
            upSpeed *= -1; // �㉺���]
        }
        else if (other.gameObject.name == "Player")
        {
            upSpeed *= -1; // �㉺���]
        }
        else if (other.gameObject.name == "Wall Left")
        {
            rightSpeed *= -1; // ���E���]
        }
        else if (other.gameObject.name == "Wall Right")
        {
            rightSpeed *= -1; // ���E���]
        }
        // �u���b�N�̓V��
        else if (other.gameObject.name == "Up Side")
        {
            upSpeed *= -1; // �㉺���]
        }
        // �u���b�N�̒��
        else if (other.gameObject.name == "Bottom Side")
        {
            upSpeed *= -1; // �㉺���]
        }
        // �u���b�N�̍���
        else if (other.gameObject.name == "Left Side")
        {
            rightSpeed *= -1; // ���E���]
        }
        // �u���b�N�̉E��
        else if (other.gameObject.name == "Right Side")
        {
            rightSpeed *= -1; // ���E���]
        }
    }
}
