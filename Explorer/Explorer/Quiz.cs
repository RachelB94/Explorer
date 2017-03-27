
using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Support.V7.App;
using Android.Views;
using System.Collections.Generic;
using Android.Database;

namespace Explorer
{
    [Activity(Label = "Quiz")]
    public class Quiz : Activity
    {


        int NUMOFQUESTIONS = 4;
        // questions used in this quiz
        private Questions[] q;

        // current score
        private int score;
        // keeps track of where we are in the quiz
        private int index;

        // layout buttons
        private static ImageView pres_iv;
        private static TextView quest_tv1;
        private static Button submit_b;
        private static RadioButton selected_rb;
        private static RadioGroup cluster_rg;
        private static RadioButton a_rb;
        private static RadioButton b_rb;
        private static RadioButton c_rb;


       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Quiz_Layout);

            initialze();



        }
        private void initialze()
        {

            pres_iv = (ImageView)FindViewById((Resource.Id.quizImage));
            quest_tv1 = (TextView)FindViewById(Resource.Id.question);
            submit_b = (Button)FindViewById(Resource.Id.answer);
            cluster_rg = (RadioGroup)FindViewById(Resource.Id.radioGroup);
            a_rb = (RadioButton)FindViewById(Resource.Id.a);
            b_rb = (RadioButton)FindViewById(Resource.Id.b);
            c_rb = (RadioButton)FindViewById(Resource.Id.c);

            index = 0;
            score = 0;

            Questions q0 = new Questions(Resource.Drawable.aut, "What time of the year do leaf's change colour?", "Spring", "Winter", "Autumn", "C");
            Questions q1 = new Questions(Resource.Drawable.butterfly, "What insect is this?", "Lady Bird", "Butterfly", "Bee", "B");
            Questions q2 = new Questions(Resource.Drawable.spider, "How many legs does a spider have?", "8", "5", "10", "A");
            Questions q3 = new Questions(Resource.Drawable.caterpillar, "What does this insect turn into?", "Fly", "Butterfly", "Dragonfly", "B");
            // load questions for quiz
            this.q = new Questions[NUMOFQUESTIONS];
            q[0] = q0;
            q[1] = q1;
            q[2] = q2;
            q[3] = q3;
            quest_tv1.Text = (q[0].getQuestionBody());
            a_rb.Text = (q[index].getChoiceA());
            b_rb.Text = (q[index].getChoiceB());
            c_rb.Text = (q[index].getChoiceC());
            pres_iv.SetImageResource(q[0].getImage());

            submit_b.Click += delegate
            {
                var rg = FindViewById<RadioGroup>(Resource.Id.radioGroup);
                var rb = FindViewById<RadioButton>(rg.CheckedRadioButtonId);
                selected_rb = rb;

                String answers = "D";
                if (rb == a_rb) answers = "A";
                if (rb == b_rb) answers = "B";
                if (rb == c_rb) answers = "C";

                if (isCorrect(answers))
                {
                    if (!q[index].isCreditGiven())

                        setScore(getScore() + 1);
                    advance();
                }
                else
                {
                    Toast.MakeText(this, "Wrong Answer", ToastLength.Short).Show();
                }
                
            };
    }
    

        


        public int getScore()
        {
            return score;
        }

        private void setScore(int score)
        {
            this.score = score;
            // update the score display
        }

        public Boolean isCorrect(String choice)
        {
            return choice.Equals(q[index].getAnswer());
        }

        private void advance()
        {
            // user got the current question correct if this method is called
            q[index].giveCredit();
            // advance index to point to next question
            index = (index + 1) % q.Length;

            //update the choices
            a_rb.Text = (q[index].getChoiceA());
            b_rb.Text = (q[index].getChoiceB());
            c_rb.Text = (q[index].getChoiceC());
            //update the question body
            quest_tv1.Text = (q[index].getQuestionBody());
            //update the image
            pres_iv.SetImageResource(q[index].getImage());
            // end update the image
        }




    }
}
        