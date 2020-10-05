using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheLandOfDragons : MonoBehaviour
{
    public Text contentText;
    public Step startStep;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            contentText.text = "WELCOME TO THE LAND OF DRAGONS. FOLLOW THE TREASURE MAP, MAKE WISE CHOICES AND FIND DRAGONS' DARKEST SECRETS"
                + "(press ENTER to continue the game)";
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
          contentText.text = startStep.shablon;
        }

       if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            contentText.text = startStep.win.shablon;
        }
       if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            contentText.text = startStep.lose.shablon;
        }
    }
}
