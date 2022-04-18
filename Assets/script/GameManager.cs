using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gamePause;
    public GameObject gameWin;
    public GameObject gameLose;
    public GameState currentGameState = GameState.menu;

    public enum GameState
    {
        menu,
        inGame,
        gameOver
    }

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == 0)
            {
                gamePause.SetActive(false);
                Time.timeScale = 1;
            }
            else if (Time.timeScale == 1)
            {
                gamePause.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        }

        if (ui.score >= 100)
        {
            gameWin.SetActive(true);
            Time.timeScale = 0;
        }

        if (Spawner.barrier == 6)
        {
            Debug.Log(Spawner.barrier);
            gameLose.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
