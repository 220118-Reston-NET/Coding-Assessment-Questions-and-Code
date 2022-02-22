using System;

using System.Collections.Generic;



public class Test

{



    public static List<string> AutoComplete(string s, List<string> words)

    {

        List<string> results = new List<string>();

        //write your Logic here:



        return results;

    }



    public static void Main()

    {

        //INPUT [uncomment & modify if required]

        string sampleInput = "";

        string searchPrefix = "";

        List<string> resultList = new List<string>();

        

        List<string> words = new List<string>();

        searchPrefix = Console.ReadLine();

        bool isPresent = true;



        for(int i = 0; isPresent != false; i++)

        {

            string target = Console.ReadLine();

            if(target != null)

            {

                words.Add(target);

            }else{

                isPresent = false;

            }

        }

        

        resultList = AutoComplete(searchPrefix, words);



        //OUTPUT [uncomment & modify if required]

        foreach(string l in resultList)

        {

            Console.WriteLine(l);

        }

    }

}