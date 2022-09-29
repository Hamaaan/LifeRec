using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class inputnumber : MonoBehaviour
{
    // insert keypad
    [SerializeField] private Text number;
    public int[] input;
    public int count;
    public int all;

    // insert keypad2
    [SerializeField] private Text numbersecond;
    public int[] inputsecond;
    public int countsecond;

    // question random number
    public Text randomone;
    public Text randomtwo;

    public int ranone;
    public int rantwo;

    // answer number
    public Text answertext; 
    public int answer;

    // correct count
    public int correctcount;
    public Text counttext;

    public GameObject calculate;

    //coin apple, mikkan image
    public int coinranapple;
    public Image[] apple;

    public int coinranmikan;
    public Image[] mikan;

    // coin appple, mikkan random price
    public int appleprice;
    public int mikanprice;

    public int allprice;

    public int allsecond;

    public Text publicappleprice;
    public Text publicmikanprice;

    public int allcoin;

    public Text pricecorrecttext;


    //question random

    public int randomquestion;
    public GameObject calculatequestion;
    public GameObject coinquestion;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        correctcount = 0;
        
        input = new int[4];
        inputsecond = new int[4];

        randomquest();

        coinswitch();


        //calculate.gameObject.SetActive(true);
    }

    private void Awake()
    {
        randomnumber();
    }

    // Update is called once per frame
    void Update()
    {
        randomtext();
        randomtextsecond();
    }

    void randomtext()
    {
        randomone.text = ranone.ToString();
        randomtwo.text = rantwo.ToString();
        counttext.text = correctcount.ToString();

        answer = rantwo + ranone;


        all = input[3] + input[2] * 10 + input[1] * 100 + input[0] * 1000;
    }

    void randomtextsecond()
    {
        allsecond = inputsecond[3] + inputsecond[2] * 10 + inputsecond[1] * 100 + inputsecond[0] * 1000;

    }


    public void click(int numbering)
    {
        if (count < 4)
        {
            input[count] = numbering;
            number.text = string.Join("", input);
            count++;
        }

    }

    public void clicksecond(int numberingsecond)
    {
        if (countsecond < 4)
        {
            inputsecond[countsecond] = numberingsecond;
            numbersecond.text = string.Join("", inputsecond);
            countsecond++;
        }

    }

    public void resetbutton()
    {
        for (int i = 0; i < 4; i++)
        {
            input[i] = 0;
            number.text = string.Join("", input);
            count = 0;
        }
    }

    public void resetbuttonsecond()
    {
        for (int i = 0; i < 4; i++)
        {
            inputsecond[i] = 0;
            numbersecond.text = string.Join("", inputsecond);
            countsecond = 0;
        }
    }

    public void randomnumber()
    {
        ranone = Random.Range(50, 90) * 10;
        rantwo = Random.Range(50, 90) * 10;



    }


    public void correct()
    {
        
            if (all == answer)
            {
                answertext.text = "correct";
                randomnumber();
                resetbutton();
            calculatequestion.gameObject.SetActive(false);
            randomquest();

            correctcount++;
            }
            else
            {
                answertext.text = "uncorrect";
                randomnumber();
                resetbutton();
            calculatequestion.gameObject.SetActive(false);
            randomquest();

        }


    }

    public void correctsecond()
    {

        if (allsecond == allprice)
        {
            pricecorrecttext.text = "correct";
            apple[coinranapple - 1].gameObject.SetActive(false);
            mikan[coinranmikan - 1].gameObject.SetActive(false);

            coinquestion.gameObject.SetActive(false);

            coinswitch();
            resetbuttonsecond();
            randomquest();
            correctcount++;
        }
        else
        {
        pricecorrecttext.text = "uncorrect";

            apple[coinranapple - 1].gameObject.SetActive(false);
            mikan[coinranmikan - 1].gameObject.SetActive(false);
            coinquestion.gameObject.SetActive(false);
            randomquest();
            coinswitch();
            resetbuttonsecond();
        }


    }




    public void coinswitch()
    {
        coinranapple = Random.Range(1, 10);
        coinranmikan = Random.Range(1, 10);

        appleprice = Random.Range(5, 21) * 10;
        mikanprice = Random.Range(3, 13) * 10;

        allprice = coinranapple * appleprice + coinranmikan * mikanprice;

        publicappleprice.text = appleprice.ToString();
        publicmikanprice.text = mikanprice.ToString();

        switch (coinranapple)
        {
            case 1:
                Debug.Log("1");
                apple[0].gameObject.SetActive(true);
                break;

            case 2:
                Debug.Log("2");
                apple[1].gameObject.SetActive(true);
                break;

            case 3:
                Debug.Log("3");
                apple[2].gameObject.SetActive(true);
                break;

            case 4:
                Debug.Log("4");
                apple[3].gameObject.SetActive(true);
                break;

            case 5:
                Debug.Log("5");
                apple[4].gameObject.SetActive(true);
                break;

            case 6:
                Debug.Log("6");
                apple[5].gameObject.SetActive(true);
                break;

            case 7:
                Debug.Log("7");
                apple[6].gameObject.SetActive(true);
                break;

            case 8:
                Debug.Log("8");
                apple[7].gameObject.SetActive(true);
                break;

            case 9:
                Debug.Log("9");
                apple[8].gameObject.SetActive(true);
                break;


        }

        switch (coinranmikan)
        {
            case 1:
                Debug.Log("1");
                mikan[0].gameObject.SetActive(true);
                break;

            case 2:
                Debug.Log("2");
                mikan[1].gameObject.SetActive(true);
                break;

            case 3:
                Debug.Log("3");
                mikan[2].gameObject.SetActive(true);
                break;

            case 4:
                Debug.Log("4");
                mikan[3].gameObject.SetActive(true);
                break;

            case 5:
                Debug.Log("5");
                mikan[4].gameObject.SetActive(true);
                break;

            case 6:
                Debug.Log("6");
                mikan[5].gameObject.SetActive(true);
                break;

            case 7:
                Debug.Log("7");
                mikan[6].gameObject.SetActive(true);
                break;

            case 8:
                Debug.Log("8");
                mikan[7].gameObject.SetActive(true);
                break;

            case 9:
                Debug.Log("9");
                mikan[8].gameObject.SetActive(true);
                break;


        }

    }

    public void randomquest()
    {
        randomquestion = Random.Range(1, 3);

        if (randomquestion == 1)
        {
            calculatequestion.gameObject.SetActive(true);
        }

        if(randomquestion == 2)
        {
            coinquestion.gameObject.SetActive(true);
        }

    }

}
