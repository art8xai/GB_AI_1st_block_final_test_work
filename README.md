# GB_AI_1st_block_final_test_work
Final test work based on the results of the first block of education

## Solution description is presented using Gaddis Pseudocode

// The main method that, from an existing array of strings, forms a new array of strings whose length is less than or equal to N symbols.

// string[] GetArrayLessOrEqualSymbolQuantity(string[] arraySource, int symbolQuantity)

// Step 1. Determining the size of a new array.

    Declare Integer sizeArrayNew
    Set sizeArrayNew = 0
    For i = 0 To size(arraySource) - 1
        If length(arraySource[i]) <= symbolQuantity Then
            Set sizeArrayNew = sizeArrayNew + 1
        End If
    End For

// Step 2. Creating a new empty array of the size calculated above.
    
    Declare String arrayNew[sizeArrayNew]

// Step 3. Checking each value of the source array. If the value matches the condition by the number of symbols, then this value is written to a new array.

    Declare Integer j
    Set j = 0
    For i = 0 To size(arraySource) - 1
        If length(arraySource[i]) <= symbolQuantity Then
            Set arrayNew[j] = arraySource[i]
            Set j = j + 1
        End If
    End For

// return arrayNew
