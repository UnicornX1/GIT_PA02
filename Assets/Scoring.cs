using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text ScoreTxt;

    public float Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = "Score : " + Score;
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Good")
        {
            print("Yes");
        }
    }
}
