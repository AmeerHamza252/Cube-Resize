using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAutomation : MonoBehaviour
{
    Transform player;
    public Vector3[] scaleChange;
    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (num < scaleChange.Length)
            {
                player.localScale = scaleChange[num];
                num++;
            }
            else
            {
                num = 0;
            }


        }
    }
}
