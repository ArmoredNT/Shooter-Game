using System;
using System.IO;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int xpos = 0, ypos = 0;
        
        String line;
        try
        {
            print("reading level");
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("C:\\Users\\zacho\\Downloads\\Level set up.txt");
            
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                ypos++;
                xpos = 0;
                foreach (char c in line)
                {
                    xpos++;
                    if (c == '0') Instantiate(prefab, new Vector3(xpos, ypos, 0), Quaternion.identity);
                    print(c.ToString());
                }
                line = sr.ReadLine();
            }
            
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
