using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    // Update is called once per frame
    void Update () 
	{
		transform.Rotate (new Vector3 (90, 0, 0) * Time.deltaTime);
	}
}
