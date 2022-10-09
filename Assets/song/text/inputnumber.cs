﻿using System.Collections;
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

    //insert keypad3
    [SerializeField] private Text numberthird;
    public int[] inputthird;
    public int countthird;
    public int allthirdup;
    public int allthirddown;

    //insert keypad4
    [SerializeField] private Text numberforth;
    public int[] inputforth;
    public int countforth;
    public int allforth;

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

    // percent quesiton random
    public int blue;
    public int red;
    public int questionrandomcolor;

    public Text bluetext;
    public Text redtext;
    public Text quesitoncolor;

    public int allcolor;

    public Text questionanswertext;

    //question random

    public int randomquestion;
    public GameObject calculatequestion;
    public GameObject coinquestion;
    public GameObject questionquestion;

    //price random
    public float originalprice;
    public float pricepercent;
    public float sale;
    public float afterprice;

    public int pricepercentswitch;
    public int saleswitch;
    public float salefirst;
    public float originapricefirst;

    public Text percenttext;
    public Text saletext;
    public Text pricetext;

    public Text percentcorrecttext;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        correctcount = 0;
        
        input = new int[4];
        inputsecond = new int[4];
        inputthird = new int[4];
        inputforth = new int[5];
        
        //randomquest();

        coinswitch();
        randomcolor();
        randomprice();

        //calculatequestion.gameObject.SetActive(true);

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
        randomtextthird();
        randomtextforth();
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

    public void randomtextthird()
    {
        allthirddown = inputthird[3] + inputthird[2] * 10;
        allthirdup = inputthird[1] + inputthird[0] * 10;

    }

    public void randomtextforth()
    {
        if (originalprice >= 10000)
        {
            
            allforth = inputforth[4] + inputforth[3] * 10 + inputforth[2] * 100 + inputforth[1] * 1000 + inputforth[0] * 10000;
        }
        else if(10000>originalprice && originalprice >= 1000)
        {
            
            
            allforth = inputforth[4] + inputforth[3] * 10 + inputforth[2] * 100 + inputforth[1] * 1000;
        }
        else if(originalprice<1000)
        {
            
            allforth = inputforth[4] + inputforth[3] * 10 + inputforth[2] * 100;
        }
       
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

    public void clickthird(int numberingthird)
    {
        if(countthird <4)
        {
            
                inputthird[countthird] = numberingthird;
                numberthird.text = string.Join(" ", inputthird);
                countthird++;
            
        }
    }

    public void clickforth(int numberingforth)
    {

        if (originalprice >= 10000)
        {
            if (countforth < 5)
            {
                inputforth[countforth] = numberingforth;
                numberforth.text = string.Join(" ", inputforth);
                countforth++;

            }
        }

        else if (10000 > originalprice && originalprice >= 1000)
        {
            if (countforth < 4)
            {
                inputforth[countforth+1] = numberingforth;
                numberforth.text = string.Join(" ", inputforth);
                countforth++;

            }
        }
        else if (originalprice<1000)
        {
            inputforth[countforth+2] = numberingforth;
            numberforth.text = string.Join(" ", inputforth);
            countforth++;
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

    public void resetbuttonthird()
    {
        for (int i = 0; i < 4; i++)
        {
            inputthird[i] = 0;
            numberthird.text = string.Join("", inputthird);
            countthird = 0;
        }
    }

    public void resetbuttonforth()
    {
            for (int i = 0; i < 5; i++)
            {
                inputforth[i] = 0;
                numberforth.text = string.Join("", inputforth);
                countforth = 0;
            }

    }


    public void randomnumber()
    {
        ranone = Random.Range(50, 91) * 10;
        rantwo = Random.Range(50, 91) * 10;

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

    public void correctthird()
    {
        if(questionrandomcolor == 1)
        {
            if(allthirddown == blue+ red && allthirdup == blue)
            {
                questionanswertext.text = "correct";
                randomcolor();
                resetbuttonthird();
                randomquest();
                correctcount++;
                questionquestion.gameObject.SetActive(false);

            }
            else
            {
                questionanswertext.text = "uncorrect";
                randomcolor();
                resetbuttonthird();
                randomquest();
                questionquestion.gameObject.SetActive(false);
            }
        }

        if (questionrandomcolor == 2)
        {
            if (allthirddown == blue + red && allthirdup == red)
            {
                questionanswertext.text = "correct";
                randomcolor();
                resetbuttonthird();
                randomquest();
                correctcount++;
                questionquestion.gameObject.SetActive(false);

            }
            else
            {
                questionanswertext.text = "uncorrect";
                randomcolor();
                resetbuttonthird();
                randomquest();
                questionquestion.gameObject.SetActive(false);
            }
        }



    }

    public void correctforth()
    {
        if(allforth == originalprice)
        {
            percentcorrecttext.text = "correct";
            randomprice();
            resetbuttonforth();
        }
        else
        {
            percentcorrecttext.text = "uncorrect";
            randomprice();
            resetbuttonforth();
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
        randomquestion = Random.Range(1, 4);

        if (randomquestion == 1)
        {
            calculatequestion.gameObject.SetActive(true);
        }

        if(randomquestion == 2)
        {
            coinquestion.gameObject.SetActive(true);
        }
        if(randomquestion == 3)
        {
            questionquestion.gameObject.SetActive(true);
        }


    }

    public void randomcolor()
    {
        blue = Random.Range(3, 12);
        red = Random.Range(3, 12);
        questionrandomcolor = Random.Range(1, 3);


        bluetext.text = blue.ToString();
        redtext.text = red.ToString();

        if (questionrandomcolor == 1)
        {
            quesitoncolor.text = "青";
            quesitoncolor.color = new Color(0, 0, 255);
        }
        else
        {
            quesitoncolor.text = "赤";
            quesitoncolor.color = new Color(255, 0, 0);
        }

    }

    public void randomprice()
    {
        afterprice = Random.Range(1,11)*50;

        saleswitch = Random.Range(1, 5);
        pricepercentswitch = Random.Range(1, 5);

        switch (saleswitch)
        {
            case 1:
                Debug.Log(saleswitch);
                sale = 90;
                break;

            case 2:
                Debug.Log(saleswitch);
                sale = 75;
                break;

            case 3:
                Debug.Log(saleswitch);
                sale = 50;
                break;

            case 4:
                Debug.Log(saleswitch);
                sale = 80;
                break;
        }

        switch (pricepercentswitch)
        {
            case 1:
                Debug.Log(pricepercentswitch);
                pricepercent = 10;
                break;

            case 2:
                Debug.Log(pricepercentswitch);
                pricepercent = 20;
                break;

            case 3:
                Debug.Log(pricepercentswitch);
                pricepercent = 25;
                break;

            case 4:
                Debug.Log(pricepercentswitch);
                pricepercent = 50;
                break;
        }

        originapricefirst = afterprice * (100 / (100 - sale));
        originalprice = originapricefirst * (100 / pricepercent);
        Debug.Log(originalprice);

        percenttext.text = pricepercent.ToString();
        saletext.text = sale.ToString();
        pricetext.text = afterprice.ToString();


    }

}