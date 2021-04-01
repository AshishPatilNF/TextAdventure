using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextAdventure : MonoBehaviour
{
    [SerializeField]
    Text textcomponent;

    [SerializeField]
    State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textcomponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();

        if(Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    private void ManageStates()
    {
        var nextStates = state.GetNextStates();

        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            state = nextStates[1];
        }
        textcomponent.text = state.GetStateStory();
    }
}
