// import riddle1 from './riddles/r1.js';
// import riddle2 from './riddles/r2.js';
import arrOfRiddlels from "./riddles/Riddlels.js";
import Player from './classes/Player.js';
import Riddle from './classes/Riddle.js';
import readline from 'readline-sync';

console.log("Welcome to the Riddle Game!");

const name = readline.question("What is your name? ");
const player1 = new Player(name);

// const arrRiddles = [riddle1, riddle2];

for (const item of arrOfRiddlels) {
    const start = Date.now();

    const currentRiddle = new Riddle(item);
    currentRiddle.ask();

    const end = Date.now();
    player1.recordTime(start, end);


    
}
player1.showStats();



