using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace scriptes.UI
{
    [ExecuteInEditMode]
    public class Backcog : MonoBehaviour
    {
        private Image backgroundImage;
        private RectTransform rt;
        private float ratio;

        // Start is called before the first frame update
        void Start()
        {
            backgroundImage = GetComponent<Image>();
            rt = backgroundImage.rectTransform;
            ratio = backgroundImage.sprite.bounds.size.x / backgroundImage.sprite.bounds.size.y;
        }

        // Update is called once per frame
        void Update()
        {
            if (!rt)
                return;

            //Scale image proportionally to fit the screen dimensions, while preserving aspect ratio
            if (Screen.height * ratio >= Screen.width)
            {
                rt.sizeDelta = new Vector2(Screen.height * ratio, Screen.height);
            }
            else
            {
                rt.sizeDelta = new Vector2(Screen.width, Screen.width / ratio);
            }
        }
    }
}

