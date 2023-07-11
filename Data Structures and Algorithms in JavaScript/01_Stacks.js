// Stacks 📚

// Functions: push, pop, peek, length or size

var letters = []; // this is our stack 

var word = "racecar";

var rword = "";

// Put letters of word into stack
for(var i = 0; i < word.length; i++){
    letters.push(word[i]);
}

// pop off the stack in reverse order 
for (let i = 0; i < letters.length; i++) {
    rword += letters.pop()
}

if (word === rword){
    console.log(word + " is a palindrome");
}
else{
    console.log(word + " is not a palindrome");
}