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
        public Form1()
        {
            InitializeComponent();
            createObjects();
            
        }

        private Location currentLocation { get; set; }

        private void moveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            comboBoxExits.Items.Clear();
            foreach (Location item in currentLocation.Exits)
            {
                comboBoxExits.Items.Add(item.Name);
            }
            comboBoxExits.SelectedIndex = 0;

            textBoxDescription.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                buttonGoThroughDoor.Visible = true;
            else
                buttonGoThroughDoor.Visible = false;


        }

        private void createObjects()
        {
            RoomWithDoor livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob", "behind the coat rack");
            RoomWithDoor kitchen = new RoomWithDoor("Kitchen", "a wood cook stove", "a screen door", "inside the refrigerator");
            Room diningRoom = new Room("Dining Room", "a cherry dining table with high-back chairs");
            OutsideWithDoor frontYard = new OutsideWithDoor("Front Yard", "an oak door with a brass knob", true);
            OutsideWithDoor backYard = new OutsideWithDoor("Back Yard", "a screen door", false);
            OutsideWithHidingPlace garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            Room stairway = new Room("Stairway", "a wooden banister");
            RoomWithHidingPlace upstairsHallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "inside the closet");
            RoomWithHidingPlace masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            RoomWithHidingPlace secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");
            RoomWithHidingPlace bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a smelly unflushed toilet", "in the shower");
            OutsideWithHidingPlace driveway = new OutsideWithHidingPlace("Driveway", true, "inside the garage");


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


            moveToANewLocation(frontYard);  // start in front yard
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

    }
}
