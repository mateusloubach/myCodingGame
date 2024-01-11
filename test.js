function subsetA(arr) {
    // Sort the array in descending order
    arr.sort((a, b) => b - a);
  
    let subsetA = [];
    let sumA = 0;
    let sumB = 0;
  
    for (let i = 0; i < arr.length; i++) {
      // Add the current element to subsetA
      subsetA.push(arr[i]);
      sumA += arr[i];
  
      // Calculate sumB
      sumB = arr.slice(i + 1).reduce((acc, val) => acc + val, 0);
  
      // Check if sumA is greater than sumB
      if (sumA > sumB) {
        // Return only the first two elements of the sorted subsetA as an array
        return subsetA.sort((a, b) => a - b).slice(0, 2);
      }
    }
  
    // If no valid subset is found, return an empty array
    return [];
  }
  
  // Test Cases
  const testCases = [
    [5, 3, 2, 4, 1, 2],
    [4, 2, 5, 1, 6],
    // Add more test cases as needed
  ];
  
  // Expected Outputs
  const expectedOutputs = [
    [4, 5],
    [5, 6],
    // Specify the expected output for each test case
  ];
  
  // Verify the outputs
  for (let i = 0; i < testCases.length; i++) {
    const result = subsetA(testCases[i]);
    const expected = expectedOutputs[i];
  
    console.log(`${result.join('\n')}`);
  }