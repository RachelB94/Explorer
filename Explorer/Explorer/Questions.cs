using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Explorer;

namespace Explorer
{
    class Questions
    {
        private int imageReference;
        private String url;
        private String questionBody;

        private String choiceA;
        private String choiceB;
        private String choiceC;

        private String correctChoice; // should be one letter String
        private Boolean creditGiven;  // starts off false; switched to true once correctly answered

        public void giveCredit()
        {
            this.creditGiven = true;
        }

        public Boolean isCreditGiven()
        {
            return creditGiven;
        }

        public int getImage()
        {
            return imageReference;
        }

        public String getChoiceA()
        {
            return choiceA;
        }

        public String getChoiceB()
        {
            return choiceB;
        }

        public String getChoiceC()
        {
            return choiceC;
        }

        public String getAnswer()
        {
            return correctChoice;
        }

        public String getQuestionBody()
        {
            return questionBody;
        }



        public Questions(int imageReference, String questionBody, String choiceA, String choiceB, String choiceC, String correctChoice)
        {
            this.imageReference = imageReference;
            this.questionBody = questionBody;
            this.choiceA = choiceA;
            this.choiceB = choiceB;
            this.choiceC = choiceC;
            this.correctChoice = correctChoice;
            // question has not been answered correctly yet
            this.creditGiven = false;
        }

        public String getUrl()
        {
            return url;
        }

    }
       
}

       