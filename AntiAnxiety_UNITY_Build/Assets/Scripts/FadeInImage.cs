using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInImage : MonoBehaviour {

    public Image imageToFade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Color imageToFade_c = imageToFade.GetComponent<Image>().color;
        imageToFade_c.a -= 0.3f * Time.deltaTime;
        imageToFade_c = imageToFade.GetComponent<Image>().color = imageToFade_c;

        if (imageToFade_c.a <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
