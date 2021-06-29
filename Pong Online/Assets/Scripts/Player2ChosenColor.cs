using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2ChosenColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().color = MenuScript.Player2Color;
    }
}
