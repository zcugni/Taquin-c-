using System;
using System.Collections.Generic;
using System.Linq;

namespace gameOfFifteen {
    /// <summary>
    /// Contains general methods that are usefull but no specific to this project 
    /// </summary>
    static class Utility {
        /// <summary>
        /// Swap two variable in a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listToModify"></param>
        /// <param name="indexVarOne"></param>
        /// <param name="indexVarTwo"></param>
        static public void swapListVar<T>(ref List<T> listToModify, int indexVarOne, int indexVarTwo) {
            T tempValue = listToModify[indexVarOne];
            listToModify[indexVarOne] = listToModify[indexVarTwo];
            listToModify[indexVarTwo] = tempValue;
        }
    }
}
