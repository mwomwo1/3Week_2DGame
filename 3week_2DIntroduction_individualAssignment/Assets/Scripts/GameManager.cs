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

    public static GameManager instance;
    public Player player;

    private void Awake()
    {
        instance = this;
    }

    //public void GameStart(int id)
    //{
    //    playerId = id;
    //    Debug.Log("id입력 ");
    //    player.gameObject.SetActive(true);
    //    Debug.Log("player 값 변경");
    //    isLive = true;

    //}
}
