
import Player from './classes/Player.js';
import Riddle from './classes/Riddle.js';
import riddleManagement from './riddles/riddleManagement.js'
import readline from 'readline-sync';

console.log("Welcome to the Riddle Game!");
console.log("");
const player1 = new Player(name);
const name = readline.question("What is your name? ");
console.clear();
console.log(`1.Play a game
2.Create a new puzzle
3.View all puzzles
4.Update an existing puzzle
5.Delete a puzzle
6.View the leaderboard
7.Exit`);
console.log("");
const num = readline.question("please enter a number: ")
switch(num){
    case 1:
        
    case 2:
        create() 
    case 3:
        read()

}



for (const item of arrOfRiddlels) {
    const start = Date.now();

    const currentRiddle = new Riddle(item);
    currentRiddle.ask();

    const end = Date.now();
    player1.recordTime(start, end);


    
}
player1.showStats();



