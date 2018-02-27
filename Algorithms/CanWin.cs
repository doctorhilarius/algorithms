using System;

namespace Algorithms {
    /// <summary>
    /// determines if the first player can win the game w/the first move
    /// </summary>
    public class CanWin {

        private int _max;

        public bool CanIWin(int max, int target) {

            // if either input is negative, or the max # is more than 20, or the target is more than 300, we have a problem
            if (max < 0 || target < 0 || max > 20 || target > 300) {
                throw new InvalidOperationException();
            }

            // if the target is zero or one or less than the max, the first player always wins
            if (target < 2 || target < max) {
                return true;
            }

            // get the sum of all the available numbers
            int sum = max * (max - 1) / 2 + max;

            // if the target is more than the sum of all the numbers, then no player can win
            if (target > sum) {
                return false;
            }

            // if the target equals the sum, the player w/the even/odd turn wins if the max is even/odd,
            // so the first (odd) player wins when the max is odd
            if (target == sum) {
                return max % 2 != 0;
            }

            this._max = max;

            // try the first scenario by playing the 1
            bool winnerPossible = false;
            for (int startNum = 1; startNum <= max; startNum++) {

                // reset the used numbers
                var usedNumbers = new bool[max];

                // if the winner is possible, break out of the loop
                winnerPossible = this.FindWinnerInTurnsTaken(usedNumbers, target, startNum, sum, 1);
                if (winnerPossible) {
                    startNum = max + 1;
                }
            }

            return winnerPossible;
        }

        private bool FindWinnerInTurnsTaken(bool[] usedNumbers, int target, int numberPlayed, int sum, int turnsTaken) {

            turnsTaken++;

            // set the new target based on the number played
            int newTarget = target - numberPlayed;

            // if the target is less than 1, it's impossible for there to be a remaining number that matches the target
            if (newTarget < 1) {
                return false;
            }

            // flag the number as being used
            int playedIndex = numberPlayed - 1;
            usedNumbers[playedIndex] = true;

            // if the sum of the rest of numbers is equal to the target, then last player to 
            int newSum = sum - numberPlayed;
            if (newTarget == newSum) {
                return this._max % 2 != 0;
            }

            // if the target is less than the max and the target hasn't been used, we have a winner
            int targetIndex = newTarget - 1;
            if (newTarget <= this._max && usedNumbers[targetIndex] == false) {
                return turnsTaken % 2 != 0;
            }

            for (int startNum = 1; startNum <= target; startNum++) {
                if (usedNumbers[startNum - 1] == false) {

                    var copy = new bool[this._max];
                    Array.Copy(usedNumbers, copy, this._max);

                    return this.FindWinnerInTurnsTaken(copy, newTarget, startNum, newSum, turnsTaken);
                }
            }

            // we've tested all the possibilities w/out finding a winner
            return false;
        }

    }
}
