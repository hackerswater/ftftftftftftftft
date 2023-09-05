using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //on computer press the space key to start the game
        //on mobile press the button to start the game
    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector3.forward * 10f * Time.deltaTime);
    transform.Translate(Vector3.right * 10f * Time.deltaTime);
    }
}
