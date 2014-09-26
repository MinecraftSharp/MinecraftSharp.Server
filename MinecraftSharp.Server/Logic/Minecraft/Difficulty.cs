using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftSharp.Server.Logic.Minecraft
{
    /// <summary>
    /// Specifies how difficulty of the server. Contains custom dificulties
    /// </summary>
    public enum Difficulty
    {
        /// <summary>
        /// No hostile mobs will spawn and hunger will not drain.
        /// </summary>
        Peaceful = 0,
        /// <summary>
        /// Hostile mobs will spawn and will not be difficult to overcome.
        /// Hunger will not drain.
        /// </summary>
        Easy = 1,
        /// <summary>
        /// Hostile mobs will spawn.
        /// Hunger will drain, but will not cause death when empty.
        /// </summary>
        Normal = 2,
        /// <summary>
        /// Hostile mobs will spawn and be more damaging and difficult.
        /// Hunger will drain and death by starvation is possible.
        /// </summary>
        Hard = 3,
        /// <summary>
        /// Hostile mobs will spawn with more frequency with more damage and health
        /// Hunger will drain and when hunger reaches 0 the user will take damage until death unless they eat
        /// The user will not be banned when they die
        /// </summary>
        Hardcore = 4,
        /// <summary>
        /// Hostile mobs will spawn with more frequency with more damage and health
        /// Hunger will drain and when hunger reaches 0 the user will take damage until death unless they eat
        /// The player will be banned when they die after a certain number of times
        /// </summary>
        HardcoreMultiBan = 5,
        /// <summary>
        /// Hostile mobs will spawn with more frequency with more damage and health
        /// Hunger will drain and when hunger reaches 0 the user will take damage until death unless they eat
        /// The player will be banned when  they die
        /// </summary>
        HardcoreBan = 6,
        /// <summary>
        /// This is the hardest, custom dificulty setting
        /// When the user reaches 0 hunger, the user will die
        /// User may or may not be able to break blocks/place blocks with less then 4 hunger
        /// User will receive negitive buffs until they eat. You will know when you are hungry
        /// User can earn a life potion [Special potion] to gain another life. User starts with the life they currently have
        /// If the user dies, they will be notified with the amount of lives that they have
        /// User will be banned if they die
        /// </summary>
        UltraHardcoreBan = 7
    }
}