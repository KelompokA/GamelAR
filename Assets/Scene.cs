using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
//using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	    if(Input.GetKeyDown(KeyCode.Space))Application.LoadLevel(1);
//        
//        if (Input.GetMouseButtonDown(0))
//        {
//            Application.LoadLevel(1);
//        }
	}
    
    public void onClick(){
    
//        SceneManager.LoadScene(1);
        Application.LoadLevel(1);
    }
}

//
//public class Scene : MonoBehaviour 
// {
//     public void NextSceneButton(int index)
//     {
//         Application.LoadLevel(index);
//         Debug.Log("AADC");
//     }
// 
//     public void NextSceneButton(string levelName)
//     {
//         Application.LoadLevel(levelName);
//         Debug.Log("AADC");
//     }
// }