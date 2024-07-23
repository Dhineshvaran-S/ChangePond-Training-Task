


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