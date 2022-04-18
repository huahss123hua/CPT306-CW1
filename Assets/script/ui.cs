using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    public Text DhNum;
    public Text IpgNum;
    public Text SNum;
    public Text RNum;
    public Text GNum;
    public Text BNum;
    public static int dh = 0;
    public static int ipg = 0;
    public static int score = 0;
    public static int red = 0;
    public static int green = 0;
    public static int blue = 0;

    public Text m_ClockText;
    private float m_Timer;
    private int m_Hour;//h
    private int m_Minute;//m
    private int m_Second;//s
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        DhNum.text = dh.ToString();
        IpgNum.text = ipg.ToString();
        SNum.text = score.ToString();
        RNum.text = red.ToString();
        GNum.text = green.ToString();
        BNum.text = blue.ToString();
        


        m_Timer += Time.deltaTime;
        m_Second = (int)m_Timer;
        if (m_Second > 59.0f)
        {
            m_Second = (int)(m_Timer - (m_Minute * 60));
        }
        m_Minute = (int)(m_Timer / 60);
        if (m_Minute > 59.0f)
        {
            m_Minute = (int)(m_Minute - (m_Hour * 60));
        }
        m_Hour = m_Minute / 60;
        if (m_Hour >= 24.0f)
        {
            m_Timer = 0;
        }
        m_ClockText.text = string.Format("{0:d2}:{1:d2}:{2:d2}", m_Hour, m_Minute, m_Second);



    }
}
