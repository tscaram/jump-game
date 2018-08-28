using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMove : MonoBehaviour {

    Transform self;

    private int counter;

    public float speed = 1;

	// Use this for initialization
	void Start () {
        self = GetComponent<Transform>();
        StartCoroutine(speedUp());
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        self.Translate(Vector2.up * Time.deltaTime * speed);
	}

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
