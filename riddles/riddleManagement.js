import fs from "fs";
import rl from "readline-sync";


//read
export function read() {
    try {
        const data = fs.readFileSync("./bdRiddles.txt", "utf8");
        return JSON.parse(data);
    } catch (error) {
        console.log("error", error);
    }
}


//create
export function create() {
  const data = fs.readFileSync("./bdRiddles.txt", "utf8");
  const allData = JSON.parse(data);

  const puzzleName = rl.question("Please enter a name for the puzzle: ");
  const taskDescription = rl.question("Please enter the puzzle question: ");
  const correctAnswer = rl.question("Please enter the correct answer: ");

  const newRiddle = {
    id: allData.length + 1,
    name: puzzleName,
    taskDescription: taskDescription,
    correctAnswer: correctAnswer
  };

  allData.push(newRiddle);
  fs.writeFileSync("./bdRiddles.txt", JSON.stringify(allData));
  console.log("Riddle added successfully!");
}


// function update() {
//     fs.readFile("./bdRiddles.txt", "utf8", (err, data) => {
//       if (err) {
//         console.log(err.message);
//         return;
//       }
  
//       const allData = JSON.parse(data);
//       const index = rl.question("Please enter an index: ");
  
//       if (index > allData.length - 1) {
//         console.log("There is no such location!");
        
//       }
  
//       const newUser = rl.question("Please enter new user: ");
//       allData[index] = newUser;
  
//       fs.writeFile("./bdRiddles.txt", JSON.stringify(allData), (err) => {
//         if (err) {
//           console.error(err.message);
//         } else {
//           console.log("Updated successfully!");
//         }
//       });
//     });
//   }
  