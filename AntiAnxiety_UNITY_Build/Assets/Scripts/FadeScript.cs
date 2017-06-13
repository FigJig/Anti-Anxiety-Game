using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {

    public GameObject mainCamera;
    public static bool fadeToBlack;
    Color fade_c;
    public Transform[] cameraMounts;
    public Transform levelSpawn;
    public int cameraIndex;
    public static bool changeLevel;
    public GameObject[] gameLevels;
    public GameObject currentLevel;

    // Use this for initialization
    void Start () {
        changeLevel = true;
        fadeToBlack = false;
        fade_c = gameObject.GetComponent<Image>().color;
        currentLevel = Instantiate(gameLevels[cameraIndex], levelSpawn.position, levelSpawn.rotation) as GameObject;
    }
	
	// Update is called once per frame
	void Update () {

      

        if (fadeToBlack == false)
        {
            FadeIn();
        }

        if (fadeToBlack == true)
        {
            
            FadeOut();
        }
	}

    void FadeIn()
    {
        fade_c.a -= 1f * Time.deltaTime;
        gameObject.GetComponent<Image>().color = fade_c;

        if (fade_c.a <= 0f)
        {
            fade_c.a = 0f;
          //  gameObject.GetComponent<Image>().enabled = false;
        }
    }

    void FadeOut()
    {
       
        fade_c.a += 1f * Time.deltaTime;
        gameObject.GetComponent<Image>().color = fade_c;

        if (fade_c.a >= 1f)
        {
            fade_c.a = 1f;
           // gameObject.GetComponent<Image>().enabled = false;
        }
        if (fade_c.a == 1f && changeLevel == true)
        {
            Destroy(currentLevel);
            NextLevel();
            changeLevel = false;
        }
    }

    public void NextLevel()
    {
       
        if (cameraIndex < gameLevels.Length - 1)
        {
            cameraIndex ++;
            currentLevel = Instantiate(gameLevels[cameraIndex], levelSpawn.position, levelSpawn.rotation) as GameObject;
            //currentLevel = gameLevels[cameraIndex];
           // mainCamera.gameObject.GetComponent<MenuCamControl>().currentMount = cameraMounts[cameraIndex];
           // dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            cameraIndex = 0;
            // mainCamera.gameObject.GetComponent<MenuCamControl>().currentMount = cameraMounts[0];
         currentLevel = Instantiate(gameLevels[0], levelSpawn.position, levelSpawn.rotation) as GameObject;
            //dialoguePanel.SetActive(false);
        }
    }
}
