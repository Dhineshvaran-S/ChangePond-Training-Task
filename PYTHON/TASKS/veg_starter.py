def display_menu(list):
   
        print(f'THIS IS TODAY MENU: {list}')
       
         
def additem(newitem,list):
    
     
        list.append(newitem)
        print(f'New item added: {list}')
         
def updateitem(list,new_item,index):
    
    
        list[index]=new_item
        print(f'Updated List is : {list}')

def removeitem(list,remove):
        list.remove(remove)
        print(f'Updated List is : {list}')
def main():
    
    print('Enter the size of the list:')
    size = int(input())  
    
  
    veg_starter = []
    

    print('Enter the values:')
    for i in range(size):
        value = input() 
        veg_starter.append(value)  
    
   
    print('User List:', veg_starter)
    display_menu(veg_starter)
    print()
    new_item=input("Enter the item you need to add ")
    print()
    additem(new_item, veg_starter)
    print()
    update_index=int(input("enter the index at which u need to update "))
    print()
    change_item=input("Enter the item to update ")
    print()
    updateitem(veg_starter,change_item,update_index)
    print()
    rem_item=(input("Enter The item to remove "))
    print()
    removeitem(veg_starter,rem_item)



if __name__ =="__main__":
    main()