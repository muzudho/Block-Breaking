using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject clearGo;
    [SerializeField] private GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; // ���𓮂���
    }

    // Update is called once per frame
    void Update()
    {
        // �c�����u���b�N�̐����J�E���g
        var targetCount = GameObject.FindObjectsOfType<Target>().Count();

        if (targetCount < 0)
        {
            ToClear();
        }
    }

    public void ToGameOver()
    {
        Time.timeScale = 0; // �����~�߂�
        gameOver.SetActive(true);
        restartButton.SetActive(true);
    }

    private void ToClear()
    {
        Time.timeScale = 0; // �����~�߂�
        clearGo.SetActive(true);
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        Debug.Log("RestartGame");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
