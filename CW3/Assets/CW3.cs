using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW3 : MonoBehaviour
{
    // character information
    string HeroName = "the defender";
    string VillainName = "the destroyer";
    int HeroPower = 50;
    int VillainPower = 100;
    float playerspeed = 0f;
    float PreviousSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        // situations
        if (HeroPower < VillainPower)
        {
            print("TAKE THIS L");
        }
        else if (HeroPower > VillainPower)
        {
            print("LETS GO W");
        }
        else
        {
            print("DRAW!");
        }
        SetSpeed(2.5f);
        CompareSpeed();
    }
    void SetSpeed(float speed)
    {
        print(playerspeed);
        PreviousSpeed = playerspeed;
        playerspeed = speed;
        print(playerspeed);
    }
    void CompareSpeed()
    {
        if(PreviousSpeed < playerspeed)
        {
            print("Speed Upgraded! Fastest Speed:" + playerspeed);
        }
        else if(PreviousSpeed > playerspeed)
        {
            print("Speed Downgraded! Fastest Speed:" + PreviousSpeed);
        }
        else
        {
            print("Speed Unchanged! Fastest Speed:" + playerspeed);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

