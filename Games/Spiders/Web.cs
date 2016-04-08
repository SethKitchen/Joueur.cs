// Generated by Creer at 05:20PM on April 08, 2016 UTC, git hash: 'e7ec4e35c89d7556b9e07d4331ac34052ac011bd'
// A connection (edge) to a Nest (node) in the game that Spiders can converge on (regardless of owner). Spiders can travel in either direction on Webs.

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
    /// A connection (edge) to a Nest (node) in the game that Spiders can converge on (regardless of owner). Spiders can travel in either direction on Webs.
    /// </summary>
    class Web : Spiders.GameObject
    {
        #region Properties
        /// <summary>
        /// How long this Web is, i.e., the distance between its nestA and nestB.
        /// </summary>
        public float Length { get; protected set; }

        /// <summary>
        /// How much weight this Web currently has on it, which is the sum of all its Spiderlings weight.
        /// </summary>
        public int Load { get; protected set; }

        /// <summary>
        /// The first Nest this Web is connected to.
        /// </summary>
        public Spiders.Nest NestA { get; protected set; }

        /// <summary>
        /// The second Nest this Web is connected to.
        /// </summary>
        public Spiders.Nest NestB { get; protected set; }

        /// <summary>
        /// All the Spiderlings currently moving along this Web.
        /// </summary>
        public IList<Spiders.Spiderling> Spiderlings { get; protected set; }

        /// <summary>
        /// How much weight this Web can take before snapping and destroying itself and all the Spiders on it.
        /// </summary>
        public int Strength { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of Web. Used during game initialization, do not call directly.
        /// </summary>
        protected Web() : base()
        {
            this.Spiderlings = new List<Spiders.Spiderling>();
        }


        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
