using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class move_cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //make sure the cube is in the center of the screen
    }
    // Update is called once per frame
    void Update()
    {
                                                                  transform.Translate(Vector3.right * Time.deltaTime * 10f);
                                                                  }
