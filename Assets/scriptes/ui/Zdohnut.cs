using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace scriptes.UI
{
    public class Zdohnut : MonoBehaviour { 
        void QuitButton()
        {
            Debug.Log("Game is exiting");
            Application.Quit();
        }
    }    
}


