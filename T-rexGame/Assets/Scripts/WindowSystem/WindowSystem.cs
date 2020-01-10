using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowSystem : MonoBehaviour
{
    private Queue<WindowElement> queueOfExecutors;
    void Start()
    {
        queueOfExecutors = new Queue<WindowElement>();
        WindowElement dinoElement = GameObject.Find("DinoWindowElement").GetComponent<WindowElement>();
        WindowElement tamagotchiElement = GameObject.Find("TamagotchiWindowElement").GetComponent<WindowElement>();
        WindowElement clothesElement = GameObject.Find("ClothesWindowElement").GetComponent<WindowElement>();
        WindowElement cablesElement = GameObject.Find("CablesWindowElement").GetComponent<WindowElement>();
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
            WindowElement newActiveElement = queueOfExecutors.Peek();
            newActiveElement.ChangeState(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            queueOfExecutors.Peek().BroadcastCommand("Space");
        }
    }
}
