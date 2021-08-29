using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    private string input;

    public void ClickStartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void SaveInput(string s)
    {
        input = s;
        Debug.Log(input);
        MainManager.Instance.SavePlayer(input);

    }
}
