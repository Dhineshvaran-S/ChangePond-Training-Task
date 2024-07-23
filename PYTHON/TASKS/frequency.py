

def main():
    Str = input("Enter the string to find the frequency of letters: ")
    List = []
    for i in range(len(Str)):
        if Str[i] in List:
            continue
        
        count = 1 
        
        for j in range(i + 1, len(Str)):
            if Str[i] == Str[j]:
                count += 1
        
       
        List.append(Str[i])
        
     
        print(f'{Str[i]} repeated {count} times')

if __name__ == "__main__":
    main()