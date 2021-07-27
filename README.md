### Unity Properties Presets scriptable objects

Unity version: 2020.3.8f1 LTS

Properties Presets example:
<br />
![alt text](https://github.com/Gurinette/UnityPropertiesPresets/blob/master/Instructions/Inspector.png?raw=true)
<br />
Using PropertiesPresets , you can create custom presets for your Unity projects.
The main benefit of PropertiesPresets is the ability to have multiple presets in a single scriptable object file.

You can toggle between multiple presets and have it reflect in your entire project where you have referenced the scriptable object with ease.
Some use case scenarios include the ability to toggle between release and debug presets for your game to skip
things like tutorials for faster iterations, or having multiple presets for an enemy stats to see how different presets feel.

To create new presets for your game, you simply right click in your project tab, then Create > Properties Presets Script.
<br />
![alt text](https://github.com/Gurinette/UnityPropertiesPresets/blob/master/Instructions/PropertiesPresetsScript.png?raw=true)
<br />
Then to create a scriptable object of the new Properties Presets, right click > Create > Scriptable Object > Properties Presets > ExamplePropertiesPresets.
<br />
![alt text](https://github.com/Gurinette/UnityPropertiesPresets/blob/master/Instructions/PropertiesPresets.png?raw=true)
<br />
Finally, to modify the PropertiesPresets template, you can do so in:
Assets/ScriptTemplates/100-Properties Presets Script-NewPropertiesPresets.cs.txt

Consider modifying any of the files for your projects needs; if you thought of improvements for the presets I would love to hear about them!

Feel free to use this in any of your projects; no attribution required, but highly appreciated!