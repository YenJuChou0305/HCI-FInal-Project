using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO.Ports;
using UnityEngine.UI;



public class Game_Control : MonoBehaviour {

    static public int blow;
    static public int garbage_count = 3;

    public GameObject tree0;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    public GameObject tree5;
    public GameObject tree6;
    public GameObject tree7;

    public GameObject garbage1; //trashbag, light 
    public GameObject garbage2; //waste, middle
    public GameObject garbage3; //pipe, heavy

    public AudioSource M_source;
    int old_count;
    int new_count;

    // display the object
    //public Text hit_obj;
    public Image icon;

    // set Arduino
    //public SerialPort arduinoSerial = new SerialPort("/dev/cu.usbmodem14201", 9600);
    public SerialPort arduinoSerial = new SerialPort("COM4", 9600);


    //**********************************************************************


    // initialization
    void Start()
    {
        arduinoSerial.Open();
        arduinoSerial.ReadTimeout = 10;

        //garbage_count = 3;
        icon.enabled = false;

        M_source = GetComponent<AudioSource>();

    }


    // called once per frame
    void Update()
    {
        blow = 0;
        old_count = garbage_count;
        //Debug.Log(garbage_count);
        //Debug.Log("tree height: " + grow.tree_height);

        if (arduinoSerial.IsOpen)
        {
            try
            {
                string Arduino_String = arduinoSerial.ReadLine();
                Debug.Log("Arduino:  " + Arduino_String);

                if (Arduino_String.Contains("HIGH") || Input.GetMouseButtonDown(0))
                {
                    Debug.Log("blow !");
                    blow = 1;


                    if(garbage_count == 0)
                        Tree_growing();

                }

            }
            catch (TimeoutException e)
            {
                //
            }


        }



        // set text
        if (Raycast.hit_object == "trashbag")
        {
            //hit_obj.text = "light-weight";
            icon.enabled = true;


        }
        else if(Raycast.hit_object == "waste")
        {
            //hit_obj.text = "middle-weight";
            icon.enabled = true;

        }
        else if(Raycast.hit_object == "pipe")
        {
            //hit_obj.text = "heavy-weight";
            icon.enabled = true;

        }
        else
        {
            //hit_obj.text = "";
            icon.enabled = false;

        }


        // testing blow
        if(Input.GetMouseButtonDown(0))
        {
            //Debug.Log("blow !");
            blow = 1;

            if (garbage_count == 0)
                Tree_growing();

        }


        // play music
        if(old_count != new_count)
        {
            M_source.Play();
        }
        new_count = garbage_count;


    }


    void Tree_growing()
    {
        tree0.SetActive(true);
        tree1.SetActive(true);
        tree2.SetActive(true);
        tree3.SetActive(true);
        tree4.SetActive(true);
        tree5.SetActive(true);
        tree6.SetActive(true);
        tree7.SetActive(true);
        //tree_height++;
        grow.tree_height ++;

    }





}
