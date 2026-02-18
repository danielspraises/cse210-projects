using System;

// EXCEEDING REQUIREMENTS:
// - Added Leveling System based on score.
// - Added NegativeGoal class (lose points for bad habits).
// - Added Achievement Badge system that unlocks rewards
//   based on milestones like first goal, score levels,
//   and first completed goal.


class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
