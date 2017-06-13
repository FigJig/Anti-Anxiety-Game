using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GeneralFunctions : MonoBehaviour {

    public float levelCoolDown;
    public Image fade;

    // Use this for initialization
    void Start () {
        Screen.SetResolution(640, 960, false);
    }

    // Update is called once per frame
    void Update() {

        levelCoolDown -= 1f * Time.deltaTime;

        if (levelCoolDown <= 0f)
        {
            Debug.Log("level finished");
            FadeScript.fadeToBlack = true;
            FadeScript.changeLevel = true;
            levelCoolDown = 13f;
        }

        if (levelCoolDown > 8f && levelCoolDown < 10f)
        {
            FadeScript.fadeToBlack = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Game quit");
            //Application.Quit();
            Application.LoadLevel("Menu");
        }
    
	}
}
