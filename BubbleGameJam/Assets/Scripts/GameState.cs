using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private void Start()
    {
        //Variable Name, Value
        PlayerPrefs.SetString("savedGameState", "Wake Up");
    }
}
