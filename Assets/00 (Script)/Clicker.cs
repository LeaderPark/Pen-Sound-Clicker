using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{   
    public int penexp;

    void Update() 
    {
        penexp = (int)(10 * Mathf.Pow(1.06f, 10) - Mathf.Pow(1.06f, (10 + DataManager.Instance.penlevel)) / (1 - 1.06));
    }
    
    public void ScreenClick()
    {
        Debug.Log("화면 클릭");
        DataManager.Instance.exp += penexp;
    }
}
