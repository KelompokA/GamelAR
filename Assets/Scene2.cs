using UnityEngine;
using System.Collections;

public class Scene2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void onClick(int sceneId)
	{
        Application.LoadLevel(sceneId);
    }
    
/*    public void OnPointerClick()
    {
        Application.LoadLevel(1);
    }
    
    public void OnPointerDown()
    {
        Application.LoadLevel(1);
    }   */
}
