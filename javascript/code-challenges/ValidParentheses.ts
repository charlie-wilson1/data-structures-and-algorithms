function isValid(s: string): boolean {

    /* check if brackets number is even or odd. if odd return false immediately.

    iterate through each character in string.
    if character is an opening bracket, then push it onto string.
    
    else if character is closing bracket, check if previous value in array is
     the corresponding opening bracket.

    if it is the corresponding bracket, then remove the opening bracket 
    from the stack and continue as normal.

    if it isn't, then return false.
    return true at end if array is empty.
    */
    
    if (s.length % 2 !== 0) return false;
    
    let ansArr: string[] = [];
    
    for (let c = 0; c < s.length; c++) {
        // push first 
        if (s[c] === '(' || s[c] === '{' || s[c] === '[') {
            ansArr.push(s[c]);
            console.log('pushing ' + s[c]);
        }
        if (s[c] === ')') {
            //ansArr[ansArr.length - 1] === '(' ? ansArr.pop() : return false;
            if (ansArr[ansArr.length - 1] === '(') {
                console.log('popping ' + ansArr[ansArr.length - 1]);
                ansArr.pop();
            } else {
                return false;
            }
        }
        if (s[c] === '}') {
            //ansArr[ansArr.length - 1] === '{' ? ansArr.pop() : return false;
            if (ansArr[ansArr.length - 1] === '{') {
                console.log('popping ' + ansArr[ansArr.length - 1]);
                ansArr.pop();
            } else {
                return false;
            }
        }
        if (s[c] === ']') {
            //ansArr[ansArr.length - 1] === '[' ? ansArr.pop() : return false;
            if (ansArr[ansArr.length - 1] === '[') {
                console.log('popping ' + ansArr[ansArr.length - 1]);
                ansArr.pop();
            } else {
                return false;
            }
        }
    }
    if (ansArr.length > 0) return false;
    else return true;
};

            


