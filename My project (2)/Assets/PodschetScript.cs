using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PodschetScript : MonoBehaviour
{
    public Text Podschet;
    public Collision CubeScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Podschet.text = "Score: " + CubeScript.score;
    }
}
