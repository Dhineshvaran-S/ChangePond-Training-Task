def addition(value1, value2):
    return value1 + value2

def subtraction(value1, value2):
    return value1 - value2

def multiplication(value1, value2):
    return value1 * value2

def division(value1, value2):
    if value2 != 0:
        return value1 / value2
    else:
        return "Error: Division by zero"

# Dictionary to map operation names to their respective functions
operations = {
    1: ("Addition", addition),
    2: ("Subtraction", subtraction),
    3: ("Multiplication", multiplication),
    4: ("Division", division)
}

def main():
    print('Choose operation')
    print('1. Addition\n2. Subtraction\n3. Multiplication\n4. Division')
    select = int(input('Select 1/2/3/4: '))

    if select in operations:
        operation_name, operation_func = operations[select]
        num1 = int(input('Enter 1st number: '))
        num2 = int(input('Enter 2nd number: '))
        
        result = operation_func(num1, num2)
        print(f'{operation_name} of {num1} and {num2}: {result}')
    else:
        print('Invalid selection. Please choose 1, 2, 3, or 4.')

if __name__ == "__main__":
    main()
