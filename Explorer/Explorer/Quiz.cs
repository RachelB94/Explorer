
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


        int NUMOFQUESTIONS = 20;
        // questions used in this quiz
        private Questions[] q;
        private Questions[] subArray;

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
            int r;
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
            Questions q4 = new Questions(Resource.Drawable.fly, "How many wings does a fly have?", "2", "4", "6", "A");
            Questions q5 = new Questions(Resource.Drawable.oak, "What type of tree is this?", "Ash", "Birch", "Oak", "C");
            Questions q6 = new Questions(Resource.Drawable.butterflywing, "What insect does this wing belong too?", "Fly", "Butterfly", "Dragonfly", "B");
            Questions q7 = new Questions(Resource.Drawable.insects, "How many legs does an insect have?", "6", "4", "10", "A");
            Questions q8 = new Questions(Resource.Drawable.snail, "How long can a snail sleep for?", "3 Years", "3 Weeks", "3 Days", "A");
            Questions q9 = new Questions(Resource.Drawable.bee, "What insect is this?", "Wasp", "Bee", "Hornet", "B");
            Questions q10 = new Questions(Resource.Drawable.beehive, "Who's home is this?", "Ladybird", "Fruit Fly", "Bee", "C");
            Questions q11 = new Questions(Resource.Drawable.tree, "Which does not come from a tree?", "Leafs", "Fruit", "Flowers", "C");
            Questions q12 = new Questions(Resource.Drawable.ladybird, "What is this?", "Ladybird", "Beatle", "Bee", "A");
            Questions q13 = new Questions(Resource.Drawable.spiderr, "Is a spider an insect?", "Yes", "No", "Some species are", "B");
            Questions q14 = new Questions(Resource.Drawable.tree, "How old is the oldest tree?", "50 years old", "5,000 years old", "500 years old", "B");
            Questions q15 = new Questions(Resource.Drawable.ant, "What is this?", "Ant", "Beatle", "Termite", "A");
            Questions q16 = new Questions(Resource.Drawable.stick, "What is this", "Grasshoper", "Stick Insect", "Twig", "B");
            Questions q17 = new Questions(Resource.Drawable.earwig, "What is this?", "Ant", "Beatle", "Earwig", "C");
            Questions q18 = new Questions(Resource.Drawable.closespider, "What insect is this?", "Ant", "Bee", "Spider", "C");
            Questions q19 = new Questions(Resource.Drawable.insects, "How many kinds of insects are there?", "1,000", "3,000", "10,000", "B");
            // load questions for quiz
            this.q = new Questions[NUMOFQUESTIONS];
            q[0] = q0;
            q[1] = q1;
            q[2] = q2;
            q[3] = q3;
            q[4] = q4;
            q[5] = q5;
            q[6] = q6;
            q[7] = q7;
            q[8] = q8;
            q[9] = q9;
            q[10] = q10;
            q[11] = q11;
            q[12] = q12;
            q[13] = q13;
            q[14] = q14;
            q[15] = q15;
            q[16] = q16;
            q[17] = q17;
            q[18] = q18;
            q[19] = q19;



            subArray = new List<Questions>(q).GetRange(0, 10).ToArray();
            Random ran = new Random();
           

                r = ran.Next(subArray.Length);


                quest_tv1.Text = (subArray[r].getQuestionBody());
                a_rb.Text = (subArray[r].getChoiceA());
                b_rb.Text = (subArray[r].getChoiceB());
                c_rb.Text = (subArray[r].getChoiceC());
                pres_iv.SetImageResource(subArray[r].getImage());
                index = r;
            

           

          

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
                    if (!subArray[index].isCreditGiven())

                        setScore(getScore() + 1);
                  
                        advance();

                    if (subArray[index].isCreditGiven())
                        StartActivity(typeof(QuizScore));                    
                   
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
                subArray[index].giveCredit();
                // advance index to point to next question
                index = (index + 1) % subArray.Length;


                //update the choices
                a_rb.Text = (subArray[index].getChoiceA());
                b_rb.Text = (subArray[index].getChoiceB());
                c_rb.Text = (subArray[index].getChoiceC());
                //update the question body
                quest_tv1.Text = (subArray[index].getQuestionBody());
                //update the image
                pres_iv.SetImageResource(subArray[index].getImage());
                // end update the image

            }
           



        } 
    }
        
    
