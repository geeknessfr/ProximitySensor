# ProximitySensor
ECO Mod Library to give some information if a player is near a WorldObject.

- Author : GeeknessFr
- Original Release Date : 2018-03-23
- Update Date : 2018-03-28

----

### Details :
This DLL is not a MOD ! You have to add it as a Reference in your Visual Studio Project.

**Namespace :** Eco.ProximitySensor

**Functions :**
- ``bool IsAnyone(this WorldObject Obj, int SensorDistance = 20)``
- ``IEnumerable<User> GetAnyone(this WorldObject Obj, int SensorDistance = 20)``


You can implement it in your WorldObject by adding :

- ``using Eco.ProximitySensor;``

And in you WorldObject declaration, you could add this override :
```C
public override void Tick()
{
    base.Tick();
    if (this.IsAnyone())    // Return true if any player is near the object.
        foreach (User user in this.GetAnyone())   // Return a list of all players in range.
        {

        }
}
```

This code is here as an exemple, take care with Tick() which is called 10 times / second ! So don't put a chat message here, for exemple, this will flood the chat and i'm sure this is not what you would.



### Licence :
These files are Free to use in your projects and are provided for Personnal and Non-Commercial Use ONLY !

All i would is to credit me in your release description if you use it.

All requests may be addressed to me by mail -> geekness.fr@gmail.com
Or on Eco Official Discord.


### Changelog :

**2018-03-28 - v0.80**
- Public Release.
