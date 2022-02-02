using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenuUI : MonoBehaviour
{
    [SerializeField]
    private Text playerInGame;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.instance != null)
            playerInGame.text = "Hi! " + GameManager.instance.playerName + ". Wanna play a game?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu()// ABSTRACTION
    {
        SceneManager.LoadScene(0);
    }
}
