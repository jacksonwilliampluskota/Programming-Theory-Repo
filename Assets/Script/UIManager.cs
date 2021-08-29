using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text playerName;
    void Start()
    {
        playerName.text = $"Player: {MainManager.Instance.playerName}";
    }

}
