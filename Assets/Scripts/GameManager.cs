using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject gameClear;
    [SerializeField] private GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; // 時を動かす
    }

    // Update is called once per frame
    void Update()
    {
        // 残ったブロックの数をカウント
        var targetCount = GameObject.FindObjectsOfType<Target>().Count();

        // Game Clear
        if (targetCount < 1)
        {
            ToClear();
        }
    }

    public void ToGameOver()
    {
        Time.timeScale = 0; // 時を止める
        gameOver.SetActive(true);
        restartButton.SetActive(true);
    }

    private void ToClear()
    {
        Time.timeScale = 0; // 時を止める
        gameClear.SetActive(true);
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
