def display_menu(menu_dict):
    print('THIS IS TODAY\'S MENU:')
    for key, value in menu_dict.items():
        print(f'{key}: {value}')

def additem(newitem, menu_dict):
    
    new_key = max(menu_dict.keys()) + 1
    menu_dict[new_key] = newitem
    print(f'New item added: {menu_dict}')

def updateitem(menu_dict, new_item, key):
    if key in menu_dict:
        menu_dict[key] = new_item
        print(f'Updated Menu is: {menu_dict}')
    else:
        print(f'Key {key} does not exist in the menu  u cannot update .')

def removeitem(menu_dict, key):
    if key in menu_dict:
        del menu_dict[key]
        print(f'Updated Menu is: {menu_dict}')
    else:
        print(f'Key {key} does not exist in the menu u cannot remove .')

def main():
    menu_dict = {}
    
    print('Enter the number of items in the menu:')
    size = int(input())

    print('Enter the items:')
    for i in range(size):
        item = input()
        menu_dict[i + 1] = item

    print('User Menu:', menu_dict)
    display_menu(menu_dict)
    print()

    new_item = input("Enter the item you need to add: ")
    additem(new_item, menu_dict)
    print()

    update_key = int(input("Enter the key of the item to update: "))
    change_item = input("Enter the new item to update: ")
    updateitem(menu_dict, change_item, update_key)
    print()

    rem_key = int(input("Enter the key of the item to remove: "))
    removeitem(menu_dict, rem_key)

if __name__ == "__main__":
    main()




