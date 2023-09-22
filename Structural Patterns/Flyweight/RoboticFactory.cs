using DesignPatterns.Structural_Patterns.Flyweight.GameModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Flyweight
{
    /// <summary>
    /// By help of caching we avoid multiple object creation which helps in performance
    /// In this case we avoid Object creation for HumanoidRobo & DogRobo
    /// Suppose these are game objects and we have to build 
    /// an army of 5Lakh of each type - human or dog
    /// 
    /// Bad Approach: 
    /// We can loop over 5Lakh time and create the object but these 
    /// would crash our application as memory would be completely used
    /// 
    /// Good Approach: 
    /// So we use flyweight approach and split the model class in such a way 
    /// that all re-usable [Intrinsic] properties are present in the model
    /// but the changable [extrensic] properties we pass it as input in the method
    /// 
    /// Here Intrinsic property => type & body which does not change
    /// and Extrinsic property => co-ordinate values X & Y which change 
    /// </summary>
    public class RoboticFactory
    {
        //Caching object we are using library System.Runtime.Caching
        private static ObjectCache roboticObjectCache = MemoryCache.Default;

        public static IRobot createRobot(string robotType)
        {
            if (roboticObjectCache.Contains(robotType))
            {
                CacheItem cacheItem = roboticObjectCache.GetCacheItem(robotType);

                if (cacheItem.Value is IRobot roboclass)
                {
                    return roboclass;
                }
            }
            else
            {
                if (robotType == "HUMANOID")
                {
                    IRobot humanoidObject = new HumanoidRobo(robotType, new { item = "humanoid" });
                    roboticObjectCache.Set(robotType, humanoidObject,DateTime.Now.AddDays(1));
                    return humanoidObject;
                }
                else if (robotType == "ROBOTICDOG")
                {
                    IRobot roboticDogObject = new DogRobo(robotType, new { item = "dog" });
                    roboticObjectCache.Set(robotType, roboticDogObject, DateTime.Now.AddDays(1));
                    return roboticDogObject;
                }
            }
            return null;
        }
    }
}
