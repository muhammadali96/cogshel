using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerFillStatusBar : MonoBehaviour
{
    public Image fillImage;
    private Slider slider;
    public float currentLevel;
    public float maxLevel;
    public int Delay;
    SadnessController sadnessController;


    protected float timer;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerData data = SaveSystem.LoadPlayer();

        currentLevel = GameData.hungerLevel;
        sadnessController = GameObject.FindGameObjectWithTag("Pet").GetComponent<SadnessController>();
    }

    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    //this is saving too many times
    // Update is called once per frame
    void Update()
    {
        

        //SaveSystem.SavePlayer(this);
        timer += Time.deltaTime;

        //smaller the delay the faster it increments
        if (timer >= Delay)
        {
            if (currentLevel >= 100)
            {
                currentLevel = 100;
            }
            timer = 0f;
            currentLevel--;
            GameData.hungerLevel = currentLevel;
        }
        if (maxLevel == 0)
        {
            Debug.LogError("Max Level not set");
            return;
        }

        float fillValue = currentLevel / maxLevel;

        if (fillValue <= slider.maxValue / 3)
        {
            fillImage.color = Color.red;
            sadnessController.setHungry(true);
        }
        else if (fillValue >= 2 * slider.maxValue / 3)
        {
            fillImage.color = new Color(0f, 0.2358491f, 0.02620547f);
            sadnessController.setHungry(false);
        }
        else
        {
            fillImage.color = Color.yellow;
            sadnessController.setHungry(false);
        }


        slider.value = fillValue;
    }
}
