using UnityEngine;
using System.Collections;

public class FiducialTargetManager : MonoBehaviour {

    public GameObject fiducial_1Uranus;
    public GameObject fiducial_2sat;
    public GameObject fiducial_6venus;
    public GameObject fiducial_6merc;

    public static FiducialTargetManager S;

	// Use this for initialization
	void Start () {
        S = this;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.U))
        {
            fiducial_1Uranus.transform.GetChild(1).GetComponent<DrawALine>().objB = fiducial_6merc;
            fiducial_1Uranus.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go \nto"+"\n"+"B";
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeFiducial();
            fiducial_2sat.transform.GetChild(0).GetComponent<LineRenderer>().enabled = false;
            fiducial_1Uranus.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go \nto"+"\n"+"B";
        }


        if (Input.GetKeyDown(KeyCode.M))
        {
            //fiducial_2.transform.GetChild(0).GetComponent<LineRenderer>().enabled = true;
            //fiducial_1.transform.GetChild(1).GetComponent<DrawALine>().objB = fiducial_4;
            fiducial_1Uranus.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go \nto" + "\n" + "C";
        }

         if (Input.GetKeyDown(KeyCode.J))
        {
            //fiducial_1.transform.GetChild(1).GetComponent<DrawALine>().objB = fiducial_4;
            fiducial_1Uranus.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go\nto\n?";
            fiducial_1Uranus.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go\nto\n?";
        }

    }

    public void ChangeFiducial()
    {
        //fiducial_1.transform.GetChild(1).GetComponent<DrawALine>().objB = fiducial_3;
    }

    void OnMouseUp()
    {

    }
}
