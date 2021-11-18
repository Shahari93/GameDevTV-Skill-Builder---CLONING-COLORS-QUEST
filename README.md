# GameDevTV Skill Builder - CLONING COLORS QUEST
 modifying a 2D platformer to interact with different Color properties
 
Challenges For This Quest
Light 'em Up:
In our ColorChanger script, create some logic so that a designer could choose between the three primary colors red, yellow, or blue in the inspector. In our Start() method, change the sprite's color to the selected color we've chosen for that game object. Create it in a way so that the designers can attach this script to any game object with a SpriteRenderer and easily choose the appropriate color in our ColorChanger script.

Magic Gem:
Create a new script we can attach to all our Gems in the Hierarchy. Create a way that our PlayerBlocks sprite color will change to the matching color of the gem when they come into contact with one another.

Spawn A Random Colored Block:
Modify our SpawnNewBlock.cs script to instantiate a block prefab to one of our 3 random colors to a position of your choice. The SpawnBlock() method is already rigged up to our UI button.

Spikey Hazard:
Modify the Hazard.cs spikes script to only destroy colored blocks that are not of the same color as the block itself. E.g., a blue block won't be destroyed by a blue spike.

Flashy Coin:
Create a new script that we can attach to our Coin. Create a way so that if a PlayerBlock of the matching color runs over the coin, the coin is destroyed. If it's not a matching color, create a flashing animation modifying our sprites alpha transparency for visual feedback to the user. You may choose to accomplish this through either direct scripting or using the animator; you choose how you want to tackle it!

Create A Win Condition:
Create a win condition of some kind to complete the level! Whether that's getting one or more blocks of the correct color to the coordinated flag, collecting coins, or anything else your game dev brain can come up with.

Puzzle Master:
Create your own level! Get creative and create a unique puzzle implementing what we've learned. Note you have a Tilemap Grid and Tile Palette set up for you and ready to go. Don't forget to post your level design on our Challenge Club forums page for this Quest!


