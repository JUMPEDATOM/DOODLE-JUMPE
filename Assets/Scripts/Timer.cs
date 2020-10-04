using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Threading.Tasks;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public static float timeRecord;
    public static bool finished = false;
    float StartTime;
    float time;

    // Start is called before the first frame update
    void Start()
    {
      StartTime = Time.time; // Start time since our game begain to start!
    }

    // Update is called once per frame
    public void Update()
    {
      if (finished == true)
      {
        Finish();
      }
      else
      {
        time = Time.time - StartTime;
        string minutes = ((int) time / 60).ToString();
        string seconds = (time % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
      }
    }

    public void Finish()
    {
      timerText.color = Color.green;
    }
}
