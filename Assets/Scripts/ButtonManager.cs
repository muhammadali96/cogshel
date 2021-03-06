using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void BackToHome()
    {
        SceneManager.LoadScene("Home Scene");
    }
    public void ChangeLevel()
    {
        Debug.Log("changing level");
    }

    public void FeedPet()
    {
        Debug.Log("Feed Pet");
    }

    public void Breathe()
    {
        SceneManager.LoadScene("Breathe Scene");
    }
    public void Match3()
    {
        SceneManager.LoadScene("Game");
    }
    public void CloseUpScene()
    {
        SceneManager.LoadScene("Close Up Scene");
    }

    public void Shop()
    {
        SceneManager.LoadScene("Shop Scene");
    }

    public void ClearData()
    {
        SaveSystem.ClearPlayer();
    }
    public void SaveData()
    {
        SaveSystem.SaveGameState();
    }
    public void LoadPetArrival()
    {
        SceneManager.LoadScene("Pet Arrival");
    }

    public void LoadCbtActivity()
    {
        if(GameData.haveReadCBTInstructions == true)
        {
        SceneManager.LoadScene("6 Player input");

        } else
        {
            SceneManager.LoadScene("1 Intro and video");
        }
    }
}
