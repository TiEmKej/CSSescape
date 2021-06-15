using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    public static audioPlayer _instance;
    public static audioPlayer Instance
    {
        get {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<audioPlayer>();
             
                if (_instance == null)
                {
                    GameObject container = new GameObject("Bicycle");
                    _instance = container.AddComponent<audioPlayer>();
                }
            }
     
            return _instance;
        }
    }
}
