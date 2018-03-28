/*	ProximitySensor Class v0.80
//	Author : GeeknessFr
//  Original Release Date : 03-28-2018
*/

using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using System.Collections.Generic;

namespace Eco.ProximitySensor
{

    public static class ProximitySensor
    {
        public static bool IsAnyone(this WorldObject Obj, int SensorDistance = 20)
        {
            foreach (User user in UserManager.OnlineUsers)
            {
                float dist = Vector3.Distance(Obj.Position, user.Position);
                if (dist <= SensorDistance)
                {
                    return true;
                }
            }
            return false;
        }

        public static IEnumerable<User> GetAnyone(this WorldObject Obj, int SensorDistance = 20)
        {
            List<User> Users = new List<User>();
            foreach (User user in UserManager.OnlineUsers)
            {
                float dist = Vector3.Distance(Obj.Position, user.Position);
                if (dist <= SensorDistance)
                    Users.Add(user);
            }
            return Users;
        }
    }
}
