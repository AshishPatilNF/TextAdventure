using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextAdventure : MonoBehaviour
{
    [SerializeField]
    Text textcomponent;

    // Start is called before the first frame update
    void Start()
    {
        textcomponent.text = "Starting of the game";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
