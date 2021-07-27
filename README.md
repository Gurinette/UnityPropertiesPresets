### Unity GameSettings scriptable objects

Unity version: 2020.3.8f1 LTS

Game settings example:
<br />
![alt text](https://github.com/Gurinette/UnityGameSettings/blob/master/Instructions/Inspector.png?raw=true)
<br />
Using GameSettings , you can create custom settings for your Unity projects.
The main benefit of GameSettings is the ability to have multiple presets in a single scriptable object file.

Using presets, you can toggle between multiple settings presets and have it reflect in your entire project where you have referenced the scriptable object with ease.
Some use case scenarios include the ability to toggle between release and debug settings for your game to skip
things like tutorials for faster iterations, or having multiple presets for an enemy settings to see how different settings feel.

To create new settings for your game, you simply right click in your project tab, then Create > Game Settings Script.
<br />
![alt text](https://github.com/Gurinette/UnityGameSettings/blob/master/Instructions/GameSettingsScript.png?raw=true)
<br />
Then to create a scriptable object of that new setting, right click > Create > Scriptable Object > Settings > ExampleSettings.
<br />
![alt text](https://github.com/Gurinette/UnityGameSettings/blob/master/Instructions/GameSettings.png?raw=true)
<br />
Finally, to modify the game settings template, you can do so in:
Assets/ScriptTemplates/100-Game Settings Script-NewGameSettingsScript.cs.txt

Feel free to modify any of the files for your projects needs; if you thought of improvements for the presets I would love to hear about them!

Feel free to use this in any of your projects; no attribution required, but highly appreciated!