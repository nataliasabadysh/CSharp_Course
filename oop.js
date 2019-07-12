// let baseSalary = 3000;
// let rate = 20;
// let overtime = 20;

// function getWage(baseSalary, rate, overtime){
//     return baseSalary + (rate * overtime);
// }

// Using OOP stactire 

let employee ={ 
     baseSalary = 3000,
     rate = 20,
     overtime = 20,

     getWage: function(baseSalary, rate, overtime){
        return baseSalary + (rate * overtime);
    } 
} 
employee.getWage();
