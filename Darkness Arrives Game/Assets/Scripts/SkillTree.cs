using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour {

    public static float playerSpeech = 1;

    public Button Speech1;

    public static int totalSkillpoints = 5;

    public static float playerAtt = 1;

    public Button maxAttkbutton;

    public static int totalpointsSpent = 0;

    public Button Charisma2;
	
	void Start () {
		
	}
		
	void Update ()
    {
		if(totalSkillpoints == 0)
        {
            Speech1.GetComponent<Button>().enabled = false;
        }
        else
        {
            Speech1.GetComponent<Button>().enabled = true;
        }
        if (totalSkillpoints <= 1)
        {
            maxAttkbutton.GetComponent<Button>().enabled = false;
        }
        else
        {
            maxAttkbutton.GetComponent<Button>().enabled = true;
        }
        if ((totalSkillpoints >= 1) || (totalpointsSpent<3))
        {
            Charisma2.GetComponent<Button>().enabled = false;
        }
        if ((totalSkillpoints >= 2) && (totalpointsSpent>2))
        {
            Charisma2.GetComponent<Button>().enabled = true;
        }
    }
    public void CharismaIncrLvl1()
    {
        playerSpeech = 1.2f;
        totalSkillpoints -= 1;
        totalpointsSpent += 1;
        Debug.Log(playerSpeech);
    }
    public void MaxdamageIncr()
    {
        playerAtt = 1.1f;
        totalSkillpoints -= 2;
        totalpointsSpent += 2;
        Debug.Log(playerAtt);
    }
    public void CharismaIncrLvl2()
    {
        playerSpeech = 1.5f;
        totalSkillpoints -= 2;
        totalpointsSpent += 2;
        Debug.Log(playerSpeech);
    }
}
