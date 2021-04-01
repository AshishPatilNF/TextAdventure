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

        for(int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1 + i))
            {
                state = nextStates[i];
            }
        }
        textcomponent.text = state.GetStateStory();
    }
}
