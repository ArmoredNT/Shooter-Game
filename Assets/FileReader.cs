using System;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FileReader : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        String line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("C:\\Users\\zacho\\GameProjects\\EnginesTest\\LEVEL DESIGN - KISHOTENKETSU.txt");
            //Read the first line of text
            line = sr.ReadLine();
            print(line);
            text.text = line;
            sr.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
