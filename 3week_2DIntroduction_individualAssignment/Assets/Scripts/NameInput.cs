using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }

    private void Update()
    {
        //키보드
        if (playerName.Length > 2 && playerName.Length < 11 && Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
            PlayerPrefs.SetString("PlayerName", playerName);
        }
    }

    //마우스
    public void InputName()
    {
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
    }
}