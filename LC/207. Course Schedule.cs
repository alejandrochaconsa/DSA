public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {

        // What do I know?
        // There are courses and pre requisites
        // int param, 2D int param
        // if a cycle is detected, we must return false, as we cannot complete the courses
        // else, if I'm able to complete all courses, return true
        // We have n number of courses, say 3 [0,1,2]
        // let's say to take 0 you have to take 1 first [0,1]
        // let's say there's no dependency to take 2 
        // Map looks like:
        // [0, [1]]
        // [1, []]
        // [2, [0]]
        
        // Approach:
        // [x] Validate numCourses 1 <= numCourses <= 2000
        // pre-requisites can be in range 0 <= prerequisites.length <= 5000
        // pre-requisites lenght is an array of 2, [course, prerequisite]
        // All the pairs prerequisites[i] are unique.
        // 1. Create a dictionary with mappings for all n courses and their prerequisites
        // 2. Iterate through all the courses in dictionary
        //  3. Iterate through its dependencies using DFS
        //      3.a. Add all courses to a COMPLETING SET
        //      3.b If I get to a course that has no dependencies, we can add that one to the CANCOMPLETE SET AND RETURN
        // 4. Add current course being iterated through in the dictionary to CANCOMPLETESET AND RETURN
        // 5. Clear COMPLETING SET and then Repeat 2
        // 6. If we get all the way here then we can complete all courses with no problem ELSE we found a cycle

        // Let's do this!!

        // Notes to self:
        // Alejo, this was one of those problems that kicked your ass. After several hours of digesting info, you were finally able to implement it on your own, BUT
        // is definitely a problem to revisit in the near future so its' engraved in your memory. You're 1% closer to your goal today. Parabens!

        // 1.
        Dictionary<int, List<int>> courseMap = new();
        HashSet<int> completing = new();
        HashSet<int> completed = new();

        for(int i = 0; i < numCourses; i++){
            courseMap.Add(i, new List<int>());
        }

        foreach(int[] courseAndPreReq in prerequisites){
            int course = courseAndPreReq[0];
            int preReq = courseAndPreReq[1];

            if(courseMap.ContainsKey(course)){
                courseMap[course].Add(preReq);
            }
        }

        // foreach(var kvp in courseMap){
        //     Console.WriteLine($"{kvp.Key} [{string.Join(",", kvp.Value)}]");
        // }

        // [0, [1]]
        // [1, []]
        // [2, []]
        // [3, [0]]
        bool HelperCanFinish(int course){
            // Base case
            if(completing.Contains(course)) return false; 
            if(completed.Contains(course)) return true;

            completing.Add(course);

            foreach(int preReq in courseMap[course]){
                bool result = HelperCanFinish(preReq);
                // bool result = HelperCanFinish(preReq, courseMap, completing, completed);
                if(!result){
                    return false;
                }
            }

            completing.Remove(course);
            completed.Add(course);

            return true;
        }

        // 2. Iterate through all courses
        for(int i = 0; i < numCourses; i++){
            
            bool result = HelperCanFinish(i);
            // bool result = HelperCanFinish(i, courseMap, completing, completed);
            // TODO: finish implementation
            if(!result){
                return false;
            }

        }
        return true;
    }

    // Example:
    // [0, [1]]
    // [1, []]
    // [2, [0]]
    // private bool HelperCanFinish(int course, Dictionary<int, List<int>> courseMap, HashSet<int> completing, HashSet<int> completed){

    //     // Base case
    //     if(completing.Contains(course)) return false; 
    //     if(completed.Contains(course)) return true;

    //     completing.Add(course);

    //     foreach(int preReq in courseMap[course]){
    //         bool result = HelperCanFinish(preReq, courseMap, completing, completed);
    //         if(!result){
    //             return false;
    //         }
    //     }

    //     completed.Add(course);

    //     return true;
    // }
}
