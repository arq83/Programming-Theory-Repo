using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenuUI : MonoBehaviour
{
    [SerializeField]
    private Text PlayerInGame;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInGame.text = "Hi! " + GameManager.Instance.PlayerName + ". Wanna play a game?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
