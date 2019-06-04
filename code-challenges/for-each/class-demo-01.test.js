// function getRemainder(n, m){
//   return n % m;
// }

// describe('modulu functionality', () => {
//   test('test 4 mod 3 is 1', () => {
//     const expected = 1;
//     const actual = getRemainder(4,3);
//     expect(actual).toBe(expected);
//   });
//   test('test 4 mod 3 is 1', () => {
//     const expected = 7;
//     const actual = getRemainder(4,3);
//     expect(actual).toBe(expected);
//   });
// });

function operate (a, b, operation){
  if(operation === 'add'){
    return a + b;
  } else if (operation === 'subtract'){
    return a - b;
  }
}

describe ('sum two numbers', () => {

  it('should add two numbers', () => {
    const expected = 4;
    const actual = operate(2,2,'add');
    expect(actual).toBe(expected);
  });

  it('should subtract two numbers', () => {
    const expected = 0;
    const actual = operate(2,2,'subtract');
    expect(actual).toBe(expected);
  });
});
