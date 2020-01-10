using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowElement : MonoBehaviour
{
    public GameObject activeFrame;
    public GameObject executor;
    public void ChangeState(bool isActive)
    {
        activeFrame.SetActive(isActive);
    }

    public void BroadcastCommand(string command)
    {
        executor.GetComponent<ICommandExecutor>().Execute(command);
    }
}
