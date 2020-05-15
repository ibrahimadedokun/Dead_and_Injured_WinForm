using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace MyClassLibrary
{
    [Serializable()]
    public class Player : ISerializable
    {
        private string name;
        private string secretDigits;
        private bool isActive = true;
        private List<string> myPlayedDigits = new List<string>();

        //This will prevent the name to be changed after initialization by the constructor
        public string Name
        {
            get { return this.name; }
        }

        public string SecretDigits
        {
            get { return this.secretDigits; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }


        //Empty Constructor
        public Player() { }

        //Constructor to initialize the name and secret digits which are afterwards unchangeable
        public Player(string name, string secretDigits)
        {
            this.name = name;
            this.secretDigits = secretDigits;
        }

        public string Compare(TextBox t, Player opponent)
        {
            int deadCounter = 0, injuredCounter = 0;
            string first = t.Text, second = opponent.SecretDigits.ToString();
            bool isNumValid = Operation.NumberValidator(t, second.Length);
            if (isNumValid != true)
            {
                return null;
            }
            //-------------------------//
            myPlayedDigits.Add(first); //
            //-------------------------//
            for (int i = 0; i < first.Length; ++i)
            {
                for (int j = 0; j < second.Length; ++j)
                {
                    //To avoid multiple countings of 'dead' digits
                    if (first[i] == second[j])
                    {
                        if (first[i] == second[i]) { deadCounter++; }
                        else { injuredCounter++; }
                    }
                }
            }

            if (deadCounter == 0 && injuredCounter == 0) { return "No luck"; }
            else
            {
                if (deadCounter == first.Length) { return "Eureka!"; }
                else { return $"{deadCounter} dead, {injuredCounter} injured"; }
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Player_Name", this.name);
            info.AddValue("Secret_Digits", this.secretDigits);
            info.AddValue("Active?", this.isActive);
            info.AddValue("Played_Digits", this.myPlayedDigits);
        }

        public Player(SerializationInfo info, StreamingContext context)
        {
            name = (string)info.GetValue("Player_Name", typeof(string));
            secretDigits = (string)info.GetValue("Secret_Digits", typeof(string));
            isActive = (bool)info.GetValue("Active?", typeof(bool));
            myPlayedDigits = (List<string>)info.GetValue("Played_Digits", typeof(List<string>));
        }
    }

}
