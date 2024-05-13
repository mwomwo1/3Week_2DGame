using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("#Game Control")]
    public bool isLive;

    [Header("#Player Info")]
    public int playerId;
    public string playerName;

    public void GameStart()
    {
        isLive = true;
    }

    public void GameStart(int id)
    {
        playerId = id;
    }

}
