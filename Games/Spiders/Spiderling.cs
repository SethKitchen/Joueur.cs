// Generated by Creer at 05:20PM on April 08, 2016 UTC, git hash: 'e7ec4e35c89d7556b9e07d4331ac34052ac011bd'
// A Spider spawned by the BroodMother.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Spiders
{
    /// <summary>
    /// A Spider spawned by the BroodMother.
    /// </summary>
    class Spiderling : Spiders.Spider
    {
        #region Properties
        /// <summary>
        /// When empty string this Spiderling is not busy, and can act. Otherwise a string representing what it is busy with, e.g. 'Moving', 'Attacking'.
        /// </summary>
        public string Busy { get; protected set; }

        /// <summary>
        /// How much damage this Spiderling does to the BroodMother.
        /// </summary>
        public int Damage { get; protected set; }

        /// <summary>
        /// The Web this Spiderling is using to move. Null if it is not moving.
        /// </summary>
        public Spiders.Web MovingOnWeb { get; protected set; }

        /// <summary>
        /// The Nest this Spiderling is moving to. Null if it is not moving.
        /// </summary>
        public Spiders.Nest MovingToNest { get; protected set; }

        /// <summary>
        /// How much distance this Spiderling covers per turn when moving across Webs.
        /// </summary>
        public float Speed { get; protected set; }

        /// <summary>
        /// The number of turns remaining for this Spiderling's current task.
        /// </summary>
        public int TurnsRemaining { get; protected set; }

        /// <summary>
        /// How heavy this spider is. Webs it moves across must have enough strength to support it in addition to existing Spiderlings.
        /// </summary>
        public int Weight { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of Spiderling. Used during game initialization, do not call directly.
        /// </summary>
        protected Spiderling() : base()
        {
        }

        /// <summary>
        /// Attacks another Spiderling
        /// </summary>
        /// <param name="spiderling">The Spiderling to attack.</param>
        /// <returns>True if the attack was successful, false otherwise.</returns>
        public bool Attack(Spiders.Spiderling spiderling)
        {
            return this.RunOnServer<bool>("attack", new Dictionary<string, object> {
                {"spiderling", spiderling}
            });
        }

        /// <summary>
        /// Starts moving the Spiderling across a Web to another Nest.
        /// </summary>
        /// <param name="web">The Web you want to move across to the other Nest.</param>
        /// <returns>True if the move was successful, false otherwise.</returns>
        public bool Move(Spiders.Web web)
        {
            return this.RunOnServer<bool>("move", new Dictionary<string, object> {
                {"web", web}
            });
        }


        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
