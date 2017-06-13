using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public GameObject fade;
    public AudioSource BGM;
    public bool gameStarted;

	// Use this for initialization
	void Start () {
        gameStarted = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameStarted == true)
        {
            BGM.gameObject.GetComponent<AudioSource>().volume -= 0.35f * Time.deltaTime;
        }
	}

    public void StartGame()
    {
        fade.SetActive(true);
        gameStarted = true;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
