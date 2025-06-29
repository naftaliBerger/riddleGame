//ex1
// function extractNumbers(arr){
//     try{
//         if (!Array.isArray(arr)){
//             throw new Error("Error!! The input is not an array");
//         }
        
//             let onlyNUmbers = arr.filter(item => typeof(item) === "number");
//             return onlyNUmbers;
    
//         }
//         catch(error){
//             console.error(error.message)
//         }
//     }
    
// console.log(extractNumbers(["aaa",45,58,true]));


//ex2
// function sumNumbersSafe(arr){
//     let rezSum = 0;
//     try{
//         const arrNumbers = extractNumbers(arr);
//         if(arrNumbers.length == 0){
//             throw new Error ("The array is empty of numbers")
//         }
//         else{
//             arrNumbers.forEach(item => {
//                 rezSum += item;
                
//             });
//             return rezSum;
//         }
//     }
//     catch(error){
//         console.log(error.message);
//         return 0;
//     }
// }

// console.log(sumNumbersSafe(["aaa",45,58,true]));
// console.log(sumNumbersSafe(["aaa",true]));


//ex3



export default {}