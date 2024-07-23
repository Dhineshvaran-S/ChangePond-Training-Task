# def display_menu(list):
   
#         print(f'THIS IS TODAY MENU: {list}')
       
         
# def additem(newitem,list):
    
     
#         list.append(newitem)
#         print(f'New item added: {list}')
         
# def updateitem(list,new_item,index):
    
    
#         list[index]=new_item
#         print(f'Updated List is : {list}')

# def removeitem(list,remove):
#         list.remove(remove)
#         print(f'Updated List is : {list}')
# def main():
    
#     print('Enter the size of the list:')
#     size = int(input())  
    
  
#     veg_starter = []
    

#     print('Enter the values:')
#     for i in range(size):
#         value = input() 
#         veg_starter.append(value)  
    
   
#     print('User List:', veg_starter)
#     display_menu(veg_starter)
#     print()
#     new_item=input("Enter the item you need to add ")
#     print()
#     additem(new_item, veg_starter)
#     print()
#     update_index=int(input("enter the index at which u need to update "))
#     print()
#     change_item=input("Enter the item to update ")
#     print()
#     updateitem(veg_starter,change_item,update_index)
#     print()
#     rem_item=(input("Enter The item to remove "))
#     print()
#     removeitem(veg_starter,rem_item)



# if __name__ =="__main__":
#     main()

# *********************************************************

# num = int(input("Enter  the number of elements"))
# square_num = []
# for n in range(1, num+1):
#     square_num.append(n*n)
 
# print("Square list:", square_num)

# *********************************************************
# def sum_function(list, size):
#     total = 0
#     for i in range(size):
#         total += list[i]
#     return total

# def max_function(list, size):

#     max_value = list[0]  
#     for i in range(1, size):
#         if list[i] > max_value:
#             max_value = list[i]
#     return max_value

# def main():
#     numbers = []
#     size = int(input("Enter the size of the list: "))
    
#     for i in range(size):
        
#         value = int(input(f"Enter value {i+1}: "))
#         # i+=1
#         numbers.append(value)
    
#     # Calculate and print results after collecting all inputs
#     total_sum = sum_function(numbers, size)
#     max_value = max_function(numbers, size)

#     print(f"Sum of the list is : {total_sum}")
#     print(f"Maximum of the list is : {max_value}")

# if __name__ == "__main__":
#     main()


# *********************************************************

# def Addition(value1, value2):
#     Ans = value1+value2
#     return Ans

# def Subtraction(value1, value2):
#     Ans = value1-value2
#     return Ans

# def Multiplication(value1, value2):
#     Ans = value1*value2
#     return Ans

# def Division(value1, value2):
#     Ans = value1/value2
#     return Ans

# print('Choose operation')
# print('1.Addition\n2.Subtration\n3.Multiplication\n4.Division')
# select = int(input('Select 1/2/3/4 '))

# def main():
#     num01 = int(input('Enter 1st num'))
#     num02 = int(input('Enter 2st num'))

#     if(select == 1):
#         Ans =  Addition(num01,num02)
#         print(f'Addition {num01} and {num02}:',Ans)
#     elif(select == 2):
#         Ans =  Subtraction(num01,num02)
#         print(f'Subtration {num01} and {num02}:',Ans)
#     elif(select == 3):
#         Ans =  Multiplication(num01,num02)
#         print(f'Mutiplication {num01} and {num02}:',Ans)
#     elif(select == 4):
#         Ans =  Division(num01,num02)
#         print(f'Division{num01} and {num02}:',Ans)
#     else:
#         print('choose 1/2/3')

# if __name__ =="__main__":
#     main()


# *********************************************************


# def main():
#     Str = input("Enter the string to find the frequency of letters: ")
#     List = []
#     for i in range(len(Str)):
#         if Str[i] in List:
#             continue
        
#         count = 1 
        
#         for j in range(i + 1, len(Str)):
#             if Str[i] == Str[j]:
#                 count += 1
        
       
#         List.append(Str[i])
        
     
#         print(f'{Str[i]} repeated {count} times')

# if __name__ == "__main__":
#     main()


# *********************************************************





def check_for_spl_char(s):
    
    spl_char = "!@#$%^&*()-+?_=,<>/"
    
   
    for char in s:
        if char in spl_char:

            return True
    
    return False



if __name__ == "__main__":
    input_string = input("Enter a string: ")
    
    if check_for_spl_char(input_string):
        print("String has  special characters.")
    else:
        print("String has no special characters.")