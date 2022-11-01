using System.Collections.Generic;


namespace Unit04_greed.Game.Casting
{
    
    // Keeps track of Actors and Artifacts
    
    
    public class Cast
    {
        private Dictionary<string, List<Actor>> _actors = new Dictionary<string, List<Actor>>();

        // Constructs a new instance of Cast.
        public Cast()
        {
        }

        // Adds the given actor to the given group.
        public void AddActor(string group, Actor actor)
        {
            if (!_actors.ContainsKey(group))
            {
                _actors[group] = new List<Actor>();
            }

            if (!_actors[group].Contains(actor))
            {
                _actors[group].Add(actor);
            }
        }


        // Gets the actors in the given group. Returns an empty list if there aren't any.
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (_actors.ContainsKey(group))
            {
                results.AddRange(_actors[group]);
            }
            return results;
        }

        // Returns a list of all actors in the cast.
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in _actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        // Gets the first actor in the given group.
        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (_actors.ContainsKey(group))
            {
                if (_actors[group].Count > 0)
                {
                    result = _actors[group][0];
                }
            }
            return result;
        }

        // Removes the given actor from the given group.
        public void RemoveActor(string group, Actor actor)
        {
            if (_actors.ContainsKey(group))
            {
                _actors[group].Remove(actor);
            }
        }

    }
}