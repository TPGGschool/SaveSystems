using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class startText : MonoBehaviour
{

    public TextMeshProUGUI text;
    public BetweenScenes betweenScenesScr;


    // Start is called before the first frame update
    void Start()
    {
        betweenScenesScr = FindObjectOfType<BetweenScenes>();
    }

    // Update is called once per frame
    void Update()
    {

        text.text = betweenScenesScr.input;

    }


}
