using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    private AlltimeVariables alltimeVariables;
    private Shop shop;

    // Start is called before the first frame update
    void Start()
    {
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();
        shop = Object.FindObjectOfType<Shop>();
    }

    //difficulty choice functions
    public void EasyDifficulty()
    {
        for(int i = 0; i<alltimeVariables.difficultyChecker.Length; i++)
        {
            alltimeVariables.difficultyChecker[i] = false;
        }
        alltimeVariables.spawnRate = 50;
        alltimeVariables.difficultyChecker[0] = true;
    }

    public void MediumDifficulty()
    {
        for (int i = 0; i < alltimeVariables.difficultyChecker.Length; i++)
        {
            alltimeVariables.difficultyChecker[i] = false;
        }
        alltimeVariables.spawnRate = 35;
        alltimeVariables.difficultyChecker[1] = true;


    }

    public void HardDifficulty()
    {
        for (int i = 0; i < alltimeVariables.difficultyChecker.Length; i++)
        {
            alltimeVariables.difficultyChecker[i] = false;
        }
        alltimeVariables.spawnRate = 20;
        alltimeVariables.difficultyChecker[2] = true;

    }




    //boost functions
    public void BoostSpeed()
    {
        float price = 20;
        if(alltimeVariables.coins >= 20)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.boostChecker[0] = true;
        }
        else
        {
            print("Not enough coins");
           
            alltimeVariables.buyNotEnoughCoins = true;
        }
    }

    public void BoostTrapOneRemoval()
    {
        float price = 20;
        if (alltimeVariables.coins >= 20)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.boostChecker[1] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        

    }
    public void BoostTrapTwoRemoval()
    {
        float price = 20;
        if (alltimeVariables.coins >= 20)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.boostChecker[2] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        
    }
    public void BoostTime()
    {
        float price = 20;
        if (alltimeVariables.coins >= 20)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.boostChecker[3] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        
    }
    public void BoostSpawn()
    {
        float price = 20;
        if (alltimeVariables.coins >= 20)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.boostChecker[4] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        
    }


    //Quest functions
    public void QuestPossum()
    {
        float price = 20;
        if (alltimeVariables.coins >= price)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.questChecker[0] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        
    }
    public void QuestGecko()
    {
        float price = 20;
        if (alltimeVariables.coins >= price)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.questChecker[1] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        
    }
    public void QuestSnake()
    {
        float price = 20;
        if (alltimeVariables.coins >= price)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.questChecker[2] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        
    }
    public void QuestFish()
    {
        float price = 20;
        if (alltimeVariables.coins >= price)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.questChecker[3] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        
    }
    public void QuestBird()
    {
        float price = 20;
        if (alltimeVariables.coins >= price)
        {
            alltimeVariables.coins -= price;
            alltimeVariables.questChecker[4] = true;
        }
        else
        {
            print("Not enough coins");

            alltimeVariables.buyNotEnoughCoins = true;


        }
        
    }


    //change scenes functions

    public void EndGameLevel()
    {
        alltimeVariables.Reset();
        SceneManager.LoadScene("MainMenu");
    }
    public void ShopToMainMenu()
    {
       
        alltimeVariables.coins = alltimeVariables.coinBackUp;
        alltimeVariables.Reset();
        SceneManager.LoadScene("MainMenu");
    }


    public void StartLevel()
    {
        SceneManager.LoadScene("GameLevel");
        //alltimeVariables.isRunning = true;
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("PlayMenu");
    }
}
