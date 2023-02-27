const sample=['I','am','learning','JS'];
const sample1=[...sample];
console.log(sample);

// spread operator is ...

console.log(...sample1);


// rest

let samp=function(...a)
{
    console.log(...a);
}
samp(20);
samp(10,20,30);


