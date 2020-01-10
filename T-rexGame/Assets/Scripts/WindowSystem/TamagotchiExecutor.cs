using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TamagotchiExecutor : MonoBehaviour, ICommandExecutor
{
    public Button meatButton;
    public Button waterButton;
    public void Execute(string command)
    {
        if (command == "1")
        {
            meatButton.onClick.Invoke();
        }
        if (command == "2")
        {
            waterButton.onClick.Invoke();
        }
    }
}
