using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FelocityAmount : MonoBehaviour
{
    public int player1felocity = 4;
    public int player2felocity = 4;
    public Text P1text;
    public Text P2text;
    // Start is called before the first frame update
    public void AddP1felocity()
    {
        player1felocity++;
        P1text.text = player1felocity.ToString();
    }
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
