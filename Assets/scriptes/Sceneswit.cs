using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace scriptes.ui{
    public class Sceneswit : MonoBehaviour{
        [FormerlySerializedAs("sceneid")] 
        public int sceneId;
        public void GoToSampleScene(){
            SceneManager.LoadScene(sceneId);
        }
    }
}


