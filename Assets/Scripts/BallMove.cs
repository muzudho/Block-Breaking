using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] private float rightSpeed;
    [SerializeField] private float upSpeed;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * Time.deltaTime * rightSpeed);
        transform.Translate(Vector3.up * Time.deltaTime * upSpeed);
    }

    private void Update()
    {
        // Game Over
        if(transform.position.y <= -4.5f) // -4.4f が底辺、それ以下は画面外を想定
        {
            rightSpeed = 0f;
            upSpeed = 0f;
            gameManager.ToGameOver();   
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Ball collide to {other.gameObject.name}");

        if (other.gameObject.name == "Wall Top")
        {
            upSpeed *= -1; // 上下反転
        }
        else if (other.gameObject.name == "Player")
        {
            upSpeed *= -1; // 上下反転
        }
        else if (other.gameObject.name == "Wall Left")
        {
            rightSpeed *= -1; // 左右反転
        }
        else if (other.gameObject.name == "Wall Right")
        {
            rightSpeed *= -1; // 左右反転
        }
        // ブロックの天面
        else if (other.gameObject.name == "Up Side")
        {
            upSpeed *= -1; // 上下反転
        }
        // ブロックの底面
        else if (other.gameObject.name == "Bottom Side")
        {
            upSpeed *= -1; // 上下反転
        }
        // ブロックの左面
        else if (other.gameObject.name == "Left Side")
        {
            rightSpeed *= -1; // 左右反転
        }
        // ブロックの右面
        else if (other.gameObject.name == "Right Side")
        {
            rightSpeed *= -1; // 左右反転
        }
    }
}
