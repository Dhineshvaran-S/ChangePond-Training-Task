# open() function -> filename, mode(r,w,a,...)
# file_read = open('calci_dict.py','r')
# print(file_read.read())

import os 
def CreateFile(file_name): #filename = calci_dict.py
#filename=filtered.py
    if(os.path.exists(file_name)): 
        print('File already exists')
    else:
        file_create = open(file_name,'w')
        print('File created Sucessfully')

def main():
    print('Enter the file name you want to create :')
    file_name = input()

    CreateFile(file_name)

if __name__ == "__main__":
    main()