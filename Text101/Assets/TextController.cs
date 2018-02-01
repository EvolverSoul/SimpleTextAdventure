using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {
		cell, mirror_0, mirror_1, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
		corridor_0,corridor_1, corridor_2, corridor_3, torch_0, torch_1, torch_2, torch_3, door_0, door_1, door_2, door_3,
		grate_0, grate_1, grate_2, grate_3, nextcell_0, nextcell_1, nextcell_2, nextcell_3, body_0, body_1,body_2, body_3, key_0,
		stairs_0,
		upstairs_0,
		};
	private States myState;
		
	// Use this for initialization
	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		//cell scene
		if 		(myState == States.cell)				{cell();}
		else if (myState == States.sheets_0)			{sheets_0();}
		else if (myState == States.sheets_1)			{sheets_1();}
		else if (myState == States.lock_0)				{lock_0();}
		else if (myState == States.lock_1)				{lock_1();}
		else if (myState == States.mirror_0)			{mirror_0();}
		else if (myState == States.mirror_1)			{mirror_1();}
		else if (myState == States.cell_mirror)			{cell_mirror();}
		
		
		//corridor scene
		else if (myState == States.corridor_0)			{corridor_0();}
		else if (myState == States.torch_0)				{torch_0();}
		else if (myState == States.door_0)				{door_0();}
		else if (myState == States.grate_0)				{grate_0();}
		else if (myState == States.nextcell_0)			{nextcell_0();}
		else if (myState == States.body_0)				{body_0();}
		//with metal chunk
		else if (myState == States.corridor_1)			{corridor_1();}
		else if (myState == States.torch_1)				{torch_1();}
		else if (myState == States.door_1)				{door_1();}
		else if (myState == States.grate_1)				{grate_1();}
		else if (myState == States.nextcell_1)			{nextcell_1();}
		else if (myState == States.body_1)				{body_1();}
		//with torch
		else if (myState == States.corridor_2)			{corridor_2();}
		else if (myState == States.torch_2)				{torch_2();}
		else if (myState == States.door_2)				{door_2();}
		else if (myState == States.grate_2)				{grate_2();}
		else if (myState == States.nextcell_2)			{nextcell_2();}
		else if (myState == States.body_2)				{body_2();}
		else if (myState == States.key_0)				{key_0();}
		//with key
		else if (myState == States.corridor_3)			{corridor_3();}
		else if (myState == States.torch_3)				{torch_3();}
		else if (myState == States.door_3)				{door_3();}
		else if (myState == States.grate_3)				{grate_3();}
		else if (myState == States.nextcell_3)			{nextcell_3();}
		else if (myState == States.body_3)				{body_3();}
		else if (myState == States.stairs_0)			{stairs_0();}
		//upstairs
		else if (myState == States.upstairs_0)			{upstairs_0();}
	
		
			
			
		
		}
			
	void cell (){
		text.text = "A pounding in your head forces your eyes open. The foetid stench of human filth " +
					"fills your nostrils and makes your breath catch in your throat. You are in a dungeon. " +
					"An oppressive gloom closes in as you pull yourself up into a sitting position. Cold, wet " + 
					"stone walls surround the nearly empty room. In the distance, you can " +
					"hear the screams of a tortured prisoner reverberate through the halls, before being silenced abruptly. " + 
					"There are dirty sheets on the bed behind you, a small grimey handheld mirror on the floor in the corner " + 
					"and a door with bent bars that is locked from the outside.\n\n" +
					"Press S to view the sheets, press M to view the mirror and L to view the locked door.";
						
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sheets_0;}
		if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror_0;}
		if (Input.GetKeyDown(KeyCode.L)) {myState = States.lock_0;}
				
		}
		
	void cell_mirror (){
		text.text = "The cell seems to loom around you, as if the foreboding walls were leaning in to get a better " +
					"view of what you were doing. Mirror in hand, you have a few choices to make. Someone screams from " +
					"down the hall. A cold shiver runs up your spine.\n\n" +
					"Press S to view the sheets, press M to view the mirror and L to view the locked door.";
		
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sheets_1;}
		if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror_1;}
		if (Input.GetKeyDown(KeyCode.L)) {myState = States.lock_1;}
		
	}
			
	void sheets_0 (){
		text.text = "A slab of cold, grime coated granite juts awkwardly from the wall. Long, rusting chains bolted deep " +
			 		"into the slab and connected to the wall keep it from crashing to the floor. Filthy sheets lay " +
			 		"crumpled in a heap on the slab, with splodges of mysterious stains soaked through the roughly sewn linen.\n\n" +
			 		"Press R to return to the rest of the cell."; 
			
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
				
				
		}
	void sheets_1 (){
		text.text = "The sheets remain crumpled on the hard slab. Scrubbing the mirror with them only serves to smear around the grease.\n\n" +
					"Press R to return to the rest of the cell."; 
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
		
		
	}
		
	void lock_0 (){
		text.text = "The door is locked with a simple combination lock. Six buttons adorn the lock, but there " +
					"is no way of telling what the combination is. If only there was " +
					"something in the room that might help.\n\n" +
					"Press R to return to the cell.";
			
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell;}
		}
		
	void lock_1 (){
			text.text = "Clutching the mirror, you force your arm through the bars. Tilting the mirror just so, you can make out " +
						"a few smudges upon three of the buttons. You try several times and on the third time, a quiet, " +
						"hopeful click sounds out from the aged lock.\n\n" +
						"Press O to open the door, press R to return to the cell.";
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.O)) {myState = States.corridor_0;}
		
	}
		
		
	void mirror_0 (){
		text.text = "The mirror glares up at you from the floor, offering a cruel truth: You look like hell. " +
					"The mirror is coated with grease, but you might be able to see more than just your face in its reflection.\n\n" +
					"Press T to take the mirror, press R to return to your cell.";
			
		if (Input.GetKeyDown(KeyCode.T)) 			{myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
			
			
		}
		
	void mirror_1 (){
		text.text = "The ground is a little lighter where the mirror used to be. There isn't much left to see.\n\n" +
					"Press R to return to the cell.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.cell_mirror;}

		
		
		}
		
	void corridor_0 (){
		text.text = "You push against the door with what strength you can muster. Begrudingly, the heavy iron door slides open. " +
					"A long hallway stretches in front of you, with a few more doors dotted along the way. One door leads to another " +
					"cell that doesn't appear to be locked. The other door is completely solid and looks locked. A small iron grate has been " +
					"installed into the rock near the floor between the doors. A solitary torch at the far " +
					"end illuminates the hallway, casting flickering shadows upon the walls.\n\n" +
					"Press C to enter the other cell, T to examine the torch, G to examine the grate and D to examine the heavy door.";
		
		if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.nextcell_0;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.torch_0;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.grate_0;}
		else if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.door_0;}
		
	}
	
	void torch_0 (){
		text.text = "A torch hangs from the wall, small droplets of burning oil dribbling down to extinguish upon the cold floor. "+
					"The heat and light from the torch offer a small amount of comfort in this foreboding place. The torch is securely " +
					"fastened into its holder with three screws.\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_0;}	
	}
	
	void grate_0 (){
		text.text = "Crouching down, you examine the grate. The bars are entirely rusted and one of them has removed entirely from its fixings. "+
					"You could just about reach inside the grate, but without any light, who knows what lurks in the darkness?\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_0;}
	}
	
	void door_0 (){
		text.text = "A heavy door stands before you. Unlike the doors to the cells, there are no bars that you can see through. "+
					"Yanking on the handle does nothing. There is a single keyhole which looks well used.\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_0;}
	}
	
	void nextcell_0 (){
		text.text = "The door to the other cell slides open easily. A horrible stench fills your nostrils as you step inside. "+
					"The cell is nearly identical to yours, with the exception of a decomposing corpse lying on the floor " +
					"in the far corner. The front of its clothes are heavily stained with blood.\n\n" +
					"Press B to examine the body, press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.body_0;}
	}
	
	void body_0 (){
		text.text = "It looks like this poor soul has been here for a very long time. The skin has dried and sunken inwards, leaving "+
					"only an emaciated skeleton behind. Many of the bones look like they have been periodically gnawed upon by "+
					"some hungry vermin. Jutting from the chest of the corpse is a jagged looking chunk of metal.\n\n" +
					"Press T to take the chunk of metal, press R to return to the rest of the cell.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.nextcell_0;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.nextcell_1;}
	}
	
	void corridor_1 (){
		text.text = "Weapon in hand, you start to feel better about your chances of escape. The dim hallway seems a little less " +
					"foreboding now that you can defend yourself. The heavy door still taunts you and now the stench from the cell "+
					"is wafting into the corridor. The torch flickers like a beacon in the darkness, while the grate silently keeps its "+
					"secrets.\n\n" +
					"Press C to enter the other cell, T to examine the torch, G to examine the grate and D to examine the heavy door.";
		
		if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.nextcell_1;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.torch_1;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.grate_1;}
		else if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.door_1;}
	}
	
	void torch_1 (){
		text.text = "A torch hangs from the wall, small droplets of burning oil dribbling down to extinguish upon the cold floor. "+
					"The heat and light from the torch offer a small amount of comfort in this foreboding place. The torch is securely " +
					"fastened into its holder with three screws. The tip of the chunk of metal looks like it might just fit into "+
					"those screwheads.\n\n" +
					"Press U to unfasten and take the torch, press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}
		else if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.corridor_2;}	
	}
	
	void grate_1 (){
		text.text = "From within the abyss you can hear a sort of strange shuffling sound, like small, clawed feet scuttling "+
					"about quickly. The urge to reach your hand in is quite strong but it might be best to look before you leap... "+
					"at least, this time.\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}
	}
	
	void door_1 (){
		text.text = "A heavy door stands before you. Unlike the doors to the cells, there are no bars that you can see through. "+
					"Yanking on the handle does nothing. There is a single keyhole which looks well used. You could stick that "+
					"chunk of metal into the keyhole, but a feeling in your gut tells you that might make things worse.\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}	
	}
	
	void nextcell_1 (){
		text.text = "The cell is nearly identical to yours, with the exception of a decomposing corpse lying on the floor " +
					"in the far corner. The front of its clothes are heavily stained with blood.\n\n" +
					"Press B to examine the body, press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.body_1;}
	}
	
	void body_1 (){
		text.text = "The corpse is still here. There is a ragged hole between the chest bones where the chunk of metal had been. "+
					"You could put that chunk of rusted metal back if you wanted to but hasn't this poor soul suffered enough?\n\n" +
					"Press R to return to the rest of the cell.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.nextcell_1;}	
	}
	
	void corridor_2 (){
		text.text = "Now you can shine that warm torchlight into every knook and cranny of this vile dungeon. That sick feeling in "+
					"your stomach has settled now that corpse smell has faded somewhat. A muffled scream sounds from far away "+
					"and causes the hairs on the back of your neck to stand up. A sense of dread begins to settle into your bones.\n\n" +
					"Press C to enter the other cell, T to examine the torch, G to examine the grate and D to examine the heavy door.";
		
		if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.nextcell_2;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.torch_2;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.grate_2;}
		else if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.door_2;}
	}
	
	void torch_2 (){
		text.text = "There is nothing but an empty holder now.\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_2;}
			
	}
	
	void grate_2 (){
		text.text = "Crouching down and bringing the torch close, you can just about see something glittering just "+
					"inside the grate. You could reach inside and grab it, if you dare.\n\n" +
					"Press R to reach inside the grate, or C to chicken out.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.key_0;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.corridor_2;}	
	}
	
	void door_2 (){
		text.text = "A heavy door stands before you. Unlike the doors to the cells, there are no bars that you can see through. "+
					"Yanking on the handle does nothing. There is a single keyhole which looks well used. You could stick that "+
					"chunk of metal into the keyhole, but a feeling in your gut tells you that might make things worse. With "+
					"the torch in hand, you can really see that the keyhole requires a key.\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}
	}
	
	void nextcell_2 (){
		text.text = "The cell is nearly identical to yours, and fills with flickering light as you bring the torch inside. "+
					"The warm orange light reveals thousands upon thousands of small scratches dug into the hard, unforgiving "+
					"walls. As you look closer, you realize these markings were made with fingernails and you can't help but "+
					"look at the corpse in the corner with pity.\n\n" +
					"Press B to examine the body, press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_2;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.body_2;}
	}
	
	void body_2 (){
		text.text = "The corpse is still here but now you can see it even better. It looks this one died slowly and horribly. Hopefully "+
					"that won't be your fate. There is a ragged hole between the chest bones where the chunk of metal had been.\n\n" +
					"Press R to return to the rest of the cell.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.nextcell_1;}
	}
	
	void key_0 (){
		text.text = "You slowly, hesitantly, reach your hand inside the grate. Groping around you feel a few different things beneath "+
					"your fingertips. Something fast and furry brushes past your hand. Stiffling a gasp, you keep searching until your hand "+
					"touches something cold and metallic. Do you grab it?\n\n" +
					"Press G to grab the object, R to pull your hand back from the darkness.";
		
		if (Input.GetKeyDown(KeyCode.G)) 			{myState = States.grate_3;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.grate_2;}
		
		
	}
	void corridor_3 (){
		text.text = "Armed and dangerous with the key in hand, you can feel a small flicker of hope begin to build inside "+
					"of you. There might just be a chance now.\n\n" +
					"Press C to enter the other cell, T to examine the torch, G to examine the grate and D to examine the heavy door.";
		
		if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.nextcell_3;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.torch_3;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.grate_3;}
		else if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.door_3;}
	}
	
	void torch_3 (){
		text.text = "There is nothing but an empty holder now.\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_3;}
		
	}
	
	void grate_3 (){
		text.text = "The grate stares back at you, dimly lit by the torch. There is nothing inside for you now.\n\n" +
					"Press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_3;}
	}
	
	void door_3 (){
		text.text = "A heavy door stands before you. Unlike the doors to the cells, there are no bars that you can see through. "+
					"Yanking on the handle does nothing. There is a single keyhole which looks well used. You've got a key now, you're armed "+
					"and the torch is burning brightly. Put the key in the keyhole?\n\n" +
					"Press I to insert the key into the hole, or press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_3;}
		else if (Input.GetKeyDown(KeyCode.I)) 		{myState = States.stairs_0;}
		
	}
	
	void nextcell_3 (){
		text.text = "The cell is nearly identical to yours, and fills with flickering light as you bring the torch inside. "+
					"The warm orange light reveals thousands upon thousands of small scratches dug into the hard, unforgiving "+
					"walls. You examine the walls but there is nowhere that you could put that key.\n\n" +
					"Press B to examine the body, press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_3;}
		else if (Input.GetKeyDown(KeyCode.B)) 		{myState = States.body_3;}
	}
	
	void body_3 (){
		text.text = "If you didn't have your wits about you, you might have ended up like this poor soul. How long did it wait "+
					"and hope to be freed? Why wasn't it as fortunate as you are? One might never know.\n\n" +
					"Press R to return to the rest of the cell.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.nextcell_3;}
	}
	void stairs_0 (){
		text.text = "The lock clicks and the door slowly opens towards you. A wash of foul smelling air wafts down a set of dark "+
					"stairs. You'd know that stench anywhere: Goblins. Who knows how many of them might be up there, and what if it "+
					"isn't just Goblins?\n\n" +
					"Press G to go up the stairs or press R to return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.nextcell_3;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.upstairs_0;}
	}
	
	void upstairs_0 (){
		text.text = "You creep up the stairs slowly, going step by step. At the top of the stairs there is another door that is slight ajar. "+
					"You can hear footsteps and grumbling just beyond the door. You hold your breath so as not to make any noise and wait "+
					"until the noise passes. Now the fun begins.\n\n";
		
	}
	
	}
