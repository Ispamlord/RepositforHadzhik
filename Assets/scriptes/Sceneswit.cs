using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace scriptes{
    public class Sceneswit : MonoBehaviour{
        public int sceneId;
        public void GoToSampleScene(){
            SceneManager.LoadScene(sceneId);
        }
    }
}


