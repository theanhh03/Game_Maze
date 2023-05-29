using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject Ball;
    private movement player;
    public GameObject winText;
    public GameObject loseText;
    public GameObject door2Win;
    public GameObject door2Lose;
    public GameObject h2p;

    public GameObject btnExit;
    public GameObject btnAgain;

    public Text txtPoint;
    void Start()
    {
        player = Ball.GetComponent<movement>();
        Time.timeScale = 0;
    }
    void Update()
    {
        OpenDoor();
        // Khi nao an Enter game moi bat dau
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            Time.timeScale = 1;
            h2p.SetActive(false);   // How to play
        }
        // Win game
        if (player.win)
        {
            winText.SetActive(true);
            btnAgain.SetActive(true);
            btnExit.SetActive(true);
        }
        // Lose Game
        if (player.isLose)
        {
            loseText.SetActive(true);
            btnAgain.SetActive(true);
            btnExit.SetActive(true);
        }
    }
    // Cong diem
    void OpenDoor()
    {
        if(player.pointGame == 1)
        {
            door2Win.SetActive(false);
            door2Lose.SetActive(false);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayAgain()
    {
        Restart();
    }
}
