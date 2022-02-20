// BRUTE FORCE
// Initialize nested for loop.
// Check against each case for length * width. until a maximum solution is found.
function maxAreaBruteForce(height: number[]): number {
    // set length equal to height.length
    
    // Create two nested for loops.
    // Check every length against the length of the previous by multiplying the lowest of the two points by the horizontal distance between them.
    // If that number is greater than the 'largestArea' variable, update largest to the factor of length * width.
    
    
    // Time: O(n^2). Nested for loop.
    // Space: O(n). No extra space being employed.
    
    let largestArea: number = 0;
    
    
    for (let i: any = 0; i < height.length; i++) {
        for (let j: any = i + 1; j < height.length; j++) {
            let lowestHeight: number = getMin(height[i], height[j]);
            let pillarLength: number = j - i;
            let area: number = lowestHeight * pillarLength;
            
            // console.log('lowest height is ' + lowestHeight);
            // console.log('pillar length is ' + pillarLength);
            
            if (area > largestArea) {
                largestArea = area;
            }
        }
    }
    
    return largestArea;
    
};


interface Band {
    bandName: string;
    BudgetAmount: number;

    // may also add any additional type or property for what you'd like.
    [key: string]: any;

}
const Motus: Band = {
    bandName: 'Motus',
    BudgetAmount: 100,
    bandMembers: 7
}

function maxAreaOptimal(height: number[]): number{

    let largestArea = 0;
    
    let l = 0;
    let r = height.length - 1;
    
    while (l < r) {
        console.log(height[l])
        console.log(height[r]);
        let minHeight = getMin(height[l], height[r]);
        let area = minHeight * (r - l);
        if (area > largestArea) largestArea = area;
        
        if (height[l] >= height[r]) r--;
        else l++;
    }
    return largestArea;
};

function getMin(height1, height2): number {
    // height1 <= height2 ? return height1 : return height2;
    
    if (height1 <= height2){
      return height1;  
    } 
    else return height2;

}

function getMin(height1, height2): number {
    // height1 <= height2 ? return height1 : return height2;
    
    if (height1 <= height2){
      return height1;  
    } 
    else return height2;
}