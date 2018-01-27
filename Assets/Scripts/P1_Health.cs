using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Health : MonoBehaviour {

    // Use this for initialization
    void Start () {
        this.transform.GetChild(0).transform.gameObject.SetActive(false);
        this.transform.GetChild(1).transform.gameObject.SetActive(false);
        this.transform.GetChild(2).transform.gameObject.SetActive(false);
        this.transform.GetChild(3).transform.gameObject.SetActive(false);
        this.transform.GetChild(4).transform.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>().health == 5)
        {
            this.transform.GetChild(0).transform.gameObject.SetActive(true);
            this.transform.GetChild(1).transform.gameObject.SetActive(true);
            this.transform.GetChild(2).transform.gameObject.SetActive(true);
            this.transform.GetChild(3).transform.gameObject.SetActive(true);
            this.transform.GetChild(4).transform.gameObject.SetActive(true);
        }

        else if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>().health == 4)
        {
            this.transform.GetChild(0).transform.gameObject.SetActive(false);
            this.transform.GetChild(1).transform.gameObject.SetActive(true);
            this.transform.GetChild(2).transform.gameObject.SetActive(true);
            this.transform.GetChild(3).transform.gameObject.SetActive(true);
            this.transform.GetChild(4).transform.gameObject.SetActive(true);
        }

        else if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>().health == 3)
        {
            this.transform.GetChild(0).transform.gameObject.SetActive(false);
            this.transform.GetChild(1).transform.gameObject.SetActive(false);
            this.transform.GetChild(2).transform.gameObject.SetActive(true);
            this.transform.GetChild(3).transform.gameObject.SetActive(true);
            this.transform.GetChild(4).transform.gameObject.SetActive(true);
        }
        else if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>().health == 2)
        {
            this.transform.GetChild(0).transform.gameObject.SetActive(false);
            this.transform.GetChild(1).transform.gameObject.SetActive(false);
            this.transform.GetChild(2).transform.gameObject.SetActive(false);
            this.transform.GetChild(3).transform.gameObject.SetActive(true);
            this.transform.GetChild(4).transform.gameObject.SetActive(true);
        }

        else if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>().health == 1)
        {
            this.transform.GetChild(0).transform.gameObject.SetActive(false);
            this.transform.GetChild(1).transform.gameObject.SetActive(false);
            this.transform.GetChild(2).transform.gameObject.SetActive(false);
            this.transform.GetChild(3).transform.gameObject.SetActive(false);
            this.transform.GetChild(4).transform.gameObject.SetActive(true);
        }

        else if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>().health == 0)
        {
            this.transform.GetChild(0).transform.gameObject.SetActive(false);
            this.transform.GetChild(1).transform.gameObject.SetActive(false);
            this.transform.GetChild(2).transform.gameObject.SetActive(false);
            this.transform.GetChild(3).transform.gameObject.SetActive(false);
            this.transform.GetChild(4).transform.gameObject.SetActive(false);
        }

    }
}
