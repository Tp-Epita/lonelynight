using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class doorScript : MonoBehaviour {
    public Transform max;
    public setEventText eventText;
    private float distance;
    public GameObject menu;

	public charCtrl maxxxxx;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distance = Mathf.Sqrt(Mathf.Pow((max.position.x - transform.position.x),2)+ Mathf.Pow((max.position.y - transform.position.y), 2)+ Mathf.Pow((max.position.z - transform.position.z), 2));
        if(distance <= 15)
        {
            eventText.text.GetComponent<Text>().text = "Appuyer sur E pour entrer dans le bunker";
            eventText.text.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
	            maxxxxx.SaveInventory();
                SceneManager.LoadScene("Untitled");
            }
        }
        else
        {
            eventText.text.GetComponent<Text>().text = "";
            eventText.text.SetActive(false);
        }
	}
}
