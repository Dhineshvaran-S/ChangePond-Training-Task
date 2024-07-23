def sum_function(list, size):
    total = 0
    for i in range(size):
        total += list[i]
    return total

def max_function(list, size):

    max_value = list[0]  
    for i in range(1, size):
        if list[i] > max_value:
            max_value = list[i]
    return max_value

def main():
    numbers = []
    size = int(input("Enter the size of the list: "))
    
    for i in range(size):
        
        value = int(input(f"Enter value {i+1}: "))
        # i+=1
        numbers.append(value)
    
    # Calculate and print results after collecting all inputs
    total_sum = sum_function(numbers, size)
    max_value = max_function(numbers, size)

    print(f"Sum of the list is : {total_sum}")
    print(f"Maximum of the list is : {max_value}")

if __name__ == "__main__":
    main()
