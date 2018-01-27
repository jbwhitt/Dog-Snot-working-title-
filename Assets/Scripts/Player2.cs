using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    public int health;

	void Update()
    {
        if (health > 5)
            health = 5;
	}
}
