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

	public bool swiHT = false;
	public bool swiAU= false;
	public void apapun()
	{
		if (swiHT==false)
		{	GameObject.FindGameObjectWithTag ("AboutUs").transform.position = new Vector2 (0, 1000);
			swiAU = false;
			GameObject.FindGameObjectWithTag ("HowTo").transform.position = new Vector2 (412, 127);
			swiHT = true;
		}
		else if (swiHT==true)
		{		GameObject.FindGameObjectWithTag ("HowTo").transform.position = new Vector2 (0, 1000);
			swiHT= false;
		}
	}
    
	public void apapun1()
	{
		if (swiAU==false)
		{	GameObject.FindGameObjectWithTag ("HowTo").transform.position = new Vector2 (0, 1000);
			swiHT= false;	
			GameObject.FindGameObjectWithTag ("AboutUs").transform.position = new Vector2 (412, 127);
			swiAU= true;
		}
		else if (swiAU==true)
		{		GameObject.FindGameObjectWithTag ("AboutUs").transform.position = new Vector2 (0, 1000);
			swiAU= false;
		}
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
