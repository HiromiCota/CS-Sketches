using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CS218_Project_3___Philosophers
{
    public class Philosophers
    {       
        public string name;       //What was their name?
        public string nationality; //Where were they from?
        public int born;          //When were they born?
        public int died;          //When did they die?
        public string famousWorks; //What are their most famous works.
        public string biography; //What is a short biography of them?
        public string URL;        //Where can we learn more?
        public Image imageLink;

        //Basic constructor
        public void Philosopher()
        {

        }

        //Overloaded constructor
        public void Philosopher(string newName, string newNationality, int newBorn, int newDied, string newFamousWorks, string newBiography, string newURL,Image newImage)
        {
            //index = newIndex;
            name = newName;
            nationality = newNationality;
            born = newBorn;
            died = newDied;
            famousWorks = newFamousWorks;
            biography = newBiography;
            URL = newURL;
            imageLink = newImage;
        }

        //Setters below.
        public void setName(string newName)
        {
            name = newName;
        }
        public void setNation(string newNationality)
        {
            nationality = newNationality;
        }
        public void setBorn(int newBorn)
        {
            born = newBorn;
        }
        public void setDied(int newDied)
        {
            died = newDied;
        }
        public void setWorks(string newFamousWorks)
        {
            famousWorks = newFamousWorks;
        }
        public void setBio(string newBiography)
        {
            biography = newBiography;
        }
        public void setURL(string newURL)
        {
            URL = newURL;
        }
        public void setImage(Image newImage)
        {
            imageLink = newImage;
        }
        public void superSet(
            string newName, string newNationality, int newBorn,
            int newDied, string newFamousWorks, string newBiography, string newURL, Image newImage)
        {
            //index = newIndex;
            name = newName;
            nationality = newNationality;
            born = newBorn;
            died = newDied;
            famousWorks = newFamousWorks;
            biography = newBiography;
            URL = newURL;
            imageLink = newImage;
        }
        public bool areDuplicate(string goodName, int goodBorn, string goodNationality)
        {
            if (name == goodName &&         
                (born == goodBorn || nationality == goodNationality))
                return true;
            else
                return false;
        }
    }
}
