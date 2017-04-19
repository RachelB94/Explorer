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
using Xamarin.Forms;
using ExplorerVision;

namespace Explorer
{
    [Activity(Label = "Gallery", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class GalleryActivity : Activity
    {

        String text;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Gallary);
            Gallery gallery = FindViewById<Gallery>(Resource.Id.gallery);
            gallery.Adapter = new ImageAdapter(this);
            
            
           

            gallery.ItemClick += delegate (object sender, Android.Widget.AdapterView.ItemClickEventArgs args)
            {
                
                var alert = new AlertDialog.Builder(this);
                alert.SetView(LayoutInflater.Inflate(Resource.Layout.popup, null));

                if (args.Position.ToString() == "0")
                {

                    text = "This is an ant."
                    + "\n" +  "\n" + "There are more than 12,000 species of ants all over the world.An ant can lift 20 times its own body weight."  + "\n" + "\n" + "If you were an ant, you could pick up a car!" + "\n" +"\n" +
                    "Queen ants can live for many years and have millions of babies";

                }

                if(args.Position.ToString() == "1")
                {
                    text = "This is a leaf. Leaves change colour in the season Autumn. Inside a leaf there are millions of little packages of color in green, yellow and orange" + "\n" + "\n" +
                    "The green packages are called chlorophyll" + "\n" + "The yellow packages are called xanthophyll" + "\n" +
                    "The orange packages are called carotene" + "\n" + "\n" + "The green packages need water to change water from the ground and a special gas from the air ('carbon dioxide') into sugar ('glucose').But when the weather becomes colder a thin layer of cells grows over the water tubes in the leaves and closes them up in preperation for the winter. No more water can get into the leaf!" +
                    " Without the water, the green package starts to disappear and the other colors in the leaf can finally be seen.";
                }

                if(args.Position.ToString() == "2")
                {
                    text = "This is a wasp. Wasps are known for being noisy and aggressive but they have a very important purpose! They protect our crops by eating pests that infect our crops." + "\n" + "\n" +
                    "Wasps live everywhere in the world but Antarctica!" + "\n" + "\n" + "Unlike Bees, wasps can string over and over again. They do not lose their stingers when they sting." + "\n" + "\n" +
                    "Wasps make nests from paper. They chew up strips of bark and spit it out again to form a rough paper.";
                }

                if(args.Position.ToString() == "3")
                {
                    text = "This is a bee hive. Home to the honey bees!. Honey bees make hives to store honey and feed themselves throughout winter when they cannot go outdoors to forage for food";
                }

                if(args.Position.ToString() == "4")
                {
                    text = "This is a butterfly. Butterflies are known as the most pretty insect because of their colorful wings. But butterflies are not born butterflies, first they are insects called caterpillars." +"\n" + "\n" +
                    "Fully grown caterpillars attach themselves to a suitable twig or leaf before shedding their outside layer of skin to reveal a hard skin called a cacun. Inside the cacun, the caterpillar transforms into a butterfly and hatches when it is fully grown." + "\n" + "\n" +
                    "Butterflies have four wings. They often have brightly coloured wings with unique patterns made up of tiny scales." + "\n" + "\n" + "Most butterflies feed on nector from flowers and taste their food through their feet!"; 
                }

                if (args.Position.ToString() == "5")
                {
                    text = "This is a Caterpillar. Butterflies and moths spend their childhood as caterpillars. When a caterpillar becomes a cacun" +"\n" + 
                    ",it's six front legs transform's into the adult insect's and other legs disappear, wings grow and the insect emerges as a beautiful moth or butterfly." + "\n" + "\n"
                    + "Caterpillars are herbivores. Herbivores are insects that eat plants and leaves. Caterpillars eat mostly leaves, although some species eat all plant parts." + "\n" + "\n" +
                    "You can find caterpillars almost everywhere from sandy beaches to meadows to mountain forests, worldwide. There are even caterpillars in some Artic areas";
                }

                if(args.Position.ToString() == "6")
                {
                    text = "This is an Earwig. Earwig get their name from the myth that they crawl into sleeping peoples ears, but they do not really do that!" +
                    "\n" + "\n" + "Earwigs feed on leaves, flowers, fruits, mold and insects." + "\n" + "\n" +
                    "Earwigs hide during the day and live outdoors in large numbers.They can be found under piles of lawn clippings, compost or in a tree hole.";
                }

                if (args.Position.ToString() == "7")
                {
                    text = "This is a Fly. Flies are most commonly seen around rubbish, bins and sometimes inside our homes. Flies are known as pests, that buzz in your ear, land on your food or crawl in your house." + "\n" + "\n"
                    + "Flies are food to many animals such as birds, frogs and snakes." + "\n" + "\n"
                    + "Most flying insects have four wings, but files only have two. They can fly up and down, side to side and even backwards. Files have hairy and sticky feet and can stick to almost any surface. They can even walk accross your ceiling."; 
                }

                if (args.Position.ToString() == "8")
                {
                    text = "The number of insect species is believed to be between six and ten million!" + "\n" + "\n" + "Insects bodies have three parts, the thorax, abdomen and head. Insects have two antennaes and three pairs of legs. That is six legs in total!. Insects are cold blooded and most insects hatch from eggs." 
                    + "\n" + "\n" + "Some insects, such as gerridae(water striders), are able to walk on the surface of water";
                }

                if (args.Position.ToString() == "9")
                {
                    text = "This is a ladybird! Ladybirds are known as Ladybug's in the USA." + "Ladybird's are a type of bettle, some have up to 20 spots others have none!" + "\n" + "\n"
                    + "To defend themselves from being eaten, ladybirds play dead. They also release a yellow fluid that other bugs find stinky!" + "The color of the ladybird also makes predators think that the ladybird may taste bad or be poisonous.";
                }

                if (args.Position.ToString() == "10")
                {
                    text = "This leaf belongs to an Oak tree. Oak trees live on the northern hemisphere and can survive in various forests and climities including tropical areas."
                    + "\n" + "\n" + "Oak trees are usually large is size and reach a height if 70 feet!" + "\n" + "\n"
                    + "An oak tree can absorb 50 gallons of water each day. That's the same as 40 bottles of water." + "\n" + "\n"
                    + "Fruits that come from trees are called acorns. Oak trees produce more than 2000 acorns every year feeding a lot of animals including squirrels, ducks, pigeons and mice.";
                }

                if (args.Position.ToString() == "11")
                {
                    text = "This is a Snail. There are three types of snails, land snails, sea snails and freshwater snails. Some snails have gills or lungs depending on their species. Some snails can sleep for up to 3 years!"
                    + "\n" + "\n" + "Snail's without shells are called sluggs." + "\n" + "\n" + "Snails are mostly herbivorers eating vegetation such as leaves, stems and flowers. Some larger species can eat only other insects or both insects and vegetation." + 
                    "\n" + "\n" + "The largest living sea snail is the Syrinx aruanus who's shell can reach 90cm in length and the snail can weigh up to 18kg! That's the same weight as 30 pairs of shoes." +"\n" + "\n" 
                    + "Common garden snails have a top speed of 45 m per hour. Making the snail one of the slowest creatures on Earth."; 
                }
                if (args.Position.ToString() == "12")
                {
                    text = "This is a Spider. Spiders commonly have eight legs and a round body. Spiders are actually not insects, they are arachnids. Spiders don't have antennae while insects do." + "\n" + "\n"
                    + "Spiders are found on every continent of the worl except for Antartica. There are around 40000 different species of spiders." + "\n" + "\n"
                    + "Most spiders make silk which they use to create a spider web, that they use to catch their food. Abandoned spider webs are called cobwebs."; 

                }
                if (args.Position.ToString() == "13")
                {
                    text = "This is a Stick insect. Stick insects are named by their stick like appearance but stick insects do not only look like sticks or twigs, they can act like them too." + "They sway in the breeze so they look like part of the tree or bush they are on." + "\n" + "\n"
                    + "If a predator gets hold of a stick insects leg, it can grow another one. Stick insects have a special muscle that lets them loose a leg if their life is in danger. If stick insects are in danger, they also can fall to the ground and play dead. This makes them look like a twig falling off a tree.";
                }
                if (args.Position.ToString() == "14")
                {
                    text = "This is a Tree! Tree's are very important. They provide us with oxygen, wood for building, pulp for making paper and provide homes for all sorts of insects and animals. Many types of fruits and nuts come from trees including apples, oranges, walnuts, pears and peaches." + "\n" + "\n" +
                    "Trees can live for thousands of years, the oldest tree's lived for 10,000 years." + "\n" + "\n" + "The tallest species of trees in the world include the Coast Redwood, Giant Sequoia, Coast Douglas Fir, Sitka Spruce and Australian Mountain Ash";
                }


                alert.SetMessage(text);

                alert.Create().Show();

              

            };
           }
    }
}