using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace scriptes.UI{
    public class Sceneswit : MonoBehaviour{
        public int sceneid;
        public void GoToSampleScene(){
            SceneManager.LoadScene(sceneid);
        }
    }
}


