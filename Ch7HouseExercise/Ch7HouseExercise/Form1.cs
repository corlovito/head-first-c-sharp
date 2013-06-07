using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7HouseExercise
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
            RoomWithDoor livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            RoomWithDoor kitchen = new RoomWithDoor("Kitchen", "a wood cook stove", "a screen door");
            Room diningRoom = new Room("Dining Room", "a cherry dining table with high-back chairs");
            OutsideWithDoor frontYard = new OutsideWithDoor("Front Yard", "an oak door with a brass knob", true);
            OutsideWithDoor backYard = new OutsideWithDoor("Back Yard", "a screen door", false);
            Outside garden = new Outside("Garden", false);

            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
            frontYard.DoorLocation = livingRoom;

            livingRoom.Exits = new Location[] { frontYard, diningRoom };
            kitchen.Exits = new Location[] { backYard, diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            frontYard.Exits = new Location[] { livingRoom, backYard, garden };
            backYard.Exits = new Location[] { kitchen, frontYard, garden };
            garden.Exits = new Location[] { frontYard, backYard };

            moveToANewLocation(frontYard);  // start in front yard
        }

        private void buttonGoHere_Click(object sender, EventArgs e)
        {
            moveToANewLocation(currentLocation.Exits[comboBoxExits.SelectedIndex]);
        }

        private void buttonGoThroughDoor_Click(object sender, EventArgs e)
        {

        }

    }
}
