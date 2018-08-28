using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls how the lava moves and the speed at which it rises

public class LavaMove : MonoBehaviour {

    Transform self;

    private int counter;

    public float speed = 1;

    // Finds the transform component so it can be altered, and then starts the infinite loop in speedUp()
    void Start () {
        self = GetComponent<Transform>();
        StartCoroutine(speedUp());
        counter = 0;
    }
	
    // Once per frame, translate the lava up
    void Update () {
        self.Translate(Vector2.up * Time.deltaTime * speed);
    }

    //constantly increases the speed of the lava, but after 50 increases, the speed stops increasing and moves at a constant rate
    IEnumerator speedUp()
    {
        while (true)
        {
            if (counter < 50) {
                yield return new WaitForSeconds(1);
                speed *= 1.02f;
                counter++;
            }
            else
            {
                break;
            }
        }

    }
}
