using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowSystem : MonoBehaviour
{
    public GameObject pausePanel;

    private bool isItMainGameWindow; 
    private Queue<WindowElement> queueOfExecutors;
    void Start()
    {
        queueOfExecutors = new Queue<WindowElement>();
        WindowElement dinoElement = GameObject.Find("DinoWindowElement").GetComponent<WindowElement>();
        WindowElement tamagotchiElement = GameObject.Find("TamagotchiWindowElement").GetComponent<WindowElement>();
        WindowElement clothesElement = GameObject.Find("ClothesWindowElement").GetComponent<WindowElement>();
        WindowElement cablesElement = GameObject.Find("CablesWindowElement").GetComponent<WindowElement>();
        isItMainGameWindow = true;
        dinoElement.ChangeState(true);
        tamagotchiElement.ChangeState(false);
        clothesElement.ChangeState(false);
        cablesElement.ChangeState(false);
        queueOfExecutors.Enqueue(dinoElement);
        queueOfExecutors.Enqueue(tamagotchiElement);
        queueOfExecutors.Enqueue(clothesElement);
        queueOfExecutors.Enqueue(cablesElement);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            WindowElement oldActiveElement= queueOfExecutors.Dequeue();
            oldActiveElement.ChangeState(false);
            queueOfExecutors.Enqueue(oldActiveElement);
            if (oldActiveElement.name == "DinoWindowElement")
            {
                ChangePauseState(true);
            }

            WindowElement newActiveElement = queueOfExecutors.Peek();
            newActiveElement.ChangeState(true);
            if (newActiveElement.name == "DinoWindowElement")
            {
                ChangePauseState(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            queueOfExecutors.Peek().BroadcastCommand("Space");
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            queueOfExecutors.Peek().BroadcastCommand("1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            queueOfExecutors.Peek().BroadcastCommand("2");
        }
    }

    public void ChangePauseState(bool isItPause)
    {
        pausePanel.SetActive(isItPause);
        if (isItPause)
        {
            RunManager.GetInstance().Pause();
        }
        else
        {
            RunManager.GetInstance().Play();
        }
    }
}
