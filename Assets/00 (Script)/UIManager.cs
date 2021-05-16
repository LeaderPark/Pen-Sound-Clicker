using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject CollectionInfo;
    public GameObject OptionInfo;
    public GameObject ShopInfo;
    
    public Text OptionBackSoundText;
    public Text OptionEffectSoundText;
    public Text exp;

    private bool isBackSound = false;
    private bool isEffectSound = false;



    private void Update() 
    {
        DataManager.Instance.levelUpCost = (int)(50 * (Mathf.Pow(1.07f, DataManager.Instance.penlevel-1) ));
        DataManager.Instance.clickpower = (int)(DataManager.Instance.levelUpCost * 0.4);

        exp.text = DataManager.Instance.exp.ToString();
    }

    
    
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void NowHow()
    {
        Debug.Log("노하우");
    }



    public void Collection()
    {
        Debug.Log("도감");
        CollectionInfo.SetActive(true);
    }
    public void CollectionExit()
    {
        Debug.Log("도감 나가기");
        CollectionInfo.SetActive(false);
    }

    
    
    public void Option()
    {
        Debug.Log("설정");
        OptionInfo.SetActive(true);
    }
    public void OptionExit()
    {
        Debug.Log("설정 나가기");
        OptionInfo.SetActive(false);
    }
    public void OptionBackSound()
    {
        Debug.Log("배경음 설정");
        if(isBackSound)
        {
            OptionBackSoundText.text = "배경음 ON"; 
            isBackSound = false;
        }
        else
        {
            OptionBackSoundText.text = "배경음 OFF";
            isBackSound = true;
        }

        //배경음 설정 넣어야됨
    }
    public void OptionEffectSound()
    {
        Debug.Log("효과음 설정");
        if(isEffectSound)
        {
            OptionEffectSoundText.text = "효과음 ON";
            isEffectSound = false;
        }
        else
        {
            OptionEffectSoundText.text = "효과음 OFF";
            isEffectSound = true;
        }
        //효과음 설정 넣어야됨
    }



    public void Shop()
    {
        Debug.Log("상점");
        ShopInfo.SetActive(true);
    }
    public void ShopExit()
    {
        Debug.Log("상점 나가기");
        ShopInfo.SetActive(false);
    }

    public void saveData()
    {
        DataManager.Instance.SaveData();
    }

    public void levelUp()
    {
        if((float)DataManager.Instance.exp > DataManager.Instance.levelUpCost)
        {
            DataManager.Instance.exp -= (int)DataManager.Instance.levelUpCost;
            DataManager.Instance.penlevel++;
        }
    }
}
