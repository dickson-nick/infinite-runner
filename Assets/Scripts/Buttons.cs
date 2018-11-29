using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/*******************************************
 *  Dictates behavior of the 'Play' button *
 *               on Main Menu              *
 ******************************************/
public class Buttons : MonoBehaviour {
    public TextMesh textMesh;
    public RectTransform rectTransform;

    public string sceneToLoad;

	// Use this for initialization
	void Start () {
        AssetBundle.LoadFromFile("Assets/Scenes");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        rectTransform.localScale = new Vector3(1.1f, 1.1f, 1.0f);
        textMesh.color = new Color(0.47f, 0.77f, 1.0f, 1.0f);
    }

    void OnMouseExit()
    {
        rectTransform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        textMesh.color = new Color(1, 1, 1, 1);
    } 

    void OnMouseDown()
    {
        if (textMesh.text == "Play")
        {
            sceneToLoad = "Level01";
        }
        else if (textMesh.text == "Level Select")
        {
            sceneToLoad = "Level02";
        }

        SceneManager.LoadScene(sceneToLoad);
    }
}
