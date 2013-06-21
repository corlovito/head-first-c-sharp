using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7HideAndSeek
{
    
    public partial class Form1 : Form
    {
        int Moves;
        Opponent opponent;
        Location currentLocation;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        Room stairway;
        RoomWithHidingPlace upstairsHallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        public Form1()
        {
            InitializeComponent();
            createObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        //private Location currentLocation { get; set; }

        private void moveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            redrawForm();

            //comboBoxExits.Items.Clear();
            //foreach (Location item in currentLocation.Exits)
            //{
            //    comboBoxExits.Items.Add(item.Name);
            //}
            //comboBoxExits.SelectedIndex = 0;

            //textBoxDescription.Text = currentLocation.Description;

            //if (currentLocation is IHasExteriorDoor)
            //    buttonGoThroughDoor.Visible = true;
            //else
            //    buttonGoThroughDoor.Visible = false;


        }

        private void createObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob", "behind the coat rack");
            kitchen = new RoomWithDoor("Kitchen", "a wood cook stove", "a screen door", "inside the refrigerator");
            diningRoom = new Room("Dining Room", "a cherry dining table with high-back chairs");
            frontYard = new OutsideWithDoor("Front Yard", "an oak door with a brass knob", true);
            backYard = new OutsideWithDoor("Back Yard", "a screen door", false);
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            stairway = new Room("Stairway", "a wooden banister");
            upstairsHallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "inside the closet");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a smelly unflushed toilet", "in the shower");
            driveway = new OutsideWithHidingPlace("Driveway", true, "inside the garage");

            // Set outside doors
            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
            frontYard.DoorLocation = livingRoom;

            // set exits -- attaches rooms together
            livingRoom.Exits = new Location[] { frontYard, diningRoom, stairway };
            kitchen.Exits = new Location[] { backYard, diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            frontYard.Exits = new Location[] { livingRoom, backYard, garden, driveway };
            backYard.Exits = new Location[] { kitchen, frontYard, garden, driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            stairway.Exits = new Location[] { livingRoom, upstairsHallway };
            upstairsHallway.Exits = new Location[] { stairway, masterBedroom, secondBedroom, bathroom };
            masterBedroom.Exits = new Location[] { upstairsHallway };
            secondBedroom.Exits = new Location[] { upstairsHallway };
            bathroom.Exits = new Location[] { upstairsHallway };
            driveway.Exits = new Location[] { frontYard, backYard };


            //moveToANewLocation(frontYard);  // start in front yard
        }

        private void buttonGoHere_Click(object sender, EventArgs e)
        {
            moveToANewLocation(currentLocation.Exits[comboBoxExits.SelectedIndex]);
        }

        private void buttonGoThroughDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoorLocation = currentLocation as IHasExteriorDoor;
            moveToANewLocation(hasDoorLocation.DoorLocation);   
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                textBoxDescription.Text = "You found your opponent in " + Moves + " moves! He was hiding " + foundLocation.HidingPlace + ".";
            }
            Moves = 0;
            buttonHide.Visible = true;
            buttonGoHere.Visible = false;
            buttonCheck.Visible = false;
            buttonGoThroughDoor.Visible = false;
            comboBoxExits.Visible = false;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            buttonHide.Visible = false;

            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                textBoxDescription.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            textBoxDescription.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            buttonGoHere.Visible = true;
            comboBoxExits.Visible = true;
            moveToANewLocation(livingRoom);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                redrawForm();
        }

        private void redrawForm()
        {
            comboBoxExits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                comboBoxExits.Items.Add(currentLocation.Exits[i].Name);
            comboBoxExits.SelectedIndex = 0;
            textBoxDescription.Text = currentLocation.Description + "\r\n\r\n(move #" + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                buttonCheck.Text = "Check " + hidingPlace.HidingPlace;
                buttonCheck.Visible = true;
            }
            else
                buttonCheck.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                buttonGoThroughDoor.Visible = true;
            else
                buttonGoThroughDoor.Visible = false;
        }

    }
}
