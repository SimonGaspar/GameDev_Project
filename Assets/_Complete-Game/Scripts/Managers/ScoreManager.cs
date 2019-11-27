using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class ScoreManager : MonoBehaviour
    {
        public static int score;        // The player's score.
        public static float scoreMul = 1;

        Text text;                      // Reference to the Text component.


        void Awake ()
        {
            // Set up the reference.
            text = GetComponent <Text> ();

            // Reset the score.
            score = 0;
        }

        public static void IncreaseScore(int amount)
        {
            score += (int)(amount * scoreMul);
        }

        void Update ()
        {
            // Set the displayed text to be the word "Score" followed by the score value.
            text.text = "Score: " + score;
            if (scoreMul > 1)
            {
                text.text += " x" + scoreMul;
            }
        }
    }
}